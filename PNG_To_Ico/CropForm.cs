using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PNG_To_Ico
{
    public partial class CropForm : Form
    {

        //public delegate void ReturnImage(Image returnImage);
        public SetImageEx SetImage;

        Point currentPixel = new Point(0, 0);
        Point selectedPixel = new Point(0, 0);
        bool[] selectedImages = new bool[] { false, false, false, false, false, false };
        PictureBox[] pictureBoxes = new PictureBox[6];
        private static List<int> allowedSizes = new List<int>(new int[] { 16, 24, 32, 48, 64, 128 });

        public CropForm()
        {
            InitializeComponent();
            pictureBoxes[0] = pb16px;
            pictureBoxes[1] = pb24px;
            pictureBoxes[2] = pb32px;
            pictureBoxes[3] = pb48px;
            pictureBoxes[4] = pb64px;
            pictureBoxes[5] = pb128px;

        }

        public void PopulateForm(Image droppedImage, Image cur128, Image cur64, Image cur48, Image cur32, Image cur24, Image cur16)
        {
            if (droppedImage.Height < 16 || droppedImage.Width < 16)
                this.Hide();
            pbDropped.Image = (Image)droppedImage.Clone();
            pb128px.Image = (Image)cur128.Clone();
            pb64px.Image = (Image)cur64.Clone();
            pb48px.Image = (Image)cur48.Clone();
            pb32px.Image = (Image)cur32.Clone();
            pb24px.Image = (Image)cur24.Clone();
            pb16px.Image = (Image)cur16.Clone();

            if (droppedImage.Height < 128 || droppedImage.Width < 128)
            {
                pb128px.Visible = false;
                p128px.Enabled = false;
            }
            if (droppedImage.Height < 64 || droppedImage.Width < 64)
            {
                pb64px.Visible = false;
                p64px.Enabled = false;
            }
            if (droppedImage.Height < 48 || droppedImage.Width < 48)
            {
                pb48px.Visible = false;
                p48px.Enabled = false;
            }
            if (droppedImage.Height < 32 || droppedImage.Width < 32)
            {
                pb32px.Visible = false;
                p32px.Enabled = false;
            }
            if (droppedImage.Height < 24 || droppedImage.Width < 24)
            {
                pb24px.Visible = false;
                p24px.Enabled = false;
            }
        }



        private void pbDropped_MouseMove(object sender, MouseEventArgs e)
        {
            currentPixel = e.Location;
            debugPos();
        }

        private void pbDropped_Click(object sender, EventArgs e)
        {
            selectedPixel = currentPixel;
            pButtons.Visible = true;
            updatePreview();
            debugPos();
        }
        


        private void updatePreview()
        {
            if (pb128px.Enabled && !selectedImages[5])
            {
                Point startPoint = new Point(0, 0);
                startPoint.X = (!(selectedPixel.X > (pbDropped.Image.Width - 128)) ? selectedPixel.X : pbDropped.Image.Width - 128);
                startPoint.Y = (!(selectedPixel.Y > (pbDropped.Image.Height - 128)) ? selectedPixel.Y : pbDropped.Image.Height - 128);
                pb128px.Image = GetCropped(new Bitmap(pbDropped.Image), 128, startPoint);
            }
            if (pb64px.Enabled && !selectedImages[4])
            {
                Point startPoint = new Point(0, 0);
                startPoint.X = !(selectedPixel.X > pbDropped.Image.Width - 64) ? selectedPixel.X : pbDropped.Image.Width - 64;
                startPoint.Y = !(selectedPixel.Y > pbDropped.Image.Height - 64) ? selectedPixel.Y : pbDropped.Image.Height - 64;
                pb64px.Image = GetCropped(new Bitmap(pbDropped.Image), 64, startPoint);
            }
            if (pb48px.Enabled && !selectedImages[3])
            {
                Point startPoint = new Point(0, 0);
                startPoint.X = !(selectedPixel.X > pbDropped.Image.Width - 48) ? selectedPixel.X : pbDropped.Image.Width - 48;
                startPoint.Y = !(selectedPixel.Y > pbDropped.Image.Height - 48) ? selectedPixel.Y : pbDropped.Image.Height - 48;
                pb48px.Image = GetCropped(new Bitmap(pbDropped.Image), 48, startPoint);
            }
            if (pb32px.Enabled && !selectedImages[2])
            {
                Point startPoint = new Point(0, 0);
                startPoint.X = !(selectedPixel.X > pbDropped.Image.Width - 32) ? selectedPixel.X : pbDropped.Image.Width - 32;
                startPoint.Y = !(selectedPixel.Y > pbDropped.Image.Height - 32) ? selectedPixel.Y : pbDropped.Image.Height - 32;
                pb32px.Image = GetCropped(new Bitmap(pbDropped.Image), 32, startPoint);
            }
            if (pb24px.Enabled && !selectedImages[1])
            {
                Point startPoint = new Point(0, 0);
                startPoint.X = !(selectedPixel.X > pbDropped.Image.Width - 24) ? selectedPixel.X : pbDropped.Image.Width - 24;
                startPoint.Y = !(selectedPixel.Y > pbDropped.Image.Height - 24) ? selectedPixel.Y : pbDropped.Image.Height - 24;
                pb24px.Image = GetCropped(new Bitmap(pbDropped.Image), 24, startPoint);
            }
            if (pb16px.Enabled && !selectedImages[0])
            {
                Point startPoint = new Point(0, 0);
                startPoint.X = !(selectedPixel.X > pbDropped.Image.Width - 16) ? selectedPixel.X : pbDropped.Image.Width - 16;
                startPoint.Y = !(selectedPixel.Y > pbDropped.Image.Height - 16) ? selectedPixel.Y : pbDropped.Image.Height - 16;
                pb16px.Image = GetCropped(new Bitmap(pbDropped.Image), 16, startPoint);
            }
        }

        
        private void debugPos()
        {
            lblX.Text = string.Format("Current X:{0}\nSelected X:{1}", currentPixel.X, selectedPixel.X);
            lblY.Text = string.Format("Current Y:{0}\nSelected Y:{1}", currentPixel.Y, selectedPixel.Y);
        }



        #region ArrowButtons

        private void btnUp_Click(object sender, EventArgs e)
        {
            if(selectedPixel.Y > 0)
                selectedPixel.Y -= 1;
            updatePreview();
            debugPos();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if(selectedPixel.Y < pbDropped.Image.Height)
                selectedPixel.Y += 1;
            updatePreview();
            debugPos();
        }
        
        private void btnRight_Click(object sender, EventArgs e)
        {
            if(selectedPixel.X < pbDropped.Image.Width)
                selectedPixel.X += 1;
            updatePreview();
            debugPos();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if(selectedPixel.X > 0)
                selectedPixel.X -= 1;
            updatePreview();
            debugPos();
        }
        #endregion

        #region PictureBox_Click

        private void pb16px_Click(object sender, EventArgs e)
        {
            if (!selectedImages[0])
            {
                selectedImages[0] = true;
                p16px.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            }
            else
            {
                selectedImages[0] = false;
                p16px.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
        }

        private void pb24px_Click(object sender, EventArgs e)
        {
            if(!selectedImages[1])
            {
                selectedImages[1] = true;
                p24px.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            }
            else
            {
                selectedImages[1] = false;
                p24px.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
        }

        private void pb32px_Click(object sender, EventArgs e)
        {
            if(!selectedImages[2])
            {
                selectedImages[2] = true;
                p32px.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            }
            else
            {
                selectedImages[2] = false;
                p32px.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
        }

        private void pb48px_Click(object sender, EventArgs e)
        {
            if (!selectedImages[3])
            {
                selectedImages[3] = true;
                p48px.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            }
            else
            {
                selectedImages[3] = false;
                p48px.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
        }

        private void pb64px_Click(object sender, EventArgs e)
        {
            if(!selectedImages[4])
            {
                selectedImages[4] = true;
                p64px.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            }
            else
            {
                selectedImages[4] = false;
                p64px.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
        }

        private void pb128px_Click(object sender, EventArgs e)
        {
            if(!selectedImages[5])
            {
                selectedImages[5] = true;
                p128px.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            }
            else
            {
                selectedImages[5] = false;
                p128px.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
        }
        #endregion


        /// <summary>
        /// Takes a bitmap and returns a cropped version
        /// </summary>
        /// <param name="original">Original image</param>
        /// <param name="hSize">Height of the cropped image</param>
        /// <param name="wSize">Width of the cropped image</param>
        /// <param name="startPoint">Start point of the cropped image</param>
        /// <returns>A cropped image</returns>
        private Bitmap GetCropped(Bitmap original, int hSize, int wSize, Point startPoint)
        {
            //Bitmap workingPic = new Bitmap(original);
            Bitmap newImage = new Bitmap(wSize, hSize);
            for(int h = 0; h < hSize; h++)
            {
                for(int w = 0; w < wSize; w++)
                {
                    newImage.SetPixel(w, h, original.GetPixel(startPoint.X + w, startPoint.Y + h));
                }
            }
            return newImage;
        }

        /// <summary>
        /// Takes a bitmap and returns a cropped square version
        /// </summary>
        /// <param name="original">Original Image</param>
        /// <param name="size">The width/height of the cropped image</param>
        /// <param name="startPoint">Start point of the cropped image</param>
        /// <returns>A cropped image</returns>
        private Bitmap GetCropped(Bitmap original, int size, Point startPoint)
        {
            return GetCropped(original, size, size, startPoint);
        }





        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Click the image to select the upper left corner of your icon.\n2. Use arrow buttons for fine control.\n3. Click preview on the left to freeze and select.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 6; i++)
            {
                if(selectedImages[i])
                {
                    SetImage(pictureBoxes[i].Image);
                }
            }
            Close();
        }
    }
}
