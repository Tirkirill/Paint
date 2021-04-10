using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class TestForm : Form
    {

        Question question;
        private int Choice;
        public TestForm(Question question)
        {
            InitializeComponent();
            this.question = question;
            Label Title = new Label();
            Title.Location = new Point(25, 25);
            Title.Text = question.quest;
            Title.Font = new Font(FontFamily.GenericSansSerif, 12);
            Title.Parent = this;
            Title.AutoSize = true;

            GroupBox gB = new GroupBox();
            gB.Parent = this;
            gB.AutoSize = true;
            gB.Location = new Point(25, 50);
            int LocY = 10;
            for (int i = 0; i < question.answers.Count; i++)
            {
                LocY += 30;
                string answer = question.answers[i];
                RadioButton rb = new RadioButton();
                rb.Parent = gB;
                rb.Location = new Point(25, LocY);
                rb.Text = answer;
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
