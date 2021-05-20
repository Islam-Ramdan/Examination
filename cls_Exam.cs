using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExaminationSystem.ListOperations;

namespace ExaminationSystem
{
    public class cls_Exam
    {
        public List<cls_Question> Questions { get; set; }
        public List<GetExam_Result> QuestionsBeforeShuffling { get; set; }

        public cls_Exam(int exmID)
        {
            ExaminationEntities1 ex = new ExaminationEntities1();
            List<GetExam_Result> exm = ex.GetExam(exmID).ToList();
            QuestionsBeforeShuffling = new List<GetExam_Result>();
            QuestionsBeforeShuffling.AddRange(exm);

            exm.Shuffle<GetExam_Result>();

            Questions = new List<cls_Question>();

            foreach (var item in exm)
            {
                Questions.Add(new cls_Question(item.qDescription, item.qChoice));
            }
        }
    }
}