using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PNG_To_Ico
{
    public delegate void SetImageEx(Image exIm);

    public partial class Form1 : Form
    {
        bool[] selectedIcons;
        Icon icon = new Icon();
        List<int> sizes = new List<int>();
        private static List<int> allowedSizes = new List<int>(new int[]{16,24,32,48,64,128});
        CropForm cropF;
        

        public Form1()
        {
            InitializeComponent();
            selectedIcons = new bool[] { false, false, false, false, false, false };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(selectedIcons[0])
                icon.AddImage(pbIcon16px.Image);
            if(selectedIcons[1])
                icon.AddImage(pbIcon24px.Image);
            if(selectedIcons[2])
                icon.AddImage(pbIcon32px.Image);
            if(selectedIcons[3])
                icon.AddImage(pbIcon48px.Image);
            if(selectedIcons[4])
                icon.AddImage(pbIcon64px.Image);
            if(selectedIcons[5])
                icon.AddImage(pbIcon128px.Image);
            sfdIcon.ShowDialog();
        }

        private void sfdIcon_FileOk(object sender, CancelEventArgs e)
        {
            if(sizes.Count > 0)
            {
                using (BinaryWriter bw = new BinaryWriter(new FileStream(sfdIcon.FileName, FileMode.Create)))
                {
                    bw.Write(icon.GenerateIcon(sizes));
                    bw.Flush();
                    bw.Close();
                }
            }
        }

        private void drawBorders()
        {
            if (selectedIcons[0])
                pIcon16px.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            else
                pIcon16px.BackColor = Color.FromKnownColor(KnownColor.Control);

            if (selectedIcons[1])
                pIcon24px.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            else
                pIcon24px.BackColor = Color.FromKnownColor(KnownColor.Control);

            if (selectedIcons[2])
                pIcon32px.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            else
                pIcon32px.BackColor = Color.FromKnownColor(KnownColor.Control);

            if (selectedIcons[3])
                pIcon48px.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            else
                pIcon48px.BackColor = Color.FromKnownColor(KnownColor.Control);

            if (selectedIcons[4])
                pIcon64px.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            else
                pIcon64px.BackColor = Color.FromKnownColor(KnownColor.Control);

            if (selectedIcons[5])
                pIcon128px.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            else
                pIcon128px.BackColor = Color.FromKnownColor(KnownColor.Control);

        }

        private void pbIcon128px_Click(object sender, EventArgs e)
        {
            if (selectedIcons[5])
            {
                sizes.Remove(128);
                selectedIcons[5] = false;
            }
            else
            {
                sizes.Add(128);
                selectedIcons[5] = true;
            }
            drawBorders();
        }

        private void pbIcon64px_Click(object sender, EventArgs e)
        {
            if (selectedIcons[4])
            {
                sizes.Remove(64);
                selectedIcons[4] = false;
            }
            else
            {
                sizes.Add(64);
                selectedIcons[4] = true;
            }
            drawBorders();
        }

        private void pbIcon48px_Click(object sender, EventArgs e)
        {
            if (selectedIcons[3])
            {
                sizes.Remove(48);
                selectedIcons[3] = false;
            }
            else
            {
                sizes.Add(48);
                selectedIcons[3] = true;
            }
            drawBorders();
        }

        private void pbIcon32px_Click(object sender, EventArgs e)
        {
            if (selectedIcons[2])
            {
                sizes.Remove(32);
                selectedIcons[2] = false;
            }
            else
            {
                sizes.Add(32);
                selectedIcons[2] = true;
            }
            drawBorders();
        }

        private void pbIcon24px_Click(object sender, EventArgs e)
        {
            if (selectedIcons[1])
            {
                sizes.Remove(24);
                selectedIcons[1] = false;
            }
            else
            {
                sizes.Add(24);
                selectedIcons[1] = true;
            }
            drawBorders();
        }

        private void pbIcon16px_Click(object sender, EventArgs e)
        {
            if (selectedIcons[0])
            {
                sizes.Remove(16);
                selectedIcons[0] = false;
            }
            else
            {
                sizes.Add(16);
                selectedIcons[0] = true;
            }
            drawBorders();
        }

        private void SetImage(int size, Image im)
        {
            if(size == 16)
            {
                pbIcon16px.Image = im;
            }
            else if(size == 24)
            {
                pbIcon24px.Image = im;
            }
            else if(size == 32)
            {
                pbIcon32px.Image = im;
            }
            else if(size == 48)
            {
                pbIcon48px.Image = im;
            }
            else if(size == 64)
            {
                pbIcon64px.Image = im;
            }
            else
            {
                pbIcon128px.Image = im;
            }
        }

        private void SetImage(Image im)
        {
            SetImage(im.Width, im);
        }


        private void AddFromFile(string imagePath)
        {
            if (IsValidImage(imagePath))
            {
                using (Image tempImage = Image.FromFile(imagePath))
                {
                    if (allowedSizes.Contains(tempImage.Height) && allowedSizes.Contains(tempImage.Width) && tempImage.Height == tempImage.Width)
                    {
                        SetImage(tempImage.Height, (Image)tempImage.Clone());
                        //icon.AddImage(tempImage);
                    }
                    else
                    {
                        //MessageBox.Show("Image is not in a size supported in this program", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (tempImage.Height > 16 && tempImage.Width > 16)
                        {
                            cropF = new CropForm();
                            cropF.SetImage = new SetImageEx(this.SetImage);
                            cropF.Show();
                            cropF.PopulateForm(tempImage, pbIcon128px.Image, pbIcon64px.Image, pbIcon48px.Image, pbIcon32px.Image, pbIcon24px.Image, pbIcon16px.Image);
                        }
                        else
                            MessageBox.Show("Image to small, smallest size is 16*16px", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }


        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Drag and drop images of appropriate sizes to add, only one image per size.\nClick the images to select/deselect, blue border means selected.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileArray = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (fileArray.Length == 0)
            {
                MessageBox.Show("No Files Dropped");
            }
            else if (fileArray.Length > 1)
            {
                for (int i = 0; i < fileArray.Length; i++)
                    AddFromFile(fileArray[i]);
            }
            else
            {
                AddFromFile(fileArray[0]);
            }
        }

        /// <summary>
        /// Checks if the file is a valid image
        /// </summary>
        /// <param name="filename">File to check</param>
        /// <returns>Returns true if file is a valid image</returns>
        private bool IsValidImage(string filename) // Copied from StackOverflow: https://stackoverflow.com/questions/210650/validate-image-from-file-in-c-sharp
        {
            try
            {
                using (Image newImage = Image.FromFile(filename))
                { }
            }
            catch (Exception ex)
            {
                //The file does not have a valid image format.
                //-or- GDI+ does not support the pixel format of the file
                string errorMessage = string.Format("Invalid file format or damaged file\n{0}", ex.GetType());
                MessageBox.Show(errorMessage, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //MessageBox.Show("File");
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                //MessageBox.Show("Not File");
            }
        }
    }
}
