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
            //for gamma components
            gammaLabel.Visible = false;
            redLabel.Visible = false;
            greenLabel.Visible = false;
            blueLabel.Visible = false;
            redUpDown1.Visible = false;
            greenUpDown1.Visible = false;
            blueUpDown1.Visible = false;

            myDevice = DeviceManager.GetAllDevices();

            if (myDevice.Length == 0)
            {
                MessageBox.Show("No webcam found");
            }
        }

        private void oNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myDevice[0].ShowWindow(pictureBox1);
        }

        private void oFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myDevice[0].Stop();
        }

        private void StartTimer(Timer timerToStart)
        {
            greyscale.Stop();
            gamma.Stop();
            invert.Stop();

            pictureBox2.Image = null;

            // clear bitmap reference
            if (b != null)
            {
                b.Dispose();
                b = null;
            }

            timerToStart.Start();
        }

        private void grayscale_Tick(object sender, EventArgs e)
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

        private void oNGrey_Click(object sender, EventArgs e)
        {
            StartTimer(greyscale);
        }

        private void oFFggrey_Click(object sender, EventArgs e)
        {
            greyscale.Stop();

            pictureBox2.Image = null;
        }

        private void gamma_on_Click(object sender, EventArgs e)
        {
            StartTimer(gamma);
            gammaLabel.Visible = true;
            redLabel.Visible = true;
            greenLabel.Visible = true;
            blueLabel.Visible = true;
            redUpDown1.Visible = true;
            greenUpDown1.Visible = true;
            blueUpDown1.Visible = true;
        }

        private void gamma_off_Click(object sender, EventArgs e)
        {
            gamma.Stop();

            gammaLabel.Visible = false;
            redLabel.Visible = false;
            greenLabel.Visible = false;
            blueLabel.Visible = false;
            redUpDown1.Visible = false;
            greenUpDown1.Visible = false;
            blueUpDown1.Visible = false;
            redUpDown1.Value = redUpDown1.Minimum;
            greenUpDown1.Value = greenUpDown1.Minimum;
            blueUpDown1.Value = blueUpDown1.Minimum;

            pictureBox2.Image = null;
        }

        private void gamma_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            myDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            b = new Bitmap(bmap);

            BitmapFilter.Gamma(
                b,
                (double)redUpDown1.Value,
                (double)greenUpDown1.Value,
                (double)blueUpDown1.Value);

            pictureBox2.Image = b;
        }

        private void invert_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            myDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            b = new Bitmap(bmap);

            BitmapFilter.Invert(b);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            source = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = source;
        }
    }
}
