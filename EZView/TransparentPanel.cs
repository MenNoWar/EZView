using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZView
{
    public partial class TransparentPanel : Panel
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }
       
        protected override void OnPaint(PaintEventArgs e)
        {
            // base.OnPaint(e);
            
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            try
            {
               /* var bmp = new Bitmap(this.Parent.Width, this.Parent.Height);
                this.Parent.DrawToBitmap(bmp, this.Parent.Bounds);

                e.Graphics.CopyFromScreen(0, 0, 0, 0, new Size(this.Width, this.Height), CopyPixelOperation.DestinationInvert);
                e.Graphics.CopyFromScreen(0, 0, 0, 0, new Size(this.Width, this.Height), CopyPixelOperation.DestinationInvert);
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(64, Color.White)), this.Bounds); */
            }
            catch { }
        }

        public TransparentPanel()
        {
            InitializeComponent();
        }

        public TransparentPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
