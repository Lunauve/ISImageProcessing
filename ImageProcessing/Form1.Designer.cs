namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bASICToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brigthnesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorhorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscale_on = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscale_off = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossLaplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectQuickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.greyscale = new System.Windows.Forms.Timer(this.components);
            this.gamma_on = new System.Windows.Forms.ToolStripMenuItem();
            this.gamma_off = new System.Windows.Forms.ToolStripMenuItem();
            this.invert_on = new System.Windows.Forms.ToolStripMenuItem();
            this.invert_off = new System.Windows.Forms.ToolStripMenuItem();
            this.gamma = new System.Windows.Forms.Timer(this.components);
            this.invert = new System.Windows.Forms.Timer(this.components);
            this.brightness = new System.Windows.Forms.Timer(this.components);
            this.contrast = new System.Windows.Forms.Timer(this.components);
            this.smooth = new System.Windows.Forms.Timer(this.components);
            this.gaussian = new System.Windows.Forms.Timer(this.components);
            this.sharpen = new System.Windows.Forms.Timer(this.components);
            this.redUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gammaLabel = new System.Windows.Forms.Label();
            this.greenUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.blueUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.oNToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oFFToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.bASICToolStripMenuItem,
            this.asdfToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem1,
            this.saveImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadImageToolStripMenuItem1
            // 
            this.loadImageToolStripMenuItem1.Name = "loadImageToolStripMenuItem1";
            this.loadImageToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.loadImageToolStripMenuItem1.Text = "&Load Image";
            this.loadImageToolStripMenuItem1.Click += new System.EventHandler(this.loadImageToolStripMenuItem1_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveImageToolStripMenuItem.Text = "&Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // bASICToolStripMenuItem
            // 
            this.bASICToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greyScaleToolStripMenuItem,
            this.pixelCopyToolStripMenuItem,
            this.inversionToolStripMenuItem,
            this.brigthnesToolStripMenuItem,
            this.mirrorhorToolStripMenuItem,
            this.mirrorverToolStripMenuItem});
            this.bASICToolStripMenuItem.Name = "bASICToolStripMenuItem";
            this.bASICToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.bASICToolStripMenuItem.Text = "&BASIC";
            // 
            // greyScaleToolStripMenuItem
            // 
            this.greyScaleToolStripMenuItem.Name = "greyScaleToolStripMenuItem";
            this.greyScaleToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.greyScaleToolStripMenuItem.Text = "&GreyScale";
            this.greyScaleToolStripMenuItem.Click += new System.EventHandler(this.greyScaleToolStripMenuItem_Click);
            // 
            // pixelCopyToolStripMenuItem
            // 
            this.pixelCopyToolStripMenuItem.Name = "pixelCopyToolStripMenuItem";
            this.pixelCopyToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.pixelCopyToolStripMenuItem.Text = "&Pixel Copy";
            this.pixelCopyToolStripMenuItem.Click += new System.EventHandler(this.pixelCopyToolStripMenuItem_Click);
            // 
            // inversionToolStripMenuItem
            // 
            this.inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            this.inversionToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.inversionToolStripMenuItem.Text = "&Inversion";
            this.inversionToolStripMenuItem.Click += new System.EventHandler(this.inversionToolStripMenuItem_Click);
            // 
            // brigthnesToolStripMenuItem
            // 
            this.brigthnesToolStripMenuItem.Name = "brigthnesToolStripMenuItem";
            this.brigthnesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.brigthnesToolStripMenuItem.Text = "&Brigthnes";
            this.brigthnesToolStripMenuItem.Click += new System.EventHandler(this.brigthnesToolStripMenuItem_Click);
            // 
            // mirrorhorToolStripMenuItem
            // 
            this.mirrorhorToolStripMenuItem.Name = "mirrorhorToolStripMenuItem";
            this.mirrorhorToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.mirrorhorToolStripMenuItem.Text = "Mirror &hor";
            this.mirrorhorToolStripMenuItem.Click += new System.EventHandler(this.mirrorhorToolStripMenuItem_Click);
            // 
            // mirrorverToolStripMenuItem
            // 
            this.mirrorverToolStripMenuItem.Name = "mirrorverToolStripMenuItem";
            this.mirrorverToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.mirrorverToolStripMenuItem.Text = "Mirror &ver";
            this.mirrorverToolStripMenuItem.Click += new System.EventHandler(this.mirrorverToolStripMenuItem_Click);
            // 
            // asdfToolStripMenuItem
            // 
            this.asdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oNToolStripMenuItem,
            this.oFFToolStripMenuItem,
            this.greyToolStripMenuItem,
            this.gammaToolStripMenuItem,
            this.invertToolStripMenuItem,
            this.brightnessToolStripMenuItem,
            this.contrastToolStripMenuItem,
            this.smoothToolStripMenuItem,
            this.gaussianBlurToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.embossLaplacianToolStripMenuItem,
            this.edgeDetectQuickToolStripMenuItem});
            this.asdfToolStripMenuItem.Name = "asdfToolStripMenuItem";
            this.asdfToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.asdfToolStripMenuItem.Text = "Camera";
            // 
            // oNToolStripMenuItem
            // 
            this.oNToolStripMenuItem.Name = "oNToolStripMenuItem";
            this.oNToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oNToolStripMenuItem.Text = "ON";
            this.oNToolStripMenuItem.Click += new System.EventHandler(this.oNToolStripMenuItem_Click);
            // 
            // oFFToolStripMenuItem
            // 
            this.oFFToolStripMenuItem.Name = "oFFToolStripMenuItem";
            this.oFFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oFFToolStripMenuItem.Text = "OFF";
            this.oFFToolStripMenuItem.Click += new System.EventHandler(this.oFFToolStripMenuItem_Click);
            // 
            // greyToolStripMenuItem
            // 
            this.greyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscale_on,
            this.grayscale_off});
            this.greyToolStripMenuItem.Name = "greyToolStripMenuItem";
            this.greyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greyToolStripMenuItem.Text = "Greyscale";
            // 
            // grayscale_on
            // 
            this.grayscale_on.Name = "grayscale_on";
            this.grayscale_on.Size = new System.Drawing.Size(180, 22);
            this.grayscale_on.Text = "ON";
            this.grayscale_on.Click += new System.EventHandler(this.oNGrey_Click);
            // 
            // grayscale_off
            // 
            this.grayscale_off.Name = "grayscale_off";
            this.grayscale_off.Size = new System.Drawing.Size(180, 22);
            this.grayscale_off.Text = "OFF";
            this.grayscale_off.Click += new System.EventHandler(this.oFFggrey_Click);
            // 
            // gammaToolStripMenuItem
            // 
            this.gammaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamma_on,
            this.gamma_off});
            this.gammaToolStripMenuItem.Name = "gammaToolStripMenuItem";
            this.gammaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gammaToolStripMenuItem.Text = "Gamma";
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invert_on,
            this.invert_off});
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.invertToolStripMenuItem.Text = "Invert";
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oNToolStripMenuItem1,
            this.oFFToolStripMenuItem1});
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contrastToolStripMenuItem.Text = "Contrast";
            // 
            // smoothToolStripMenuItem
            // 
            this.smoothToolStripMenuItem.Name = "smoothToolStripMenuItem";
            this.smoothToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.smoothToolStripMenuItem.Text = "Smooth";
            // 
            // gaussianBlurToolStripMenuItem
            // 
            this.gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            this.gaussianBlurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            // 
            // embossLaplacianToolStripMenuItem
            // 
            this.embossLaplacianToolStripMenuItem.Name = "embossLaplacianToolStripMenuItem";
            this.embossLaplacianToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.embossLaplacianToolStripMenuItem.Text = "Emboss Laplacian";
            // 
            // edgeDetectQuickToolStripMenuItem
            // 
            this.edgeDetectQuickToolStripMenuItem.Name = "edgeDetectQuickToolStripMenuItem";
            this.edgeDetectQuickToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.edgeDetectQuickToolStripMenuItem.Text = "EdgeDetectQuick";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(370, 46);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 324);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(34, 383);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = -50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(400, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // greyscale
            // 
            this.greyscale.Tick += new System.EventHandler(this.grayscale_Tick);
            // 
            // gamma_on
            // 
            this.gamma_on.Name = "gamma_on";
            this.gamma_on.Size = new System.Drawing.Size(180, 22);
            this.gamma_on.Text = "ON";
            this.gamma_on.Click += new System.EventHandler(this.gamma_on_Click);
            // 
            // gamma_off
            // 
            this.gamma_off.Name = "gamma_off";
            this.gamma_off.Size = new System.Drawing.Size(180, 22);
            this.gamma_off.Text = "OFF";
            this.gamma_off.Click += new System.EventHandler(this.gamma_off_Click);
            // 
            // invert_on
            // 
            this.invert_on.Name = "invert_on";
            this.invert_on.Size = new System.Drawing.Size(180, 22);
            this.invert_on.Text = "ON";
            this.invert_on.Click += new System.EventHandler(this.invert_on_Click);
            // 
            // invert_off
            // 
            this.invert_off.Name = "invert_off";
            this.invert_off.Size = new System.Drawing.Size(180, 22);
            this.invert_off.Text = "OFF";
            this.invert_off.Click += new System.EventHandler(this.invert_off_Click);
            // 
            // gamma
            // 
            this.gamma.Tick += new System.EventHandler(this.gamma_Tick);
            // 
            // invert
            // 
            this.invert.Tick += new System.EventHandler(this.invert_Tick);
            // 
            // brightness
            // 
            this.brightness.Tick += new System.EventHandler(this.brightness_Tick);
            // 
            // redUpDown1
            // 
            this.redUpDown1.DecimalPlaces = 1;
            this.redUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.redUpDown1.Location = new System.Drawing.Point(622, 408);
            this.redUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.redUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.redUpDown1.Name = "redUpDown1";
            this.redUpDown1.Size = new System.Drawing.Size(52, 20);
            this.redUpDown1.TabIndex = 4;
            this.redUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // gammaLabel
            // 
            this.gammaLabel.AutoSize = true;
            this.gammaLabel.Location = new System.Drawing.Point(619, 383);
            this.gammaLabel.Name = "gammaLabel";
            this.gammaLabel.Size = new System.Drawing.Size(43, 13);
            this.gammaLabel.TabIndex = 5;
            this.gammaLabel.Text = "Gamma";
            // 
            // greenUpDown1
            // 
            this.greenUpDown1.DecimalPlaces = 1;
            this.greenUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.greenUpDown1.Location = new System.Drawing.Point(622, 434);
            this.greenUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.greenUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.greenUpDown1.Name = "greenUpDown1";
            this.greenUpDown1.Size = new System.Drawing.Size(52, 20);
            this.greenUpDown1.TabIndex = 6;
            this.greenUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // blueUpDown1
            // 
            this.blueUpDown1.DecimalPlaces = 1;
            this.blueUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.blueUpDown1.Location = new System.Drawing.Point(622, 460);
            this.blueUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.blueUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.blueUpDown1.Name = "blueUpDown1";
            this.blueUpDown1.Size = new System.Drawing.Size(52, 20);
            this.blueUpDown1.TabIndex = 7;
            this.blueUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(573, 410);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(27, 13);
            this.redLabel.TabIndex = 8;
            this.redLabel.Text = "Red";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(573, 436);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(36, 13);
            this.greenLabel.TabIndex = 9;
            this.greenLabel.Text = "Green";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(573, 462);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(28, 13);
            this.blueLabel.TabIndex = 10;
            this.blueLabel.Text = "Blue";
            // 
            // oNToolStripMenuItem1
            // 
            this.oNToolStripMenuItem1.Name = "oNToolStripMenuItem1";
            this.oNToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.oNToolStripMenuItem1.Text = "ON";
            this.oNToolStripMenuItem1.Click += new System.EventHandler(this.oNToolStripMenuItem1_Click);
            // 
            // oFFToolStripMenuItem1
            // 
            this.oFFToolStripMenuItem1.Name = "oFFToolStripMenuItem1";
            this.oFFToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.oFFToolStripMenuItem1.Text = "OFF";
            this.oFFToolStripMenuItem1.Click += new System.EventHandler(this.oFFToolStripMenuItem1_Click);
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.Location = new System.Drawing.Point(34, 436);
            this.brightnessTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.brightnessTrackBar.Maximum = 255;
            this.brightnessTrackBar.Minimum = -255;
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Size = new System.Drawing.Size(400, 45);
            this.brightnessTrackBar.TabIndex = 11;
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(40, 421);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(56, 13);
            this.brightnessLabel.TabIndex = 12;
            this.brightnessLabel.Text = "Brightness";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 486);
            this.Controls.Add(this.brightnessLabel);
            this.Controls.Add(this.brightnessTrackBar);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.blueUpDown1);
            this.Controls.Add(this.greenUpDown1);
            this.Controls.Add(this.gammaLabel);
            this.Controls.Add(this.redUpDown1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Image Processing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bASICToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem greyScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixelCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brigthnesToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem mirrorhorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirrorverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oFFToolStripMenuItem;
        private System.Windows.Forms.Timer greyscale;
        private System.Windows.Forms.ToolStripMenuItem greyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscale_on;
        private System.Windows.Forms.ToolStripMenuItem grayscale_off;
        private System.Windows.Forms.ToolStripMenuItem gammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smoothToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossLaplacianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectQuickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamma_on;
        private System.Windows.Forms.ToolStripMenuItem gamma_off;
        private System.Windows.Forms.ToolStripMenuItem invert_on;
        private System.Windows.Forms.ToolStripMenuItem invert_off;
        private System.Windows.Forms.Timer gamma;
        private System.Windows.Forms.Timer invert;
        private System.Windows.Forms.Timer brightness;
        private System.Windows.Forms.Timer contrast;
        private System.Windows.Forms.Timer smooth;
        private System.Windows.Forms.Timer gaussian;
        private System.Windows.Forms.Timer sharpen;
        private System.Windows.Forms.NumericUpDown redUpDown1;
        private System.Windows.Forms.Label gammaLabel;
        private System.Windows.Forms.NumericUpDown greenUpDown1;
        private System.Windows.Forms.NumericUpDown blueUpDown1;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.ToolStripMenuItem oNToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oFFToolStripMenuItem1;
        private System.Windows.Forms.TrackBar brightnessTrackBar;
        private System.Windows.Forms.Label brightnessLabel;
    }
}

