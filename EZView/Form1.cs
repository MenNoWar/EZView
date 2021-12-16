using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EZView
{
    public partial class Form1 : Form
    {
        public string CurPath = @"C:\Users\menno\OneDrive\Bilder\XGames\CE\Hangman";
        public List<FileInfo> Files;
        private string cf = @"C:\Users\menno\OneDrive\Bilder\XGames\CE\Hangman\Conan Exiles Screenshot 2020.07.01 - 12.54.46.37.png";
        public string CurFile
        {
            get
            {
                return this.cf;
            }
            set
            {
                this.cf = value;
            }
        }

        public int CurIndex = -1;
        public Form1()
        {
            InitializeComponent();
        }

        string[] exts = new string[] { ".bmp", ".jpg", ".png", ".jp2000", ".tif", ".tiff", ".jpe" };

        private  void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(25, Color.Black);
        }

        void loadFile(string fileName)
        {
            try
            {
                this.Text = $"{this.Files[this.CurIndex].Name} - {this.CurIndex + 1}/{this.Files.Count()}";

                Bitmap img;
                using (var strm = new FileStream(fileName, System.IO.FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    img = new Bitmap(strm);
                }

                imageBox1.Image = img;
                this.imageBox1.ZoomToFit(); 
                this.imageBox1.ZoomToFit();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error loading image", MessageBoxButtons.OK);
                this.Close();
            }
        }

        void Next(int offset)
        {
            if (this.CurIndex == -1) return;
            var tmp = this.CurIndex + offset;
            if (tmp < 0) tmp = 0;
            if (tmp >= this.Files.Count()) tmp = this.Files.Count() - 1;

            this.CurIndex = tmp;
            this.CurFile = this.Files[this.CurIndex].FullName;
            this.loadFile(CurFile);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) this.Next(1);
            else if (e.KeyCode == Keys.Back) this.Next(-1);
            else if (e.KeyCode == Keys.Space) this.Next(1);
            else if (e.KeyCode == Keys.Add) this.imageBox1.ZoomIn(true);
            else if (e.KeyCode == Keys.Subtract) this.imageBox1.ZoomOut(true);
            else if (e.KeyCode == Keys.Escape)
            {
                this.imageBox1.Dispose();
                this.Close();
            }
            else if (e.KeyCode == Keys.NumPad1) { this.imageBox1.ZoomToFit(); this.imageBox1.ZoomToFit(); }
            else if (e.KeyCode == Keys.F11)
            {
                this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
                this.FormBorderStyle = this.WindowState == FormWindowState.Maximized ? FormBorderStyle.None : FormBorderStyle.Sizable;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show(this, "Really Delete File?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var toDelete = this.Files[this.CurIndex].FullName;
                    this.Files.RemoveAt(this.CurIndex);
                    this.Next(0);

                    try
                    {
                        File.Delete(toDelete);
                    }
                    catch { }
                }
            }
        }

        private void imageBox1_KeyDown(object sender, KeyEventArgs e)
        {
            this.Form1_KeyDown(sender, e);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.imageBox1.ZoomToFit();
            this.imageBox1.ZoomToFit();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            var fi = string.IsNullOrEmpty(CurFile) ? null : new FileInfo(CurFile);
            if (fi != null)
            {
                this.CurPath = fi.DirectoryName;
            }

            this.Files = new List<FileInfo>();
            var aFiles = Directory.GetFiles(this.CurPath);


            foreach (var s in aFiles)
            {
                var fiItem = new FileInfo(s);
                var tmp = fiItem.Extension.ToLower();
                if (exts.Contains(tmp))
                {
                    this.Files.Add(fiItem);
                }
            }

            if (fi != null)
            {
                var tmp = this.Files.FirstOrDefault(o => o.Name == fi.Name);
                if (tmp != null) this.CurIndex = this.Files.IndexOf(tmp);
                this.loadFile(fi.FullName);
            }
        }

        private void imageBox1_MouseUp(object sender, MouseEventArgs e)
        {
            /*if (e.Button == MouseButtons.Right)
                this.Next(1);
            if (e.Button == MouseButtons.XButton1)
                this.Next(-1);
            if (e.Button == MouseButtons.XButton2)
                this.Next(1); */
        }

        private void imageBox1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            this.Next(1);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Next(-1);
        }
    }
}
