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
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public Register.ProgramRegimes Choice;

        private void FreePaintButton_Click(object sender, EventArgs e)
        {
            Choice = Register.ProgramRegimes.NewProject;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Choice = Register.ProgramRegimes.OpenVideo;
        }
    }
}
