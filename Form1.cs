/*Screen capture demo*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CaptureScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Red);
            foreach (var bmp in _bitmaps)
            {
                //e.Graphics.DrawImage(bmp, 0, 0);
            }
        }

        private readonly Stopwatch sw = new Stopwatch();
        private Bitmap CaptureImage(int x, int y)
        {
            //var b = new Bitmap(100+50, 430+100);
            var b = new Bitmap(int.Parse(tbWidth.Text), int.Parse(tbHeight.Text));
            using (var g = Graphics.FromImage(b))
            {
                g.CopyFromScreen(x, y, 0, 0, b.Size, CopyPixelOperation.SourceCopy);
            }
            return b;
        }
        
        private readonly List<Bitmap> _bitmaps = new List<Bitmap>();
        private void btCapture_Click(object sender, EventArgs e)
        {
            var nBmps = int.Parse(tbNbOfFrames.Text);
            _bitmaps.Clear();
            _bitmaps.Capacity = nBmps;
            btCapture.Enabled = false;
            lbInfo.Text = "Capture in progress...";
            lbInfo.Refresh();
            sw.Restart();
            for (var i = 0; i < nBmps ; i++) //46 captures ~ 1 second
            {
               // _bitmaps.Add(CaptureImage(120-50, 210));
                _bitmaps.Add(CaptureImage(int.Parse(tbX.Text), int.Parse(tbY.Text)));
            }
            for (var i = 0; i < nBmps ; i++)
            {
                _bitmaps[i].Save("test" + i + ".bmp");
                pictureBox1.Image = _bitmaps[i];
            }
            sw.Stop();
            lbInfo.Text = "Elapsed time for capturing" + nBmps + " frames: " + sw.ElapsedMilliseconds + " ms";
            btCapture.Enabled = true;
        }
    }
}

