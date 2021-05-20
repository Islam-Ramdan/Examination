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
    /// Interaction logic for frm_Login.xaml
    /// </summary>
    public partial class frm_Login : Window
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Instructor_Click(object sender, RoutedEventArgs e)
        {
            InstructorLogin insWin = new InstructorLogin();
            this.Close();
            insWin.Show();

        }

        private void Student_Click(object sender, RoutedEventArgs e)
        {
            StudentLogin stdWin = new StudentLogin();
            this.Close();
            stdWin.Show();

        }
    }
}
