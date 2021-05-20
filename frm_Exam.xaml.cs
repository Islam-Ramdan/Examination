using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows;

namespace ExaminationSystem
{
    /// <summary>
    /// Interaction logic for frm_Exam.xaml
    /// </summary>
    public partial class frm_Exam : Window
    {
        private int QNum;
        private int QCount;

        private System.Timers.Timer aTimer;

        private int Hours;
        private int Minutes;
        private int Seconds;

        private int ExamID;
        private int StudentID;
        private int CourseID;

        private cls_Exam CurrentExam;

        private ExaminationEntities1 ex;

        public frm_Exam(int _crsID, int _exmID, int _stdID)
        {
            InitializeComponent();

            Hours = 0;
            Minutes = 10;
            Seconds = 0;

            ExamID = _exmID;
            StudentID = _stdID;
            CourseID = _crsID;

            CurrentExam = new cls_Exam(_exmID);

            QNum = 1;
            QCount = CurrentExam.Questions.Count();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateWindow();
            SetClock();
            StartTimer();
        }

        private void btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            int AnsweredQuestions = CurrentExam.Questions.Count(a => a.StudentAnswer == "-");

            if (AnsweredQuestions == 0)
                SaveAnswers();
            else
                MessageBox.Show("Some questions are not answered.", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btn_Next_Click(object sender, RoutedEventArgs e)
        {
            if (QNum < QCount)
            {
                QNum++;
                UpdateWindow();
            }
        }

        private void btn_Previous_Click(object sender, RoutedEventArgs e)
        {
            if (QNum > 1)
            {
                QNum--;
                UpdateWindow();
            }
        }

        private void rd_Choice1_Checked(object sender, RoutedEventArgs e)
        {
            if (txb_Choice1.Text == "True")
                CurrentExam.Questions[QNum - 1].StudentAnswer = "T";
            else
                CurrentExam.Questions[QNum - 1].StudentAnswer = txb_Choice1.Text.Substring(0, 1);
        }

        private void rd_Choice2_Checked(object sender, RoutedEventArgs e)
        {
            if (txb_Choice2.Text == "False")
                CurrentExam.Questions[QNum - 1].StudentAnswer = "F";
            else
                CurrentExam.Questions[QNum - 1].StudentAnswer = txb_Choice2.Text.Substring(0, 1);
        }

        private void rd_Choice3_Checked(object sender, RoutedEventArgs e)
        {
            CurrentExam.Questions[QNum - 1].StudentAnswer = txb_Choice3.Text.Substring(0, 1);
        }

        private void rd_Choice4_Checked(object sender, RoutedEventArgs e)
        {
            CurrentExam.Questions[QNum - 1].StudentAnswer = txb_Choice4.Text.Substring(0, 1);
        }

        private void StartTimer()
        {
            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            UpdateClock();
        }

        private void StopTimer()
        {
            aTimer.Stop();
            aTimer.Dispose();
        }

        private void UpdateClock()
        {
            Seconds--;

            if (Seconds == -1)
            {
                Seconds = 59;
                Minutes--;
            }

            if (Minutes == -1)
            {
                Minutes = 59;
                Hours--;
            }

            if (Hours == -1)
            {
                StopTimer();
                TimeOut();
            }
            else
                SetClock();
        }

        public void SetClock()
        {
            string h = "";
            if (Hours < 10)
                h = "0";

            string m = "";
            if (Minutes < 10)
                m = "0";

            string s = "";
            if (Seconds < 10)
                s = "0";

            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                lbl_Timer.Content = "Time - " + h + Hours + ":" + m + Minutes + ":" + s + Seconds;
            });
        }

        private void UpdateWindow()
        {
            SetQNum();
            SetQuestion();
            SetChoices();
        }

        private void SetQNum()
        {
            lbl_QNum.Content = "Question (" + QNum + ") out of (" + QCount + ")";
        }

        private void SetQuestion()
        {
            txb_Question.Text = CurrentExam.Questions[QNum - 1].Question;
        }

        private void SetChoices()
        {
            int ChNum = CurrentExam.Questions[QNum - 1].Choices.Count;

            if (ChNum >= 1)
            {
                txb_Choice1.Text = CurrentExam.Questions[QNum - 1].Choices[0];
                rd_Choice1.Visibility = Visibility.Visible;
            }
            else
            {
                rd_Choice1.Visibility = Visibility.Hidden;
            }

            if (ChNum >= 2)
            {
                txb_Choice2.Text = CurrentExam.Questions[QNum - 1].Choices[1];
                rd_Choice2.Visibility = Visibility.Visible;
            }
            else
            {
                rd_Choice2.Visibility = Visibility.Hidden;
            }

            if (ChNum >= 3)
            {
                txb_Choice3.Text = CurrentExam.Questions[QNum - 1].Choices[2];
                rd_Choice3.Visibility = Visibility.Visible;
            }
            else
            {
                rd_Choice3.Visibility = Visibility.Hidden;
            }

            if (ChNum >= 4)
            {
                txb_Choice4.Text = CurrentExam.Questions[QNum - 1].Choices[3];
                rd_Choice4.Visibility = Visibility.Visible;
            }
            else
            {
                rd_Choice4.Visibility = Visibility.Hidden;
            }

            SelectChoice();
        }

        private void SelectChoice()
        {
            UncheckAllChoices();

            string StudentAnswer = CurrentExam.Questions[QNum - 1].StudentAnswer;

            if (StudentAnswer != "-")
            {
                if (StudentAnswer == "T" || StudentAnswer == "1")
                    rd_Choice1.IsChecked = true;
                else if (StudentAnswer == "F" || StudentAnswer == "2")
                    rd_Choice2.IsChecked = true;
                else if (StudentAnswer == "3")
                    rd_Choice3.IsChecked = true;
                else if (StudentAnswer == "4")
                    rd_Choice4.IsChecked = true;
            }
        }

        private void UncheckAllChoices()
        {
            rd_Choice1.IsChecked = false;
            rd_Choice2.IsChecked = false;
            rd_Choice3.IsChecked = false;
            rd_Choice4.IsChecked = false;
        }

        private void TimeOut()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                MessageBox.Show("TIME OUT", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);

                grd_Exam.IsEnabled = false;

                SaveAnswers();
            });
        }

        private void SaveAnswers()
        {
            List<string> stdAnswers = new List<string>();
            stdAnswers.AddRange(CurrentExam.Questions.Select(a => a.StudentAnswer));
            string StudentAnswers = ReorderStudentAnswers(stdAnswers);

            ex = new ExaminationEntities1();
            string ExamStatus = ex.ExamAnswers(StudentID, ExamID, StudentAnswers).First();

            if (ExamStatus == "ExamSaved")
            {
                string CorrectionStatus = ex.examCorrection(ExamID, StudentID, CourseID).First();

                if (CorrectionStatus == "Correction is done successfully")
                    MessageBox.Show(CorrectionStatus, "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                else
                    MessageBox.Show(CorrectionStatus, "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
                MessageBox.Show(ExamStatus, "Alert", MessageBoxButton.OK, MessageBoxImage.Error);

            this.Close();
        }

        private string ReorderStudentAnswers(List<string> stdAnswers)
        {
            StringBuilder newStdAnswers = new StringBuilder();

            foreach (var item in CurrentExam.QuestionsBeforeShuffling)
            {
                string x = stdAnswers[CurrentExam.Questions.FindIndex(a => a.Question == item.qDescription)];
                newStdAnswers.Append(x + ",");
            }
            return newStdAnswers.ToString().Substring(0, newStdAnswers.Length - 1);
        }
    }
}