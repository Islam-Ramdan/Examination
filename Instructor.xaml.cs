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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExaminationSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Instructor : Window
    {
        int instructor_id;
        public Instructor(int ins_id)
        {
            InitializeComponent();
            instructor_id = ins_id;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ExaminationEntities1 ex = new ExaminationEntities1();
            var insObj = ex.selectFromInstructor(instructor_id).FirstOrDefault();
            this.instructorName.Text += $"{insObj.ins_FName} {insObj.ins_LName}"; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewCoursesWindow crs_wind= new ViewCoursesWindow(instructor_id);
            this.Close();
            crs_wind.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddExamWindow add_exam_wind = new AddExamWindow(instructor_id);
            this.Close();
            add_exam_wind.Show();
        }

        private void btn_course_topics_Click(object sender, RoutedEventArgs e)
        {
            CourseTopics cts = new CourseTopics(0,instructor_id);
            this.Close();
            cts.Show();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InstructorLogin ins = new InstructorLogin();
            this.Close();
            ins.Show();
        }
    }
}
