using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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

            configs = new Dictionary<Mode, FilterConfig>
            {
                {
                    Mode.Grayscale,
                    new FilterConfig
                    {
                        LabelText = "Grayscale",
                        Min = 0,
                        Max = 0,
                        DefaultValue = 0,
                        LargeChange = 0,
                        SmallChange = 0,
                        Visible = false,
                    }
                },

                {
                    Mode.Gamma,
                    new FilterConfig
                    {
                        LabelText = "Gamma",
                        Min = 0,
                        Max = 0,
                        DefaultValue = 0,
                        LargeChange = 0,
                        SmallChange = 0,
                        Visible = false,
                    }
                },

                {
                    Mode.Invert,
                    new FilterConfig
                    {
                        LabelText = "Invert",
                        Min = 0,
                        Max = 0,
                        DefaultValue = 0,
                        LargeChange = 0,
                        SmallChange = 0,
                        Visible = false,
                    }
                },

                {
                    Mode.Brightness,
                    new FilterConfig
                    {
                        LabelText = "Brightness",
                        Min = -255,
                        Max = 255,
                        DefaultValue = 0,
                        LargeChange = 10,
                        SmallChange = 1,
                        Visible = true,
                    }
                },

                {
                    Mode.Contrast,
                    new FilterConfig
                    {
                        LabelText = "Contrast",
                        Min = -100,
                        Max = 100,
                        DefaultValue = 0,
                        LargeChange = 10,
                        SmallChange = 1,
                        Visible = true,
                    }
                },

                {
                    Mode.Color,
                    new FilterConfig
                    {
                        LabelText = "Color",
                        Min = 0,
                        Max = 0,
                        DefaultValue = 0,
                        LargeChange = 0,
                        SmallChange = 0,
                        Visible = false,
                    }
                },

                {
                    Mode.Smooth,
                    new FilterConfig
                    {
                        LabelText = "Smoothness",
                        Min = 0,
                        Max = 20,
                        DefaultValue = 0,
                        LargeChange = 1,
                        SmallChange = 1,
                        Visible = true,
                    }
                },

                {
                    Mode.Gauss,
                    new FilterConfig
                    {
                        LabelText = "Gaussian Blur",
                        Min = 0,
                        Max = 5,
                        DefaultValue = 0,
                        LargeChange = 1,
                        SmallChange = 1,
                        Visible = true,
                    }
                },

                {
                    Mode.Sharpen,
                    new FilterConfig
                    {
                        LabelText = "Sharpen",
                        Min = 0,
                        Max = 3,
                        DefaultValue = 0,
                        LargeChange = 1,
                        SmallChange = 1,
                        Visible = true,
                    }
                },


                {
                    Mode.MeanRemoval,
                    new FilterConfig
                    {
                        LabelText = "Mean Removal",
                        Min = 0,
                        Max = 2,
                        DefaultValue = 0,
                        LargeChange = 1,
                        SmallChange = 1,
                        Visible = true,
                    }
                },

                {
                    Mode.Emboss,
                    new FilterConfig
                    {
                        LabelText = "Emboss Laplascian",
                        Min = 0,
                        Max = 0,
                        DefaultValue = 0,
                        LargeChange = 0,
                        SmallChange = 0,
                        Visible = false,
                    }
                },


                {
                    Mode.HorzVertz,
                    new FilterConfig
                    {
                        LabelText = "HorzVertz",
                        Min = 0,
                        Max = 0,
                        DefaultValue = 0,
                        LargeChange = 0,
                        SmallChange = 0,
                        Visible = false,
                    }
                },


                {
                    Mode.AllDirection,
                    new FilterConfig
                    {
                        LabelText = "All Direction",
                        Min = 0,
                        Max = 0,
                        DefaultValue = 0,
                        LargeChange = 0,
                        SmallChange = 0,
                        Visible = false,
                    }
                },


                {
                    Mode.Lossy,
                    new FilterConfig
                    {
                        LabelText = "Lossy",
                        Min = 0,
                        Max = 0,
                        DefaultValue = 0,
                        LargeChange = 0,
                        SmallChange = 0,
                        Visible = false,
                    }
                },

                {
                    Mode.HorizontalOnly,
                    new FilterConfig
                    {
                        LabelText = "Horizontal Only",
                        Min = 0,
                        Max = 0,
                        DefaultValue = 0,
                        LargeChange = 0,
                        SmallChange = 0,
                        Visible = false,
                    }
                },

                {
                    Mode.VerticalOnly,
                    new FilterConfig
                    {
                        LabelText = "Vertical Only",
                        Min = 0,
                        Max = 0,
                        DefaultValue = 0,
                        LargeChange = 0,
                        SmallChange = 0,
                        Visible = false,
                    }
                },

            };
        }

        // initialize currentMode to Grayscale
        private Mode currentMode = Mode.Grayscale;
        private Dictionary<Mode, FilterConfig> configs;

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
        
        // for image
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

        // for image
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

        // for image
        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        // for image
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            result.Save(saveFileDialog1.FileName);
        }

        // for image
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

        // for image
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

        // for image
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

        // for image
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
            StopProcessing();
            pictureBox2.Image = null;

            myDevice = DeviceManager.GetAllDevices();

            if (myDevice.Length == 0)
            {
                MessageBox.Show("No webcam found");
            }
        }

        private void oNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myDevice[0].ShowWindow(pictureBox1);
            StartTimer(resultBoxNormal);
        }

        private void oFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myDevice[0].Stop();
            StopProcessing();
            mainTimer.Stop();
            resultBoxNormal.Stop();
            pictureBox2.Image = null;
        }

        private void StartTimer(Timer timerToStart)
        {
            // clear bitmap reference
            if (b != null)
            {
                b.Dispose();
                b = null;
            }

            timerToStart.Start();
        }

        private void oNGrey_Click(object sender, EventArgs e)
        {
            SetMode(Mode.Grayscale);
        }

        private void oFFgrey_Click(object sender, EventArgs e)
        {
            StopProcessing();
        }

        private void gamma_on_Click(object sender, EventArgs e)
        {
            SetMode(Mode.Gamma);
        }

        private void gamma_off_Click(object sender, EventArgs e)
        {
            StopProcessing();
        }

        private void invert_on_Click(object sender, EventArgs e)
        {
            SetMode(Mode.Invert);
        }

        private void invert_off_Click(object sender, EventArgs e)
        {
            StopProcessing();
        }

        private void brightness_On_Click(object sender, EventArgs e)
        {
            SetMode(Mode.Brightness);
        }

        private void brightness_Off_Click(object sender, EventArgs e)
        {
            StopProcessing();
        }

        private void contrast_on_Click(object sender, EventArgs e)
        {
            SetMode(Mode.Contrast);
        }

        private void contrast_off_Click(object sender, EventArgs e)
        {
            StopProcessing();
        }

        private void color_on_Click(object sender, EventArgs e)
        {
            SetMode(Mode.Color);
        }

        private void color_off_Click(object sender, EventArgs e)
        {
            StopProcessing();
        }

        private void smooth_on_Click(object sender, EventArgs e)
        {
            SetMode(Mode.Smooth);
        }

        private void smooth_off_Click(object sender, EventArgs e)
        {
            StopProcessing();
        }

        private void gauss_on_Click(object sender, EventArgs e)
        {
            SetMode(Mode.Gauss);
        }

        private void gauss_off_Click(object sender, EventArgs e)
        {
            StopProcessing();
        }

        private void sharp_on_Click(object sender, EventArgs e)
        {
            SetMode(Mode.Sharpen);
        }

        private void sharp_off_Click(object sender, EventArgs e)
        {
            StopProcessing();
        }

        private void mean_on_Click(object sender, EventArgs e)
        {
            SetMode(Mode.MeanRemoval);
        }

        private void mean_off_Click(object sender, EventArgs e)
        {
            StopProcessing();
        }

        private void emboss_on_Click(object sender, EventArgs e)
        {
            SetMode(Mode.Emboss);
        }

        private void emboss_off_Click(object sender, EventArgs e)
        {
            StopProcessing();
        }

        private static bool EdgeDetectHorzVertz(Bitmap b)
        {
            ConvMatrix m = new ConvMatrix();

            m.SetAll(0);
            m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = -1;
            m.Pixel = 4;

            m.Factor = 1;
            m.Offset = 127;

            return BitmapFilter.Conv3x3(b, m);
        }

        private void horzVertz_on_Click(object sender, EventArgs e)
        {
            SetMode(Mode.HorzVertz);
        }

        private void horzVertz_off_Click(object sender, EventArgs e)
        {
            StopProcessing();
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

        private void allDir_on_Click(object sender, EventArgs e)
        {
            SetMode(Mode.AllDirection);
        }

        private void allDir_off_Click(object sender, EventArgs e)
        {
            StopProcessing();
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

        private void lossy_on_Click(object sender, EventArgs e)
        {
            SetMode(Mode.Lossy);
        }

        private void lossy_off_Click(object sender, EventArgs e)
        {
            StopProcessing();
        }

        private void horizontal_on_Click(object sender, EventArgs e)
        {
            SetMode(Mode.HorizontalOnly);
        }

        private void horizontal_off_Click(object sender, EventArgs e)
        {
            StopProcessing();
        }

        private void vertical_on_Click(object sender, EventArgs e)
        {
            SetMode(Mode.VerticalOnly);
        }

        private void vertical_off_Click(object sender, EventArgs e)
        {
            StopProcessing();
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            Bitmap b = GetImage();

            if (b == null)
                return;

            switch (currentMode)
            {
                case Mode.Grayscale:
                    BitmapFilter.GrayScale(b);
                    break;

                case Mode.Gamma:
                    BitmapFilter.Gamma(
                        b,
                        (double)gammaRedUpDown.Value,
                        (double)gammaGreenUpDown.Value,
                        (double)gammaBlueUpDown.Value);
                    break;

                case Mode.Invert:
                    BitmapFilter.Invert(b);
                    break;

                case Mode.Brightness:
                    BitmapFilter.Brightness(b, mainTrackBar.Value);
                    break;

                case Mode.Contrast:
                    BitmapFilter.Contrast(b, (sbyte)mainTrackBar.Value);
                    break;

                case Mode.Color:
                    BitmapFilter.Color(
                        b,
                        colorRedTrackBar.Value,
                        colorGreenTrackBar.Value,
                        colorBlueTrackBar.Value);
                    break;

                case Mode.Smooth:
                    //apply 10 passes for smoothness
                    for (int i = 0; i < mainTrackBar.Value; i++)
                    {
                        BitmapFilter.Smooth(b, 1);
                    }
                    break;

                case Mode.Gauss:
                    //apply 5 passes for gaussian blur
                    for (int i = 0; i < mainTrackBar.Value; i++)
                    {
                        BitmapFilter.GaussianBlur(b, 1);
                    }
                    break;

                case Mode.Sharpen:
                    //apply 3 passes for sharpen
                    for (int i = 0; i < mainTrackBar.Value; i++)
                    {
                        BitmapFilter.Sharpen(b, 11);
                    }
                    break;

                case Mode.MeanRemoval:
                    BitmapFilter.MeanRemoval(b, 9 + mainTrackBar.Value);
                    break;

                case Mode.Emboss:
                    BitmapFilter.EmbossLaplacian(b);
                    break;

                case Mode.HorzVertz:
                    EdgeDetectHorzVertz(b);
                    break;

                case Mode.AllDirection:
                    EdgeDetectAll(b);
                    break;

                case Mode.Lossy:
                    EdgeDetectLossy(b);
                    break;

                case Mode.HorizontalOnly:
                    BitmapFilter.EdgeDetectHorizontal(b);
                    break;

                case Mode.VerticalOnly:
                    BitmapFilter.EdgeDetectVertical(b);
                    break;
            }

            pictureBox2.Image = b;
        }

        private Bitmap GetImage()
        {
            myDevice[0].Sendmessage();

            IDataObject data = Clipboard.GetDataObject();

            if (data == null || !data.GetDataPresent("System.Drawing.Bitmap"))
                return null;

            Image bmap = data.GetData("System.Drawing.Bitmap") as Image;

            if (bmap == null)
                return null;

            return new Bitmap(bmap);
        }

        private void SetMode(Mode mode)
        {
            StopProcessing();
            resultBoxNormal.Stop();
            currentMode = mode;

            if (configs.ContainsKey(mode))
                ApplyConfig(configs[mode]);

            StartTimer(mainTimer);
        }

        private void StopProcessing()
        {
            mainTimer.Stop();

            mainLabel.Visible = false;
            mainTrackBar.Visible = false;
            minValueText.Visible = false;
            maxValueText.Visible = false;

            //for gamma and color components
            redLabel.Visible = false;
            greenLabel.Visible = false;
            blueLabel.Visible = false;

            gammaRedUpDown.Visible = false;
            gammaGreenUpDown.Visible = false;
            gammaBlueUpDown.Visible = false;
            gammaRedUpDown.Value = gammaRedUpDown.Minimum;
            gammaGreenUpDown.Value = gammaGreenUpDown.Minimum;
            gammaBlueUpDown.Value = gammaBlueUpDown.Minimum;

            colorRedValue.Visible = false;
            colorGreenValue.Visible = false;
            colorBlueValue.Visible = false;
            colorRedTrackBar.Visible = false;
            colorGreenTrackBar.Visible = false;
            colorBlueTrackBar.Visible = false;
            colorRedTrackBar.Value = 0;
            colorGreenTrackBar.Value = 0;
            colorBlueTrackBar.Value = 0;

            pictureBox2.Image = null;
            StartTimer(resultBoxNormal);
        }

        private void ApplyConfig(FilterConfig config)
        {
            mainLabel.Text = config.LabelText;

            mainTrackBar.Minimum = config.Min;
            mainTrackBar.Maximum = config.Max;
            mainTrackBar.Value = config.DefaultValue;
            mainTrackBar.LargeChange = config.LargeChange;
            mainTrackBar.SmallChange = config.SmallChange;

            minValueText.Visible = config.Visible;
            maxValueText.Visible = config.Visible;
            minValueText.Text = config.Min.ToString();
            maxValueText.Text = config.Max.ToString();
            maxValueText.Visible = config.Visible;

            mainLabel.Visible = true;
            if (config.LabelText == "Gamma" || config.LabelText == "Color")
            {
                redLabel.Visible = true;
                greenLabel.Visible = true;
                blueLabel.Visible = true;

                if (config.LabelText == "Gamma")
                {
                    gammaRedUpDown.Visible = true;
                    gammaGreenUpDown.Visible = true;
                    gammaBlueUpDown.Visible = true;
                }
                else
                {
                    colorRedTrackBar.Visible = true;
                    colorGreenTrackBar.Visible = true;
                    colorBlueTrackBar.Visible = true;
                    colorRedValue.Visible = true;
                    colorGreenValue.Visible = true;
                    colorBlueValue.Visible = true;
                }
            }
            mainTrackBar.Visible = config.Visible;
        }

        private void colorRedTrackBar_Scroll(object sender, EventArgs e)
        {
            colorRedValue.Text = colorRedTrackBar.Value.ToString();
        }

        private void colorGreenTrackBar_Scroll(object sender, EventArgs e)
        {
            colorGreenValue.Text = colorGreenTrackBar.Value.ToString();
        }

        private void colorBlueTrackBar_Scroll(object sender, EventArgs e)
        {
            colorBlueValue.Text = colorBlueTrackBar.Value.ToString();
        }

        private void resultBoxNormal_Tick(object sender, EventArgs e)
        {
            Bitmap b = GetImage();

            if (b == null)
                return;

            pictureBox2.Image = b;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            source = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = source;
        }
    }
}
