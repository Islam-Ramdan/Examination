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
    /// Interaction logic for ViewCoursesWindow.xaml
    /// </summary>
    public partial class ViewCoursesWindow : Window
    {
        int instructor_id;
        public ViewCoursesWindow(int ins_id)
        {
            InitializeComponent();
            instructor_id = ins_id;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ExaminationEntities1 db = new ExaminationEntities1();
            Ins_Crs_Grid.ItemsSource = db.CoursesByInstructor(instructor_id);

            var insObj = db.selectFromInstructor(instructor_id).FirstOrDefault();
            this.instructorName.Text += $"{insObj.ins_FName} {insObj.ins_LName}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Instructor ins = new Instructor(instructor_id);
            this.Close();
            ins.Show();
        }
    }
}
