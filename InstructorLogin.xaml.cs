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
    /// Interaction logic for InstructorLogin.xaml
    /// </summary>
    public partial class InstructorLogin : Window
    {
        public string Fname { get; set; }
        public int Insid { get => insid; set => insid = value; }

        string _id;
        public InstructorLogin()
        {
            InitializeComponent();
        }
        int insid;
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (!int.TryParse(_id, out insid) || insid < 0)
            {
                MessageBox.Show("Invalid input for id field");
                idTxt.Clear();
            }
            else
            {
                ExaminationEntities1 ex = new ExaminationEntities1();
                int? check = ex.checkInstruct(insid, Fname.Trim()).First();

                if (check == 0)
                {
                    MessageBox.Show("Invalid login data");
                    fnameTxt.Clear();
                    idTxt.Clear();
                }

                else
                {
                    Instructor ins = new Instructor(Insid);
                    this.Close();
                    ins.Show();
                }

            }
        }

        private void idTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            _id = idTxt.Text;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Fname = fnameTxt.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            frm_Login ba = new frm_Login();
            this.Close();
            ba.Show();
        }
    }
}
