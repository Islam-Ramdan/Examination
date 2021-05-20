using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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
    public partial class MainWindow : Window
    {
        private double ProgressRange;
        private double ProgressStart;
        private int ProcessCount;
        private int CurrentProcess;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            pb_Status.BorderThickness = new Thickness(0, 0, 0, 0);
            pb_Status.Value = pb_Status.Minimum;

            ProgressRange = pb_Status.Maximum - pb_Status.Minimum;
            ProgressStart = pb_Status.Minimum;

            worker_SetProcessCount(3);
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerAsync();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 0; i < ProcessCount; i++)
            {
                Thread.Sleep(1000);
                worker_ReportProgress(sender);
            }
            
            worker_KillWorker();
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pb_Status.Value = e.ProgressPercentage;
        }

        private void worker_SetProcessCount(int ProcessCount)
        {
            this.ProcessCount = ProcessCount;
        }

        private void worker_KillWorker()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                //replace this login page with the finished login page
                frm_Login frm = new frm_Login();
                frm.Show();
                
                this.Close();
            });
        }

        private void worker_ReportProgress(object sender)
        {
            if (CurrentProcess < ProcessCount)
                CurrentProcess++;

            worker_Progress(sender);
        }

        private void worker_UnreportProgress(object sender)
        {
            if (CurrentProcess > 0)
                CurrentProcess--;

            worker_Progress(sender);
        }

        private void worker_Progress(object sender)
        {
            BackgroundWorker worker = (sender as BackgroundWorker);

            double progressUnit = ProgressRange / ProcessCount;
            int progressValue = Convert.ToInt32((progressUnit * CurrentProcess) + ProgressStart);

            worker.ReportProgress(progressValue);
        }
    }
}
