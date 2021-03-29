
namespace EZView
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Cyotek.Windows.Forms.ImageBox();
            this.panel2 = new EZView.TransparentPanel(this.components);
            this.panel1 = new EZView.TransparentPanel(this.components);
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.AllowUnfocusedMouseWheel = true;
            this.imageBox1.BackColor = System.Drawing.Color.Black;
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.DropShadowSize = 0;
            this.imageBox1.GridColor = System.Drawing.Color.Black;
            this.imageBox1.GridColorAlternate = System.Drawing.Color.Black;
            this.imageBox1.GridDisplayMode = Cyotek.Windows.Forms.ImageBoxGridDisplayMode.None;
            this.imageBox1.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.imageBox1.Image = global::EZView.Properties.Resources._440900_screenshots_20190129095600_1;
            this.imageBox1.ImageBorderColor = System.Drawing.Color.Transparent;
            this.imageBox1.Location = new System.Drawing.Point(0, 0);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.PixelGridColor = System.Drawing.Color.Black;
            this.imageBox1.ShortcutsEnabled = false;
            this.imageBox1.Size = new System.Drawing.Size(800, 450);
            this.imageBox1.TabIndex = 1;
            this.imageBox1.TextDisplayMode = Cyotek.Windows.Forms.ImageBoxGridDisplayMode.None;
            this.imageBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.imageBox1_KeyDown);
            this.imageBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.panel2.Location = new System.Drawing.Point(719, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(63, 423);
            this.panel2.TabIndex = 3;
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 427);
            this.panel1.TabIndex = 2;
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private Cyotek.Windows.Forms.ImageBox imageBox1;
        private TransparentPanel panel1;
        private TransparentPanel panel2;
    }
}

