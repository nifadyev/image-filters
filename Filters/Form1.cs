// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImageFilters
{
    public partial class Form1 : Form
    {
        List<Bitmap> images;
        //Bitmap image;
        int imageCounter;
        int maxSize = 0;
        bool[,] structureElement = null;

        public Form1()
        {
            InitializeComponent();
            images = new List<Bitmap>();
            //TODO: DONE Add implementation (hiding progress bar and cancel button AFTER filter was added)

            //progressBar1.Visible = false;
            //cancelButton.Visible = false;
            //cancelButton.Enabled = false;

            //TODO: DONE Add implementation (hiding buttons TILL some filter was added)
            //backButton.Visible = backButton.Enabled = false;
            //forwardButton.Visible = forwardButton.Enabled = false;

            imageCounter = -1;
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png; *.jpg; *.jpeg; *.bmp | All Files (*.*) | *.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(dialog.FileName);
               //pictureBox1.Image = image;
                //pictureBox1.Refresh();

                images.Clear();
                images.Add(image);
                pictureBox1.Image = images.Last();
                pictureBox1.Refresh();
                // button2.Visible = button3.Visible = false;
                imageCounter = 0;
            }
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilter filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).ProcessImage(images[imageCounter], backgroundWorker1);

            if (imageCounter != images.Count - 1)
            {
                images.RemoveRange(imageCounter + 1, images.Count - imageCounter - 1);
            }

            if (backgroundWorker1.CancellationPending != true)
            {
                images.Add(newImage);
                imageCounter++;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = images.Last();
                pictureBox1.Refresh();
               //progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = false;
            }
           // progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = false;

            progressBar1.Value = 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
            //progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = false;
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            GrayScaleFilter filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void sepiaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void highBrigtnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            HIghBrightnessFilter filter = new HIghBrightnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            SobolFilter filter = new SobolFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void highSharpnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            HighSharpnessFilter filter = new HighSharpnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void embossingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            MatrixFilter embossingFilter = new EmbossingFilter();
            backgroundWorker1.RunWorkerAsync(embossingFilter);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog.Title = "Save an Image File";
          
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            { 
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog.OpenFile();
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        images[imageCounter].Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        images[imageCounter].Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        images[imageCounter].Save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }

        private void medianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            MedianFilter filter = new MedianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void glowingEdgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            GlowingEdgesFilter filter = new GlowingEdgesFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void maximumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            MaximumFilter filter = new MaximumFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void glassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            GlassFilter filter = new GlassFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            Morphology filter = new Morphology(images[imageCounter], this.maxSize, 1);
            filter.SetStructureElement(structureElement);

            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            Morphology filter = new Morphology(images[imageCounter], this.maxSize, 2);
            filter.SetStructureElement(structureElement);

            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            Morphology filter = new Opening(images[imageCounter], this.maxSize, 1);
            filter.SetStructureElement(structureElement);

            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            Morphology filter = new Closing(images[imageCounter], this.maxSize, 2);
            filter.SetStructureElement(structureElement);

            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void forwardPicture_Click(object sender, EventArgs e)
        {
            if (imageCounter < images.Count - 1)
            {
                pictureBox1.Image = images[++imageCounter];
                pictureBox1.Refresh();
            }
        }

        private void backPicture_Click(object sender, EventArgs e)
        {
            if (imageCounter > 0)
            {
                pictureBox1.Image = images[--imageCounter];
                pictureBox1.Refresh();
            }
        }

        private void setStructureElementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form2 = new Form2(this);
                form2.Owner = this;
                form2.ShowDialog();

                this.maxSize = form2.maxSize;
                this.structureElement = form2.structureElement;
            }
            catch
            {
                MessageBox.Show("Set structure element", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void horizontalWavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            HorizontalWavesFilter filter = new HorizontalWavesFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void linearStretchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            LinearStretching filter = new LinearStretching();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            Morphology filter = new TopHatFilter(images[imageCounter], this.maxSize, 2);
            filter.SetStructureElement(structureElement);

            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}
