﻿namespace ImageFilters
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
            this.glowingEdgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cancelButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.matrixToolStripMenuItem});
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
            this.dotsточечныеToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
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
            this.matrixToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
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
            // glowingEdgesToolStripMenuItem
            // 
            this.glowingEdgesToolStripMenuItem.Name = "glowingEdgesToolStripMenuItem";
            this.glowingEdgesToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.glowingEdgesToolStripMenuItem.Text = "Glowing Edges";
            this.glowingEdgesToolStripMenuItem.Click += new System.EventHandler(this.glowingEdgesToolStripMenuItem_Click);
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
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(12, 599);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(37, 37);
            this.backButton.TabIndex = 5;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forwardButton.BackgroundImage")));
            this.forwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forwardButton.Location = new System.Drawing.Point(65, 599);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(37, 37);
            this.forwardButton.TabIndex = 6;
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 648);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.backButton);
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
        private System.Windows.Forms.ToolStripMenuItem maximumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glassToolStripMenuItem;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
    }
}
