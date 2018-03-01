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
//using System.ComponentModel;

namespace ImageFilters
{
    public partial class Form1 : Form
    {

        //List<Bitmap> list_img;
        //int count;
        //Внимание form;
        //public Foto()
        //{
        //    InitializeComponent();
        //    list_img = new List<Bitmap>();
        //    progressBar1.Visible = false;
        //    /*button2.Visible=button3.Visible=*/
        //    button1.Visible = false;
        //    count = -1;
        //    form = new Внимание();
        List<Bitmap> images;
        Bitmap image;
        int imageCounter;

        public Form1()
        {
            InitializeComponent();
            images = new List<Bitmap>();
            //TODO: DONE Add implementation (hiding progress bar and cancel button AFTER filter was added)
            progressBar1.Visible = false;
            cancelButton.Visible = false;
            cancelButton.Enabled = false;
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
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilter filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
            //Bitmap resultImage = filter.ProcessImage(image);
            //pictureBox1.Image = resultImage;
            //pictureBox1.Refresh();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).ProcessImage(image, backgroundWorker1);

            if (backgroundWorker1.CancellationPending != true) // TODO: CHANGE
            {
                image = newImage;
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
                pictureBox1.Image = image;
                pictureBox1.Refresh();
               //progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = false;
            }
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = false;

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
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = cancelButton.Visible = cancelButton.Enabled = true;

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
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
          
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            { 
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        image.Save(fs,
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

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void forwardButton_Click(object sender, EventArgs e)
        {

        }


        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (count > 0)
        //    {
        //        pictureBox1.Image = list_img[--count];
        //        pictureBox1.Refresh();
        //    }
        //    //  if (count == 0)
        //    // button2.Visible = false;

        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    if (count < list_img.Count - 1)
        //    {
        //        pictureBox1.Image = list_img[++count];
        //        pictureBox1.Refresh();
        //    }
        //    // if (count == list_img.Count - 1)
        //    //   button3.Visible = false;

        //}
    }
}
