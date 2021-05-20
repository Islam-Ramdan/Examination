using System.Linq;
using System.Windows;

namespace ExaminationSystem
{
    /// <summary>
    /// Interaction logic for StudentInfo.xaml
    /// </summary>
    public partial class StudentInfo : Window
    {
        private int _stdId;

        public StudentInfo(int _id)
        {
            _stdId = _id;
            InitializeComponent();
        }

        private void TakeExam(object sender, RoutedEventArgs e)
        {
            ExaminationEntities1 ex = new ExaminationEntities1();

            frm_ExamList tx = new frm_ExamList(_stdId);
            this.Close();
            tx.Show();
        }

        private void ViewResults(object sender, RoutedEventArgs e)
        {
            StudentResults vs = new StudentResults(_stdId);
            this.Close();
            vs.Show();
        }

        private void ViewExam(object sender, RoutedEventArgs e)
        {
            StudentExam sx = new StudentExam(_stdId);
            this.Close();
            sx.Show();
        }

        private void ViewTopics(object sender, RoutedEventArgs e)
        {
            CourseTopics ct = new CourseTopics(_stdId, 0);
            this.Close();
            ct.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ExaminationEntities1 ex = new ExaminationEntities1();
            var s1 = ex.GetStudents(_stdId).FirstOrDefault();
            this.name.Text = s1.std_FName + " " + s1.std_LName;
            this.id.Text = s1.std_Id.ToString();
            this.intake.Text = "Intake_41";
            this.branch.Text = "Smart Village";
            this.track.Text = "SD";
            this.studentName.Text += s1.std_FName + " " + s1.std_LName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StudentLogin sl = new StudentLogin();
            this.Close();
            sl.Show();
        }
    }
}