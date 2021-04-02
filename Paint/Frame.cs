using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Paint
{
    class Frame:PictureBox
    {

        public bool isDragging = false;
        public Label Border = new Label();
        public Label FrameLabel = new Label();

        public Frame(Control Parent, int Loc, string index, float FrameDuration, Bitmap bm):base()
        {
            this.Parent = Parent;
            Border.Parent = Parent;
            FrameLabel.Parent = Parent;

            this.Width = 100;
            this.Height = 50;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Tag = index;
            this.Name = "pb" + index;
            this.Image = (Bitmap)bm.Clone();
            this.Cursor = Cursors.Hand;
            this.Location = new Point(10, Loc);

            Border.BackColor = Color.Black;
            Border.Width = 104;
            Border.Height = 54;
            Border.Location = new Point(8, Loc - 2);
            Border.BackColor = Color.Black;
            Border.Name = "pbb" + index;

            FrameLabel.Location = new Point(10, Loc + 60);
            FrameLabel.Text = FrameDuration.ToString() + " секунд";
            FrameLabel.Name = "Lpb" + index;

            this.BringToFront();
        }

        public void ChangeTag(int z)
        {
            int NewTag = int.Parse(this.Tag.ToString()) + z;
            this.Tag = NewTag;
            this.Name = "pb" + NewTag;
            Border.Name = "pbb" + NewTag;
            FrameLabel.Name = "Lpb" + NewTag;
        }

        public void ChangeLocation(int z)
        {
            this.Location = new Point(this.Location.X, this.Location.Y + z);
            Border.Location = new Point(Border.Location.X, Border.Location.Y + z);
            FrameLabel.Location = new Point(FrameLabel.Location.X, FrameLabel.Location.Y + z);
        }

        new public void Dispose()
        {
            Border.Dispose();
            FrameLabel.Dispose();
            base.Dispose();
        }
    }
}
