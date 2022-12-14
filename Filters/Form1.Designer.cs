namespace ImageFilters
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highBrigtnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cancelButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backPicture = new System.Windows.Forms.PictureBox();
            this.forwardPicture = new System.Windows.Forms.PictureBox();
            this.morphologyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.moreFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setStructureElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.highSharpnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glowingEdgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalWavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearStretchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idealReflectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(960, 540);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.morphologyToolStripMenuItem1,
            this.moreFiltersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointToolStripMenuItem,
            this.matrixToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // pointToolStripMenuItem
            // 
            this.pointToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inversionToolStripMenuItem,
            this.grayScaleToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.highBrigtnessToolStripMenuItem,
            this.maximumToolStripMenuItem});
            this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
            this.pointToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pointToolStripMenuItem.Text = "Point";
            this.pointToolStripMenuItem.ToolTipText = "Change each pixel";
            // 
            // inversionToolStripMenuItem
            // 
            this.inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            this.inversionToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.inversionToolStripMenuItem.Text = "Inversion";
            this.inversionToolStripMenuItem.ToolTipText = "Invert colors";
            this.inversionToolStripMenuItem.Click += new System.EventHandler(this.inversionToolStripMenuItem_Click);
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.grayScaleToolStripMenuItem.Text = "Gray Scale";
            this.grayScaleToolStripMenuItem.ToolTipText = "Make image black and white";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.ToolTipText = "Set main color of image as lite brown";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click_1);
            // 
            // highBrigtnessToolStripMenuItem
            // 
            this.highBrigtnessToolStripMenuItem.Name = "highBrigtnessToolStripMenuItem";
            this.highBrigtnessToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.highBrigtnessToolStripMenuItem.Text = "High Brigtness";
            this.highBrigtnessToolStripMenuItem.ToolTipText = "Increase brightness";
            this.highBrigtnessToolStripMenuItem.Click += new System.EventHandler(this.highBrigtnessToolStripMenuItem_Click);
            // 
            // maximumToolStripMenuItem
            // 
            this.maximumToolStripMenuItem.Name = "maximumToolStripMenuItem";
            this.maximumToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.maximumToolStripMenuItem.Text = "Maximum";
            this.maximumToolStripMenuItem.ToolTipText = "Set maximum to each color chanel";
            this.maximumToolStripMenuItem.Click += new System.EventHandler(this.maximumToolStripMenuItem_Click);
            // 
            // matrixToolStripMenuItem
            // 
            this.matrixToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.gaussianBlurToolStripMenuItem,
            this.sobelToolStripMenuItem});
            this.matrixToolStripMenuItem.Name = "matrixToolStripMenuItem";
            this.matrixToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.matrixToolStripMenuItem.Text = "Matrix";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.ToolTipText = "Light blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // gaussianBlurToolStripMenuItem
            // 
            this.gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            this.gaussianBlurToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            this.gaussianBlurToolStripMenuItem.ToolTipText = "Gaussian blur";
            this.gaussianBlurToolStripMenuItem.Click += new System.EventHandler(this.gaussianBlurToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.sobelToolStripMenuItem.Text = "Sobel ";
            this.sobelToolStripMenuItem.ToolTipText = "Detect edges of image objects and make image black and white";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(126, 599);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(740, 37);
            this.progressBar1.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(885, 599);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 37);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.toolTip1.SetToolTip(this.cancelButton, "Stop image processing");
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backPicture
            // 
            this.backPicture.Image = ((System.Drawing.Image)(resources.GetObject("backPicture.Image")));
            this.backPicture.Location = new System.Drawing.Point(12, 599);
            this.backPicture.Name = "backPicture";
            this.backPicture.Size = new System.Drawing.Size(37, 37);
            this.backPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backPicture.TabIndex = 7;
            this.backPicture.TabStop = false;
            this.toolTip1.SetToolTip(this.backPicture, "Previous image");
            this.backPicture.Click += new System.EventHandler(this.backPicture_Click);
            // 
            // forwardPicture
            // 
            this.forwardPicture.Image = ((System.Drawing.Image)(resources.GetObject("forwardPicture.Image")));
            this.forwardPicture.Location = new System.Drawing.Point(65, 599);
            this.forwardPicture.Name = "forwardPicture";
            this.forwardPicture.Size = new System.Drawing.Size(37, 37);
            this.forwardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.forwardPicture.TabIndex = 8;
            this.forwardPicture.TabStop = false;
            this.toolTip1.SetToolTip(this.forwardPicture, "Next image");
            this.forwardPicture.Click += new System.EventHandler(this.forwardPicture_Click);
            // 
            // morphologyToolStripMenuItem1
            // 
            this.morphologyToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setStructureElementToolStripMenuItem,
            this.dilationToolStripMenuItem,
            this.erosionToolStripMenuItem,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.topToolStripMenuItem});
            this.morphologyToolStripMenuItem1.Name = "morphologyToolStripMenuItem1";
            this.morphologyToolStripMenuItem1.Size = new System.Drawing.Size(103, 24);
            this.morphologyToolStripMenuItem1.Text = "Morphology";
            this.morphologyToolStripMenuItem1.ToolTipText = "Decrease noise";
            // 
            // moreFiltersToolStripMenuItem
            // 
            this.moreFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dotToolStripMenuItem,
            this.matrixToolStripMenuItem1});
            this.moreFiltersToolStripMenuItem.Name = "moreFiltersToolStripMenuItem";
            this.moreFiltersToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.moreFiltersToolStripMenuItem.Text = "More filters";
            // 
            // setStructureElementToolStripMenuItem
            // 
            this.setStructureElementToolStripMenuItem.Name = "setStructureElementToolStripMenuItem";
            this.setStructureElementToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.setStructureElementToolStripMenuItem.Text = "Set structure element";
            this.setStructureElementToolStripMenuItem.ToolTipText = "MUST BE SET to use filters below";
            this.setStructureElementToolStripMenuItem.Click += new System.EventHandler(this.setStructureElementToolStripMenuItem_Click);
            // 
            // dilationToolStripMenuItem
            // 
            this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            this.dilationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dilationToolStripMenuItem.Text = "Dilation";
            this.dilationToolStripMenuItem.ToolTipText = "Reduce black noise with loss of object areas";
            this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.erosionToolStripMenuItem.Text = "Erosion";
            this.erosionToolStripMenuItem.ToolTipText = "Reduces white noise with loss of object areas";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openingToolStripMenuItem.Text = "Opening";
            this.openingToolStripMenuItem.ToolTipText = "Reduce white noise if objects without noise";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closingToolStripMenuItem.Text = "Closing";
            this.closingToolStripMenuItem.ToolTipText = "Reduce black noise if image background doesn\'t have noise";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.topToolStripMenuItem.Text = "Top Hat";
            this.topToolStripMenuItem.ToolTipText = "Closing and erosion";
            this.topToolStripMenuItem.Click += new System.EventHandler(this.topHatToolStripMenuItem_Click);
            // 
            // dotToolStripMenuItem
            // 
            this.dotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.glassToolStripMenuItem,
            this.horizontalWavesToolStripMenuItem,
            this.linearStretchingToolStripMenuItem,
            this.idealReflectorToolStripMenuItem});
            this.dotToolStripMenuItem.Name = "dotToolStripMenuItem";
            this.dotToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.dotToolStripMenuItem.Text = "Point";
            // 
            // matrixToolStripMenuItem1
            // 
            this.matrixToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highSharpnessToolStripMenuItem,
            this.embossingToolStripMenuItem,
            this.medianToolStripMenuItem,
            this.glowingEdgesToolStripMenuItem});
            this.matrixToolStripMenuItem1.Name = "matrixToolStripMenuItem1";
            this.matrixToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.matrixToolStripMenuItem1.Text = "Matrix";
            // 
            // highSharpnessToolStripMenuItem
            // 
            this.highSharpnessToolStripMenuItem.Name = "highSharpnessToolStripMenuItem";
            this.highSharpnessToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.highSharpnessToolStripMenuItem.Text = "High Sharpness";
            this.highSharpnessToolStripMenuItem.ToolTipText = "Increase sharpness";
            this.highSharpnessToolStripMenuItem.Click += new System.EventHandler(this.highSharpnessToolStripMenuItem_Click);
            // 
            // embossingToolStripMenuItem
            // 
            this.embossingToolStripMenuItem.Name = "embossingToolStripMenuItem";
            this.embossingToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.embossingToolStripMenuItem.Text = "Embossing";
            this.embossingToolStripMenuItem.ToolTipText = "Make image gray";
            this.embossingToolStripMenuItem.Click += new System.EventHandler(this.embossingToolStripMenuItem_Click);
            // 
            // medianToolStripMenuItem
            // 
            this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
            this.medianToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.medianToolStripMenuItem.Text = "Median";
            this.medianToolStripMenuItem.ToolTipText = "Reduce noise level(effective on \"pepper-salt\" noise)";
            this.medianToolStripMenuItem.Click += new System.EventHandler(this.medianToolStripMenuItem_Click);
            // 
            // glowingEdgesToolStripMenuItem
            // 
            this.glowingEdgesToolStripMenuItem.Name = "glowingEdgesToolStripMenuItem";
            this.glowingEdgesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.glowingEdgesToolStripMenuItem.Text = "Glowing Edges";
            this.glowingEdgesToolStripMenuItem.ToolTipText = "Make edges of image glows";
            this.glowingEdgesToolStripMenuItem.Click += new System.EventHandler(this.glowingEdgesToolStripMenuItem_Click);
            // 
            // glassToolStripMenuItem
            // 
            this.glassToolStripMenuItem.Name = "glassToolStripMenuItem";
            this.glassToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.glassToolStripMenuItem.Text = "Glass";
            this.glassToolStripMenuItem.ToolTipText = "Create \"glass\" between image and screen";
            this.glassToolStripMenuItem.Click += new System.EventHandler(this.glassToolStripMenuItem_Click);
            // 
            // horizontalWavesToolStripMenuItem
            // 
            this.horizontalWavesToolStripMenuItem.Name = "horizontalWavesToolStripMenuItem";
            this.horizontalWavesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.horizontalWavesToolStripMenuItem.Text = "Horizontal Waves";
            this.horizontalWavesToolStripMenuItem.ToolTipText = "Make image waivy";
            this.horizontalWavesToolStripMenuItem.Click += new System.EventHandler(this.horizontalWavesToolStripMenuItem_Click);
            // 
            // linearStretchingToolStripMenuItem
            // 
            this.linearStretchingToolStripMenuItem.Name = "linearStretchingToolStripMenuItem";
            this.linearStretchingToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.linearStretchingToolStripMenuItem.Text = "Linear Stretching";
            this.linearStretchingToolStripMenuItem.ToolTipText = "Stretch the range of colors";
            this.linearStretchingToolStripMenuItem.Click += new System.EventHandler(this.linearStretchingToolStripMenuItem_Click);
            // 
            // idealReflectorToolStripMenuItem
            // 
            this.idealReflectorToolStripMenuItem.Name = "idealReflectorToolStripMenuItem";
            this.idealReflectorToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.idealReflectorToolStripMenuItem.Text = "Ideal Reflector";
            this.idealReflectorToolStripMenuItem.ToolTipText = "Find blicks and dicrease them";
            this.idealReflectorToolStripMenuItem.Click += new System.EventHandler(this.idealReflectorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 648);
            this.Controls.Add(this.forwardPicture);
            this.Controls.Add(this.backPicture);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Filters v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button cancelButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highBrigtnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximumToolStripMenuItem;
        private System.Windows.Forms.PictureBox backPicture;
        private System.Windows.Forms.PictureBox forwardPicture;
        private System.Windows.Forms.ToolStripMenuItem morphologyToolStripMenuItem1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem moreFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setStructureElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrixToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem highSharpnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glowingEdgesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalWavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearStretchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idealReflectorToolStripMenuItem;
    }
}

