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

        public Label Border = new Label();
        public Label FrameLabel = new Label();
        static public int FrameWidth = 100;
        static public int FrameHeight = 50;

        public Frame(Control Parent, int Loc, string index, double FrameDuration, Bitmap bm):base()
        {
            this.Parent = Parent;
            Border.Parent = Parent;
            FrameLabel.Parent = Parent;

            this.Width = FrameWidth;
            this.Height = FrameHeight;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Tag = index;
            this.Name = StringResources.FrameNamePrefix + index;
            this.Image = (Bitmap)bm.Clone();
            this.Cursor = Cursors.Hand;
            this.Location = new Point(10, Loc);

            Border.Width = 104;
            Border.Height = 54;
            Border.Location = new Point(8, Loc - 2);
            Border.BackColor = Register.NormalFrameBackColor;
            Border.Name = StringResources.BorderNamePrefix + index;
            Border.Tag = index;

            FrameLabel.Location = new Point(10, Loc + 60);
            FrameLabel.Text = FrameDuration.ToString() + " секунд";
            FrameLabel.Name = StringResources.LabelNamePrefix + index;
            FrameLabel.Tag = index;

            this.BringToFront();
        }

        public Frame():base()
        {

        }

        public void ChangeTag(int z)
        {
            int NewTag = int.Parse(this.Tag.ToString()) + z;
            this.Tag = NewTag;
            this.Name = StringResources.FrameNamePrefix + NewTag;
            Border.Name = StringResources.BorderNamePrefix + NewTag;
            Border.Tag = NewTag;
            FrameLabel.Name = StringResources.LabelNamePrefix + NewTag;
            FrameLabel.Tag = NewTag;
        }

        public void ChangeLocationY(int z)
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

        public Frame Clone()
        {
            return new Frame()
            {
                Location = this.Location,
                Parent = this.Parent,
                Image = (Bitmap)this.Image.Clone(),
                SizeMode = this.SizeMode,
                Width = this.Width,
                Height = this.Height
            };
        }

    }
}
