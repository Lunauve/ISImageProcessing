using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamLib;
using ImageProcess2;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap b;
        Device[] myDevice;
        Bitmap source, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void loadImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void pixelCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (source == null)
            {
                MessageBox.Show("Load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            result = new Bitmap(source.Width, source.Height);
            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color color = source.GetPixel(x, y);
                    result.SetPixel(x, y, color);
                }
            }

            pictureBox2.Image = result;
        }

        private void greyScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (source == null)
            {
                MessageBox.Show("Load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            result = new Bitmap(source.Width, source.Height);
            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixel = source.GetPixel(x, y);
                    int avg = (pixel.R + pixel.G + pixel.B) / 3;
                    byte grey = (byte)avg;

                    result.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }
            }

            pictureBox2.Image = result;
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (source == null)
            {
                MessageBox.Show("Load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            result = new Bitmap(source.Width, source.Height);
            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixel = source.GetPixel(x, y);
                    result.SetPixel(x, y, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));

                }
            }

            pictureBox2.Image = result;
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            result.Save(saveFileDialog1.FileName);
        }

        private void brigthnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int offset = -50;
            result = new Bitmap(source.Width, source.Height);
            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixel = source.GetPixel(x, y);
                    result.SetPixel(x, y, Color.FromArgb(Math.Min(pixel.R+offset, 255), Math.Min(pixel.G + offset, 255), Math.Min(pixel.B + offset, 255)));
                }
            }

            pictureBox2.Image = result;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int offset = trackBar1.Value;
            result = new Bitmap(source.Width, source.Height);
            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixel = source.GetPixel(x, y);
                    if(trackBar1.Value > 0){ 
                        result.SetPixel(x, y, Color.FromArgb(Math.Min(pixel.R + offset, 255), Math.Min(pixel.G + offset, 255), Math.Min(pixel.B + offset, 255)));
                    } else
                    {
                        result.SetPixel(x, y, Color.FromArgb(Math.Max(pixel.R + offset, 0), Math.Max(pixel.G + offset, 0), Math.Max(pixel.B + offset, 0)));
                    }
                }

            }

            pictureBox2.Image = result;
        }

        private void mirrorhorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result = new Bitmap(source.Width, source.Height);
            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixel = source.GetPixel(x, y);
                    result.SetPixel((source.Width-1)-x, y, pixel);
                }
            }

            pictureBox2.Image = result;
        }

        private void mirrorverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result = new Bitmap(source.Width, source.Height);
            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixel = source.GetPixel(x, y);
                    result.SetPixel(x, (source.Height - 1) - y, pixel);
                }
            }

            pictureBox2.Image = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myDevice = DeviceManager.GetAllDevices();
        }

        private void oNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myDevice[0].ShowWindow(pictureBox1);
        }

        private void oFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myDevice[0].Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            myDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            b = new Bitmap(bmap);


            BitmapFilter.GrayScale(b);

            pictureBox2.Image = b;
        }

        private void oNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void oFFToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            source = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = source;
        }
    }
}
