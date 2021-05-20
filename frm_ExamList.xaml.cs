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
    /// Interaction logic for frm_ExamList.xaml
    /// </summary>
    public partial class frm_ExamList : Window
    {
        private int StudentID;

        private ExaminationEntities1 ex;

        List<GetUnsolvedExams_Result> ExamList;

        public frm_ExamList(int _stdID)
        {
            InitializeComponent();

            StudentID = _stdID;

            ex = new ExaminationEntities1();
            ExamList = ex.GetUnsolvedExams(StudentID).ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ex = new ExaminationEntities1();
            dg_UnsolvedExams.ItemsSource = ex.GetUnsolvedExamsNames(StudentID);

            var stdName = ex.selectStudents().Where(s => s.std_Id == StudentID).FirstOrDefault();
            string studName = $"{stdName.std_FName} {stdName.std_LName}";
            this.studentName.Text += studName;

            /*dg_UnsolvedExams.Columns[0].Width = 100;
            dg_UnsolvedExams.Columns[1].Width = 300;
            dg_UnsolvedExams.Columns[2].Width = 150;
            dg_UnsolvedExams.Columns[3].Width = 120;*/
        }

        private void btn_TakeExam_Click(object sender, RoutedEventArgs e)
        {
            int n = dg_UnsolvedExams.SelectedIndex;

            if (n != -1)
            {
                frm_Exam frm = new frm_Exam(ExamList[n].crs_id, ExamList[n].exam_id, StudentID);
                frm.Show();
                this.Close();
            }
        }

       
    }
}
