using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class Question
    {
        public string quest;
        public List<string> answers;
        public int rightAnswerIndex;

        public Question(string quest, List<string> answers, int rightAnswerIndex)
        {
            this.quest = quest;
            this.answers = answers;
            this.rightAnswerIndex = rightAnswerIndex;
        }
    }
}
