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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dotsточечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highBrigtnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highSharpnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
<<<<<<< HEAD
            this.glowingEdgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
=======
>>>>>>> master
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cancelButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
<<<<<<< HEAD
            this.backPicture = new System.Windows.Forms.PictureBox();
            this.frowardPicture = new System.Windows.Forms.PictureBox();
            this.morphologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
=======
            this.glowingEdgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
>>>>>>> master
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frowardPicture)).BeginInit();
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
            this.filtersToolStripMenuItem});
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dotsточечныеToolStripMenuItem,
            this.matrixToolStripMenuItem,
            this.morphologyToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // dotsточечныеToolStripMenuItem
            // 
            this.dotsточечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inversionToolStripMenuItem,
            this.grayScaleToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.highBrigtnessToolStripMenuItem,
            this.maximumToolStripMenuItem,
            this.glassToolStripMenuItem});
            this.dotsточечныеToolStripMenuItem.Name = "dotsточечныеToolStripMenuItem";
<<<<<<< HEAD
            this.dotsточечныеToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
=======
            this.dotsточечныеToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
>>>>>>> master
            this.dotsточечныеToolStripMenuItem.Text = "Dotty";
            // 
            // inversionToolStripMenuItem
            // 
            this.inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            this.inversionToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.inversionToolStripMenuItem.Text = "Inversion";
            this.inversionToolStripMenuItem.Click += new System.EventHandler(this.inversionToolStripMenuItem_Click);
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.grayScaleToolStripMenuItem.Text = "Gray Scale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click_1);
            // 
            // highBrigtnessToolStripMenuItem
            // 
            this.highBrigtnessToolStripMenuItem.Name = "highBrigtnessToolStripMenuItem";
            this.highBrigtnessToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.highBrigtnessToolStripMenuItem.Text = "High Brigtness";
            this.highBrigtnessToolStripMenuItem.Click += new System.EventHandler(this.highBrigtnessToolStripMenuItem_Click);
            // 
            // maximumToolStripMenuItem
            // 
            this.maximumToolStripMenuItem.Name = "maximumToolStripMenuItem";
            this.maximumToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.maximumToolStripMenuItem.Text = "Maximum";
            this.maximumToolStripMenuItem.Click += new System.EventHandler(this.maximumToolStripMenuItem_Click);
            // 
            // glassToolStripMenuItem
            // 
            this.glassToolStripMenuItem.Name = "glassToolStripMenuItem";
            this.glassToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.glassToolStripMenuItem.Text = "Glass";
            this.glassToolStripMenuItem.Click += new System.EventHandler(this.glassToolStripMenuItem_Click);
            // 
            // matrixToolStripMenuItem
            // 
            this.matrixToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.gaussianBlurToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.highSharpnessToolStripMenuItem,
            this.embossingToolStripMenuItem,
            this.medianToolStripMenuItem,
            this.glowingEdgesToolStripMenuItem});
            this.matrixToolStripMenuItem.Name = "matrixToolStripMenuItem";
<<<<<<< HEAD
            this.matrixToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
=======
            this.matrixToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
>>>>>>> master
            this.matrixToolStripMenuItem.Text = "Matrix";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // gaussianBlurToolStripMenuItem
            // 
            this.gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            this.gaussianBlurToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            this.gaussianBlurToolStripMenuItem.Click += new System.EventHandler(this.gaussianBlurToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.sobelToolStripMenuItem.Text = "Sobel ";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // highSharpnessToolStripMenuItem
            // 
            this.highSharpnessToolStripMenuItem.Name = "highSharpnessToolStripMenuItem";
            this.highSharpnessToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.highSharpnessToolStripMenuItem.Text = "High Sharpness";
            this.highSharpnessToolStripMenuItem.Click += new System.EventHandler(this.highSharpnessToolStripMenuItem_Click);
            // 
            // embossingToolStripMenuItem
            // 
            this.embossingToolStripMenuItem.Name = "embossingToolStripMenuItem";
            this.embossingToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.embossingToolStripMenuItem.Text = "Embossing";
            this.embossingToolStripMenuItem.Click += new System.EventHandler(this.embossingToolStripMenuItem_Click);
            // 
            // medianToolStripMenuItem
            // 
            this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
            this.medianToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.medianToolStripMenuItem.Text = "Median";
            this.medianToolStripMenuItem.Click += new System.EventHandler(this.medianToolStripMenuItem_Click);
            // 
<<<<<<< HEAD
            // glowingEdgesToolStripMenuItem
            // 
            this.glowingEdgesToolStripMenuItem.Name = "glowingEdgesToolStripMenuItem";
            this.glowingEdgesToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.glowingEdgesToolStripMenuItem.Text = "Glowing Edges";
            this.glowingEdgesToolStripMenuItem.Click += new System.EventHandler(this.glowingEdgesToolStripMenuItem_Click);
            // 
=======
>>>>>>> master
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
<<<<<<< HEAD
            // backPicture
            // 
            this.backPicture.Image = ((System.Drawing.Image)(resources.GetObject("backPicture.Image")));
            this.backPicture.Location = new System.Drawing.Point(12, 599);
            this.backPicture.Name = "backPicture";
            this.backPicture.Size = new System.Drawing.Size(37, 37);
            this.backPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backPicture.TabIndex = 7;
            this.backPicture.TabStop = false;
            this.backPicture.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frowardPicture
            // 
            this.frowardPicture.Image = ((System.Drawing.Image)(resources.GetObject("frowardPicture.Image")));
            this.frowardPicture.Location = new System.Drawing.Point(65, 599);
            this.frowardPicture.Name = "frowardPicture";
            this.frowardPicture.Size = new System.Drawing.Size(37, 37);
            this.frowardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frowardPicture.TabIndex = 8;
            this.frowardPicture.TabStop = false;
            this.frowardPicture.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // morphologyToolStripMenuItem
            // 
            this.morphologyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilationToolStripMenuItem,
            this.erosionToolStripMenuItem,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem});
            this.morphologyToolStripMenuItem.Name = "morphologyToolStripMenuItem";
            this.morphologyToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.morphologyToolStripMenuItem.Text = "Morphology";
            // 
            // dilationToolStripMenuItem
            // 
            this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            this.dilationToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.dilationToolStripMenuItem.Text = "Dilation";
            this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.erosionToolStripMenuItem.Text = "Erosion";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openingToolStripMenuItem.Text = "Opening";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.closingToolStripMenuItem.Text = "Closing";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
=======
            // glowingEdgesToolStripMenuItem
            // 
            this.glowingEdgesToolStripMenuItem.Name = "glowingEdgesToolStripMenuItem";
            this.glowingEdgesToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.glowingEdgesToolStripMenuItem.Text = "Glowing Edges";
            this.glowingEdgesToolStripMenuItem.Click += new System.EventHandler(this.glowingEdgesToolStripMenuItem_Click);
>>>>>>> master
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 648);
            this.Controls.Add(this.frowardPicture);
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
            this.Text = "ImageFilters";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frowardPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dotsточечныеToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem highSharpnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glowingEdgesToolStripMenuItem;
<<<<<<< HEAD
        private System.Windows.Forms.ToolStripMenuItem maximumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glassToolStripMenuItem;
        private System.Windows.Forms.PictureBox backPicture;
        private System.Windows.Forms.PictureBox frowardPicture;
        private System.Windows.Forms.ToolStripMenuItem morphologyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
=======
>>>>>>> master
    }
}

