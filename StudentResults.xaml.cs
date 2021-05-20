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
    /// Interaction logic for StudentResults.xaml
    /// </summary>
    public partial class StudentResults : Window
    {
        int _stdId;
        
        ExaminationEntities1 ex;
        public StudentResults(int _id)
        {
            _stdId = _id;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          ex = new ExaminationEntities1();
            std_result.ItemsSource = ex.GetSudentGrades(_stdId);
            
            StudentGradeResults.ItemsSource = ex.GetSudentGrades(_stdId).Select(p => new { Subject = p.crs_Name, Grade = p.grade }).ToList();

            var stdObj = ex.selectStudents().Where(s => s.std_Id == _stdId).FirstOrDefault();
            this.studentName.Text += $"{stdObj.std_FName} {stdObj.std_LName}";
        }

        private void courseIDandResults(object sender, RoutedEventArgs e)
        {
            String courseName = std_result.Text;
            var item = ex.GetSudentGrades(_stdId).Where(c=>c.crs_Name == courseName).FirstOrDefault();
          if(courseName ==null)
                StudentGradeResults.ItemsSource = ex.GetSudentGrades(_stdId).Select(p => new { Subject = p.crs_Name, Grade = p.crs_Name }).ToList();
          else
               StudentGradeResults.ItemsSource = ex.GetSudentGrades(_stdId).Where(p=>p.crs_Name==courseName).Select(p => new { Subject = p.crs_Name, Grade = p.grade }).ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StudentInfo sf = new StudentInfo(_stdId);
            this.Close();
            sf.Show();
        }
    }
}
