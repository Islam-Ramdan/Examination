using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class cls_Question
    {
        public string Question { get; set; }
        public List<string> Choices { get; set; }
        public string StudentAnswer { get; set; }

        public cls_Question(string _Question, string _Choices)
        {
            Question = _Question;
            Choices = _Choices.Split(new[] { "<>" }, StringSplitOptions.None).ToList();
            StudentAnswer = "-";
        }
    }
}
