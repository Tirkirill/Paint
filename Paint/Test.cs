using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class Test
    {
        public List<Question> questions;
        public string title;

        public Test(string title, List<Question> questions)
        {
            this.questions = questions;
            this.title = title;
        }
    }
}
