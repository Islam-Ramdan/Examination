using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ExaminationSystem
{
    /// <summary>
    /// Interaction logic for StudentExam.xaml
    /// </summary>
    public partial class StudentExam : Window
    {
        private int _stdId, _courseId, _examId;
        private ExaminationEntities1 ex;

        public StudentExam(int _id)
        {
            _stdId = _id;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ex = new ExaminationEntities1();
            subjectCombo.ItemsSource = ex.courseList(_stdId);
            examCombo.ItemsSource = ex.examsList(_stdId, _courseId);
            var stdObj = ex.selectStudents().Where(s => s.std_Id == _stdId).FirstOrDefault();
            this.studetName.Text += $"{stdObj.std_FName} {stdObj.std_LName}";
            
        }

        private void subjectCombo_SelectionChanged(object sender, RoutedEventArgs e)
        {
            _courseId = Convert.ToInt32(subjectCombo.SelectedValue);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StudentInfo sf = new StudentInfo(_stdId);
            this.Close();
            sf.Show();
        }

        private void showStudentExame(object sender, RoutedEventArgs e)
        {
            examContainer.ItemsSource = ex.StudentExam_Q_Ans_Subject(_stdId, _examId, _courseId);
        }

        private void examCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _examId = Convert.ToInt32(examCombo.SelectedValue);
        }
    }
}