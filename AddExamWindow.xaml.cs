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
    /// Interaction logic for AddExamWindow.xaml
    /// </summary>
    public partial class AddExamWindow : Window
    {
        private int instructor_id;
        private ExaminationEntities1 db;

        public AddExamWindow(int ins_id)
        {
            InitializeComponent();
            instructor_id = ins_id;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new ExaminationEntities1();
            combox_crs.ItemsSource = db.CoursesByInstructor(instructor_id);
            var InsName = db.selectFromInstructor(instructor_id).FirstOrDefault();
            string FullName = $"{InsName.ins_FName} {InsName.ins_LName}";
            this.insName.Text += FullName;
        }



        private void btn_add_exam_Click(object sender, RoutedEventArgs e)
        {
            int mcq = Convert.ToInt32(txtbox_mcq.Text);
            int tf = Convert.ToInt32(txtbox_tf.Text);
            int duration = Convert.ToInt32(txtbox_duration.Text);
            string crsName = combox_crs.Text;
            var res = db.INSAddExam(instructor_id, crsName, mcq, tf, duration).FirstOrDefault();
            if (res == "1")
                MessageBox.Show("Exam was added successfully");
            else
                MessageBox.Show("Exam was not added successfully​​​​");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Instructor ins = new Instructor(instructor_id);
            this.Close();
            ins.Show();
        }
    }
}