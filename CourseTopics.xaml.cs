using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExaminationSystem
{
    /// <summary>
    /// Interaction logic for CourseTopics.xaml
    /// </summary>
    public partial class CourseTopics : Window
    {
        private int _curseId, _studentId, _insIDl;
        private ExaminationEntities1 ex;

        public CourseTopics(int _stdid, int _ins)
        {
            InitializeComponent();
            _studentId = _stdid;
            _insIDl = _ins;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ex = new ExaminationEntities1();

           
            CoursesTopicsList.ItemsSource = ex.topicsPerCourse();

            if (_insIDl != 0)
            {
                Course_Topics.ItemsSource = ex.CoursesByInstructor(_insIDl).Select(p => new { p.crs_Id, crs_Name= p.crs_name });
                var InsName = ex.selectFromInstructor(_insIDl).FirstOrDefault();
                string instName = $"{InsName.ins_FName} {InsName.ins_LName}";
                this.fullName.Text += instName;
            }
            if (_studentId != 0)
            {
                Course_Topics.ItemsSource = ex.courseList(_studentId);
                var stdName = ex.selectStudents().Where(s => s.std_Id == _studentId).FirstOrDefault();
                string studName = $"{stdName.std_FName} {stdName.std_LName}";
                this.fullName.Text += studName;
            }
        }

        private void GetCOurseNameAndAshow(object sender, RoutedEventArgs e)
        {
            string courseName = this.Course_Topics.Text;
            CoursesTopicsList.ItemsSource = ex.topicsPerCourse().Where(p => p.crs_name == courseName);
        }

        private void Course_Topics_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _curseId = Convert.ToInt32(Course_Topics.SelectedValue);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_insIDl == 0)
            {
                StudentInfo sf = new StudentInfo(_studentId);
                this.Close();
                sf.Show();
            }
            else if (_studentId == 0)
            {
                Instructor ins = new Instructor(_insIDl);
                this.Close();
                ins.Show();
            }
        }
    }
}