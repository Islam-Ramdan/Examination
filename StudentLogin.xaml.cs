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
    /// Interaction logic for StudentLogin.xaml
    /// </summary>
    public partial class StudentLogin : Window
    {
        public int StdId { get; set; }

        public StudentLogin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StudentInfo std = new StudentInfo(StdId);
            this.Close();
            std.Show();

        }

        private void InsIdCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StdId = Convert.ToInt32(StdEmailCbx.SelectedValue);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ExaminationEntities1 ex = new ExaminationEntities1();

            StdEmailCbx.ItemsSource = ex.selectStudents();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            frm_Login ba = new frm_Login();
            this.Close();
            ba.Show();
        }
    }
}
