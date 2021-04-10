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
    public partial class MainTestsForm : Form
    {
        public MainTestsForm()
        {
            InitializeComponent();
        }

        private List<Test> Tests = new List<Test>() {
            new Test("Тест 1 по теме: Основы анимации", 
                new List<Question>() {
                    new Question(
                        "При создании композиций из нескольких изображений используются.... ",
                        new List<string>()
                        {
                            "Слои",
                            "Кисти",
                            "Рисунки",
                            "Кадры"
                        },
                        0
                    )
                }
           ),
            new Test("Тест 2 по теме: Основы анимации",
                new List<Question>() {
                    new Question(
                        "Анимация формы заключается в автоматической генерации промежуточных кадров путем изменения....",
                        new List<string>()
                        {
                            "Цвета фигур",
                            "Формы фигур",
                            "Свойств фигур"
                        },
                        1
                    )
                }
           )
        };

        public Test ChosenTest;

        public void OnClick(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            ChosenTest = Tests[int.Parse(bt.Tag.ToString())];
            for (int i = 0; i<ChosenTest.questions.Count; i++)
            {
                TestForm tf = new TestForm(ChosenTest.questions[i]);
                tf.ShowDialog();
            }
        }

        private void MainTestForm_Load(object sender, EventArgs e)
        {
            int LocY = 25;
            int max_width = -1;
            for (int i =0; i<Tests.Count; i++)
            {
                Test test = Tests[i];
                Button button = new Button();
                button.Size = new Size(10, 30);
                button.Text = test.title;
                button.AutoSize = true;
                button.Location = new Point(5, LocY);
                button.Name = "N" + i;
                button.Parent = this;
                button.Click += OnClick;
                button.Tag = i;
                LocY += 35;
            }

            for (int i = 0; i < Tests.Count; i++)
            {
                int width = Controls.Find("N" + i, false)[0].Width;
                if (max_width < width)
                {
                    max_width = width;
                }
            }

            for (int i = 0; i < Tests.Count; i++)
            {
                Controls.Find("N" + i, false)[0].Width = max_width;
            }
        }
    }
}
