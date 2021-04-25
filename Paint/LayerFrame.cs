using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Paint
{
    class LayerFrame:PictureBox
    {

        public Label Border = new Label();
        public Label LayerTitle = new Label();
        static public int FrameWidth = 80;
        static public int FrameHeight = 40;

        public LayerFrame(Control Parent, int Loc, string index, string title, Bitmap bm) : base()
        {
            this.Parent = Parent;
            Border.Parent = Parent;
            LayerTitle.Parent = Parent;

            this.Width = FrameWidth;
            this.Height = FrameHeight;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Tag = index;
            this.Name = StringResources.LayerFrameNamePrefix + index;
            this.Image = (Bitmap)bm.Clone();
            this.Cursor = Cursors.Hand;
            this.Location = new Point(10, Loc);

            Border.Width = FrameWidth + 4;
            Border.Height = FrameHeight + 4;
            Border.Location = new Point(8, Loc - 2);
            Border.BackColor = Register.NormalFrameBackColor;
            Border.Name = StringResources.LayerBorderNamePrefix + index;
            Border.Tag = index;

            LayerTitle.Location = new Point(100, Loc + 10);
            LayerTitle.Font = new Font(FontFamily.GenericSansSerif, 10);
            LayerTitle.Text = title;
            LayerTitle.Name = StringResources.LayerLabelNamePrefix + index;
            LayerTitle.Tag = index;

            this.BringToFront();
        }

        public LayerFrame() : base()
        {

        }

        public void ChangeTag(int z)
        {
            int NewTag = int.Parse(this.Tag.ToString()) + z;
            this.Tag = NewTag;
            this.Name = StringResources.LayerFrameNamePrefix + NewTag;
            Border.Name = StringResources.LayerBorderNamePrefix + NewTag;
            Border.Tag = NewTag;
            LayerTitle.Name = StringResources.LayerLabelNamePrefix + NewTag;
            LayerTitle.Tag = NewTag;
        }

        public void ChangeLocationY(int z)
        {
            this.Location = new Point(this.Location.X, this.Location.Y + z);
            Border.Location = new Point(Border.Location.X, Border.Location.Y + z);
            LayerTitle.Location = new Point(LayerTitle.Location.X, LayerTitle.Location.Y + z);
        }

        new public void Dispose()
        {
            Border.Dispose();
            LayerTitle.Dispose();
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
