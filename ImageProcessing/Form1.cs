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
            gammaRedLabel.Visible = false;
            gammaGreenLabel.Visible = false;
            gammaBlueLabel.Visible = false;
            gammaRedUpDown.Visible = false;
            gammaGreenUpDown.Visible = false;
            gammaBlueUpDown.Visible = false;

            //for brightness components
            brightnessLabel.Visible = false;
            brightnessTrackBar.Visible = false;

            //for contrast components
            contrastLabel.Visible = false;
            contrastTrackBar.Visible = false;

            //for smoothness components
            smoothLabel.Visible = false;
            smoothTrackBar.Visible = false;

            //for gauss components
            gaussLabel.Visible = false;
            gaussTrackBar.Visible = false;

            //for sharpen components
            sharpLabel.Visible = false;
            sharpTrackBar.Visible = false;

            //for color components
            colorLabel.Visible = false;
            colorRedLabel.Visible = false;
            colorGreenLabel.Visible = false;
            colorBlueLabel.Visible = false;
            colorRedTrackBar.Visible = false;
            colorGreenTrackBar.Visible = false;
            colorBlueTrackBar.Visible = false;
            colorRedTrackBar.Value = 0;
            colorGreenTrackBar.Value = 0;
            colorBlueTrackBar.Value = 0;

            //for mean removal components
            meanLabel.Visible = false;
            meanTrackBar.Visible = false;

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
            brightness.Stop();
            color.Stop();
            contrast.Stop();
            smooth.Stop();
            gaussian.Stop();
            sharpen.Stop();
            mean.Stop();
            emboss.Stop();
            horzVert.Stop();
            allDirection.Stop();
            lossy.Stop();
            horizontalOnly.Stop();
            verticalOnly.Stop();

            //for gamma components
            gammaLabel.Visible = false;
            gammaRedLabel.Visible = false;
            gammaGreenLabel.Visible = false;
            gammaBlueLabel.Visible = false;
            gammaRedUpDown.Visible = false;
            gammaGreenUpDown.Visible = false;
            gammaBlueUpDown.Visible = false;
            gammaRedUpDown.Value = gammaRedUpDown.Minimum;
            gammaGreenUpDown.Value = gammaGreenUpDown.Minimum;
            gammaBlueUpDown.Value = gammaBlueUpDown.Minimum;

            //for brightness components
            brightnessLabel.Visible = false;
            brightnessTrackBar.Visible = false;

            //for contrast components
            contrastLabel.Visible = false;
            contrastTrackBar.Visible = false;

            //for smoothness components
            smoothLabel.Visible = false;
            smoothTrackBar.Visible = false;

            //for gauss components
            gaussLabel.Visible = false;
            gaussTrackBar.Visible = false;

            //for sharpen components
            sharpLabel.Visible = false;
            sharpTrackBar.Visible = false;

            //for color components
            colorLabel.Visible = false;
            colorRedLabel.Visible = false;
            colorGreenLabel.Visible = false;
            colorBlueLabel.Visible = false;
            colorRedTrackBar.Visible = false;
            colorGreenTrackBar.Visible = false;
            colorBlueTrackBar.Visible = false;
            colorRedTrackBar.Value = 0;
            colorGreenTrackBar.Value = 0;
            colorBlueTrackBar.Value = 0;

            //for mean removal components
            meanLabel.Visible = false;
            meanTrackBar.Visible = false;

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
            gammaRedLabel.Visible = true;
            gammaGreenLabel.Visible = true;
            gammaBlueLabel.Visible = true;
            gammaRedUpDown.Visible = true;
            gammaGreenUpDown.Visible = true;
            gammaBlueUpDown.Visible = true;
        }

        private void gamma_off_Click(object sender, EventArgs e)
        {
            gamma.Stop();

            gammaLabel.Visible = false;
            gammaRedLabel.Visible = false;
            gammaGreenLabel.Visible = false;
            gammaBlueLabel.Visible = false;
            gammaRedUpDown.Visible = false;
            gammaGreenUpDown.Visible = false;
            gammaBlueUpDown.Visible = false;
            gammaRedUpDown.Value = gammaRedUpDown.Minimum;
            gammaGreenUpDown.Value = gammaGreenUpDown.Minimum;
            gammaBlueUpDown.Value = gammaBlueUpDown.Minimum;

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
                (double)gammaRedUpDown.Value,
                (double)gammaGreenUpDown.Value,
                (double)gammaBlueUpDown.Value);

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

            pictureBox2.Image = b;
        }

        private void invert_on_Click(object sender, EventArgs e)
        {
            StartTimer(invert);
        }

        private void invert_off_Click(object sender, EventArgs e)
        {
            invert.Stop();

            pictureBox2.Image = null;
        }

        private void brightness_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            myDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            b = new Bitmap(bmap);

            BitmapFilter.Brightness(b, brightnessTrackBar.Value);

            pictureBox2.Image = b;
        }

        private void brightness_On_Click(object sender, EventArgs e)
        {
            StartTimer(brightness);
            brightnessLabel.Visible = true;
            brightnessTrackBar.Visible = true;
        }

        private void brightness_Off_Click(object sender, EventArgs e)
        {
            brightness.Stop();
            brightnessLabel.Visible = false;
            brightnessTrackBar.Visible = false;

            pictureBox2.Image = null;
        }

        private void contrast_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            myDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            b = new Bitmap(bmap);

            BitmapFilter.Contrast(b, (sbyte)contrastTrackBar.Value);

            pictureBox2.Image = b;
        }

        private void contrast_on_Click(object sender, EventArgs e)
        {
            StartTimer(contrast);
            contrastLabel.Visible = true;
            contrastTrackBar.Visible = true;
        }

        private void contrast_off_Click(object sender, EventArgs e)
        {
            contrast.Stop();
            contrastLabel.Visible = false;
            contrastTrackBar.Visible = false;

            pictureBox2.Image = null;
        }

        private void color_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            myDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            b = new Bitmap(bmap);

            BitmapFilter.Color(b,
                colorRedTrackBar.Value,
                colorGreenTrackBar.Value,
                colorBlueTrackBar.Value);

            pictureBox2.Image = b;
        }

        private void color_on_Click(object sender, EventArgs e)
        {
            StartTimer(color);
            colorLabel.Visible = true;
            colorRedLabel.Visible = true;
            colorGreenLabel.Visible = true;
            colorBlueLabel.Visible = true;
            colorRedTrackBar.Visible = true;
            colorGreenTrackBar.Visible = true;
            colorBlueTrackBar.Visible = true;
        }

        private void color_off_Click(object sender, EventArgs e)
        {
            color.Stop();

            colorLabel.Visible = false;
            colorRedLabel.Visible = false;
            colorGreenLabel.Visible = false;
            colorBlueLabel.Visible = false;
            colorRedTrackBar.Visible = false;
            colorGreenTrackBar.Visible = false;
            colorBlueTrackBar.Visible = false;
            colorRedTrackBar.Value = 0;
            colorGreenTrackBar.Value = 0;
            colorBlueTrackBar.Value = 0;

            pictureBox2.Image = null;
        }

        private void smooth_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            myDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            b = new Bitmap(bmap);

            //apply 10 passes for smoothness
            for (int i = 0; i < smoothTrackBar.Value; i++)
            {
                BitmapFilter.Smooth(b, 1);
            }

            pictureBox2.Image = b;
        }

        private void smooth_on_Click(object sender, EventArgs e)
        {
            StartTimer(smooth);
            smoothLabel.Visible = true;
            smoothTrackBar.Visible = true;
        }

        private void smooth_off_Click(object sender, EventArgs e)
        {
            smooth.Stop();
            smoothLabel.Visible = false;
            smoothTrackBar.Visible = false;

            pictureBox2.Image = null;
        }

        private void gaussian_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            myDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            b = new Bitmap(bmap);

            //apply 5 passes for gaussian blur
            for (int i = 0; i < gaussTrackBar.Value; i++)
            {
                BitmapFilter.GaussianBlur(b, 1);
            }

            pictureBox2.Image = b;
        }

        private void gauss_on_Click(object sender, EventArgs e)
        {
            StartTimer(gaussian);
            gaussLabel.Visible = true;
            gaussTrackBar.Visible = true;
        }

        private void gauss_off_Click(object sender, EventArgs e)
        {
            gaussian.Stop();
            gaussLabel.Visible = false;
            gaussTrackBar.Visible = false;

            pictureBox2.Image = null;
        }

        private void sharpen_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            myDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            b = new Bitmap(bmap);

            //apply 3 passes for sharpen
            for (int i = 0; i < sharpTrackBar.Value; i++)
            {
                BitmapFilter.Sharpen(b, 11);
            }

            pictureBox2.Image = b;
        }

        private void sharp_on_Click(object sender, EventArgs e)
        {
            StartTimer(sharpen);
            sharpLabel.Visible = true;
            sharpTrackBar.Visible = true;
        }

        private void sharp_off_Click(object sender, EventArgs e)
        {
            sharpen.Stop();
            sharpLabel.Visible = false;
            sharpTrackBar.Visible = false;

            pictureBox2.Image = null;
        }

        private void mean_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            myDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            b = new Bitmap(bmap);

            //trackbar to be min 0, max 2
            BitmapFilter.MeanRemoval(b, 9 + meanTrackBar.Value);

            pictureBox2.Image = b;
        }

        private void mean_on_Click(object sender, EventArgs e)
        {
            StartTimer(mean);
            meanLabel.Visible = true;
            meanTrackBar.Visible = true;
        }

        private void mean_off_Click(object sender, EventArgs e)
        {
            mean.Stop();
            meanLabel.Visible = false;
            meanTrackBar.Visible = false;

            pictureBox2.Image = null;
        }

        private void emboss_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            myDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            b = new Bitmap(bmap);

            BitmapFilter.EmbossLaplacian(b);

            pictureBox2.Image = b;
        }

        private void emboss_on_Click(object sender, EventArgs e)
        {
            StartTimer(emboss);
        }

        private void emboss_off_Click(object sender, EventArgs e)
        {
            emboss.Stop();

            pictureBox2.Image = null;
        }

        private static bool EdgeDetectHorzVert(Bitmap b)
        {
            ConvMatrix m = new ConvMatrix();

            m.SetAll(0);
            m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = -1;
            m.Pixel = 4;

            m.Factor = 1;
            m.Offset = 127;

            return BitmapFilter.Conv3x3(b, m);
        }

        private void horzVert_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;

            myDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            b = new Bitmap(bmap);

            EdgeDetectHorzVert(b);

            pictureBox2.Image = b;
        }

        private void oNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StartTimer(horzVert);
        }

        private void oFFToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            horzVert.Stop();

            pictureBox2.Image = null;
        }
        private static bool EdgeDetectAll(Bitmap b)
        {
            ConvMatrix m = new ConvMatrix();

            m.SetAll(-1);
            m.Pixel = 8;

            m.Factor = 1;
            m.Offset = 127;

            return BitmapFilter.Conv3x3(b, m);
        }

        private void allDirection_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;

            myDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            b = new Bitmap(bmap);

            EdgeDetectAll(b);

            pictureBox2.Image = b;
        }

        private void allDir_on_Click(object sender, EventArgs e)
        {
            StartTimer(allDirection);
        }

        private void allDir_off_Click(object sender, EventArgs e)
        {
            allDirection.Stop();

            pictureBox2.Image = null;
        }

        private static bool EdgeDetectLossy(Bitmap b)
        {
            ConvMatrix m = new ConvMatrix();

            m.TopLeft = 1; m.TopMid = -2; m.TopRight = 1;
            m.MidLeft = -2; m.Pixel = 4; m.MidRight = -2;
            m.BottomLeft = -2; m.BottomMid = 1; m.BottomRight = -2;

            m.Factor = 1;
            m.Offset = 127;

            return BitmapFilter.Conv3x3(b, m);
        }

        private void lossy_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;

            myDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            b = new Bitmap(bmap);

            EdgeDetectLossy(b);

            pictureBox2.Image = b;
        }

        private void lossy_on_Click(object sender, EventArgs e)
        {
            StartTimer(lossy);
        }

        private void lossy_off_Click(object sender, EventArgs e)
        {
            lossy.Stop();

            pictureBox2.Image = null;
        }

        private void horizontalOnly_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;

            myDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            b = new Bitmap(bmap);

            BitmapFilter.EdgeDetectHorizontal(b);

            pictureBox2.Image = b;
        }

        private void horizontal_on_Click(object sender, EventArgs e)
        {
            StartTimer(horizontalOnly);
        }

        private void horizontal_off_Click(object sender, EventArgs e)
        {
            horizontalOnly.Stop();

            pictureBox2.Image = null;
        }

        private void verticalOnly_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;

            myDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            b = new Bitmap(bmap);

            BitmapFilter.EdgeDetectVertical(b);

            pictureBox2.Image = b;
        }

        private void vertical_on_Click(object sender, EventArgs e)
        {
            StartTimer(verticalOnly);
        }

        private void vertical_off_Click(object sender, EventArgs e)
        {
            verticalOnly.Stop();

            pictureBox2.Image = null;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            source = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = source;
        }
    }
}
