using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using AForge;

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
            CreateForm cr1 = new CreateForm();
            if (cr1.ShowDialog() == DialogResult.OK)
            {
                AviWr
                Application.Run(new Form1(cr1.CanvasColor, cr1.CanvasWidth, cr1.CanvasHeight));
            }
            
        }
    }
}
