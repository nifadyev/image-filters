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
        int imageCounter;
        int maxSize = 0;
        bool[,] structureElement = null;

        public Form1()
        {
            InitializeComponent();
            images = new List<Bitmap>();
            imageCounter = -1;       
        }

        //--------------------------------------Open and Save--------------------------------------

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png; *.jpg; *.jpeg; *.bmp | All Files (*.*) | *.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(dialog.FileName);

                images.Clear();
                images.Add(image);
                pictureBox1.Image = images.Last();
                pictureBox1.Refresh();
                imageCounter = 0;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog.Title = "Save an Image File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();

                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        images[imageCounter].Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        images[imageCounter].Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        images[imageCounter].Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }

        //--------------------------------------Background worker--------------------------------------

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
            }

            progressBar1.Value = 0;
        }

        //--------------------------------------Buttons--------------------------------------

        private void cancelButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
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

        //--------------------------------------Basic point filters--------------------------------------

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilter filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayScaleFilter filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void sepiaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void highBrigtnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HIghBrightnessFilter filter = new HIghBrightnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void maximumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaximumFilter filter = new MaximumFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        //--------------------------------------Basic matrix filters--------------------------------------

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SobolFilter filter = new SobolFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        //--------------------------------------Extra point filters--------------------------------------

        private void glassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlassFilter filter = new GlassFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void horizontalWavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HorizontalWavesFilter filter = new HorizontalWavesFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void linearStretchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinearStretching filter = new LinearStretching();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void idealReflectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IdealReflector filter = new IdealReflector(images[imageCounter]);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        //--------------------------------------Extra matrix filters--------------------------------------

        private void highSharpnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighSharpnessFilter filter = new HighSharpnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void embossingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatrixFilter embossingFilter = new EmbossingFilter();
            backgroundWorker1.RunWorkerAsync(embossingFilter);
        }

        private void medianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedianFilter filter = new MedianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void glowingEdgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlowingEdgesFilter filter = new GlowingEdgesFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        //--------------------------------------Morphology--------------------------------------

        private void setStructureElementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form2 = new Form2();
                form2.Owner = this;
                form2.ShowDialog();

                this.maxSize = form2.maxSize;
                this.structureElement = form2.structureElement;
            }
            catch
            {
                MessageBox.Show("Set structure element failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Morphology filter = new Morphology(images[imageCounter], this.maxSize, 1);
            filter.SetStructureElement(structureElement);

            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Morphology filter = new Morphology(images[imageCounter], this.maxSize, 2);
            filter.SetStructureElement(structureElement);

            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Morphology filter = new Opening(images[imageCounter], this.maxSize, 1);
            filter.SetStructureElement(structureElement);

            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Morphology filter = new Closing(images[imageCounter], this.maxSize, 2);
            filter.SetStructureElement(structureElement);

            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Morphology filter = new TopHatFilter(images[imageCounter], this.maxSize, 2);
            filter.SetStructureElement(structureElement);

            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}
