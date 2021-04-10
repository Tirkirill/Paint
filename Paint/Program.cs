using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Paint
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mf = new MainForm();
            if (mf.ShowDialog()== DialogResult.OK)
            {
                if (mf.Choice == Register.ProgramRegimes.FreePaint)
                {
                    CreateForm cr1 = new CreateForm();
                    if (cr1.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new SandBoxForm(cr1.CanvasColor, cr1.CanvasWidth, cr1.CanvasHeight));
                    }
                }

                if (mf.Choice == Register.ProgramRegimes.Tests)
                {
                    MainTestsForm mtf = new MainTestsForm();
                    if (mtf.ShowDialog() == DialogResult.OK)
                    {
                        
                    }
                }
            }
        }
    }
}
