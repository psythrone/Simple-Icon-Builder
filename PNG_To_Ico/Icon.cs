using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PNG_To_Ico
{
    class Icon
    {
        public Icon()
        {

        }
        public Icon(Image pic)
        {
            this.AddImage(pic);
        }

        Dictionary<int, Image> imageList = new Dictionary<int, Image>();
        
        /// <summary>
        /// Adds an image to the list of images in the icon, only one icon per size and only square icons\nwill replace earlier image of the same size if there is one
        /// </summary>
        /// <param name="pic">The image to add</param>
        /// <returns>returns true if the image was added</returns>
        public bool AddImage(Image pic)
        {
            if(pic.Height == pic.Width)
            {
                if(!imageList.ContainsKey(pic.Width))
                {
                    imageList.Add(pic.Width, pic);
                }
                else
                {
                    imageList[pic.Width] = pic;
                }
                return true;
            }
            return false;
        }

        public byte[] GenerateIcon()
        {
            List<int> tempList = imageList.Keys.ToList();
            return this.GenerateIcon(tempList);
        }

        public byte[] GenerateIcon(List<int> sizeList)
        {
            List<byte> returnIcon = new List<byte>();
            List<byte> tempImages = new List<byte>();
            byte maskBuilder = 0x00;
            List<int> tempList = sizeList;
            Bitmap currentImage;
            tempList.Sort();
            tempList.Reverse();

            //returnIcon.Add(0x00); // HAS to be 0
            //returnIcon.Add(0x00); // HAS to be 0
            //returnIcon.Add(0x01); // we are making an icon, 0x02 would be a cursor
            //returnIcon.Add(0x00); // second part of choosing an icon
            //returnIcon.Add((byte)sizeList.Count); // the number of icons in the file
            //returnIcon.Add(0x00); // I'm setting this to zero, if you need more than 255 icons in the same .ico file you'll have to get a different program
            returnIcon.AddRange(GenerateByteArray(2, 0));               // Has to be 00 00
            returnIcon.AddRange(GenerateByteArray(2, 1));               // Icon is 1, cursor is 2
            returnIcon.AddRange(GenerateByteArray(2, sizeList.Count));  // Number of icons in file

            foreach (int iconSize in tempList)
            {

                // ------------------------------------------------------------------ Image List Header
                returnIcon.Add((byte)iconSize); // width            (1 byte)
                returnIcon.Add((byte)iconSize); // height           (1 byte)
                returnIcon.Add(0x00);           // palette (32bpp)  (1 byte)
                returnIcon.Add(0x00);           // RESERVED         (1 byte)
                //returnIcon.Add(0x01);           // Color planes     (2 bytes)
                //returnIcon.Add(0x00);           // Color planes         |
                //returnIcon.Add(0x20);           // BPP (32)         (2 bytes)
                //returnIcon.Add(0x00);           // BPP                  |
                returnIcon.AddRange(GenerateByteArray(2, 1));   // Color planes
                returnIcon.AddRange(GenerateByteArray(2, 32));  // BPP


                List<byte> andMask = new List<byte>();
                int maskPadding = 0;
                int andMaskSize = 32 * (iconSize / 32);
                if (iconSize % 32 != 0)
                    andMaskSize += 32;
                maskPadding = (andMaskSize - iconSize) /8;
                andMaskSize *= iconSize;


                // CHECK andMaskSize, for 32 it is 1024, should be ??128?? :: Trying with andMaskSize/8
                //int sizeInBytes = (((int)Math.Pow(iconSize, 2) * 4)+40+(andMaskSize));
                int sizeInBytes = (((int)Math.Pow(iconSize, 2) * 4)+40+(andMaskSize/8));

                returnIcon.AddRange(GenerateByteArray(4, sizeInBytes));     // Size of the image + header

                int imageDataOffset = 6 + (16 * tempList.Count) + tempImages.Count;

                returnIcon.AddRange(GenerateByteArray(4, imageDataOffset)); // Points at the start of the bitmapinfoheader


                //returnIcon.Add((byte)(sizeInBytes));        // Size of the image + header   (4 bytes)
                //returnIcon.Add((byte)(sizeInBytes >> 8));   //                                  |
                //returnIcon.Add((byte)(sizeInBytes >> 16));  //                                  |
                //returnIcon.Add((byte)(sizeInBytes >> 24));  //                                  |

                //Icon file header (6) + Library headers (16 * Number of icons in the finished file) + Image data of icons already in file
                //returnIcon.Add((byte)(imageDataOffset));        // Size of the image + header   (4 bytes)
                //returnIcon.Add((byte)(imageDataOffset >> 8));   //                                  |
                //returnIcon.Add((byte)(imageDataOffset >> 16));  //                                  |
                //returnIcon.Add((byte)(imageDataOffset >> 24));  //                                  |

                // ------------------------------------------------------------------ Bitmap Header
                currentImage = new Bitmap(imageList[iconSize]);
                currentImage.RotateFlip(RotateFlipType.RotateNoneFlipY);

                //byte[] word;
                //tempImages.Add();

                tempImages.AddRange(GenerateByteArray(4, 40));          // Btimap header size
                tempImages.AddRange(GenerateByteArray(4, iconSize));    // Image width
                tempImages.AddRange(GenerateByteArray(4, iconSize*2));  // Image height*2 for 32bpp
                tempImages.AddRange(GenerateByteArray(2, 1));           // Color planes (should be 1 no idea what it is)
                tempImages.AddRange(GenerateByteArray(2, 32));          // BPP
                tempImages.AddRange(GenerateByteArray(4, 0));           // Compression method (0 == BI_RGB, uncompresed)

                
                // -----------------------------------------!!FIX THIS!!------------------------------------------
                // -----------------------------------------!!FIX THIS!!------------------------------------------
                // -----------------------------------------!!FIX THIS!!------------------------------------------
                // -----------------------------------------!!FIX THIS!!------------------------------------------

                // My documentation claims this can be 0 for BI_RGB and only important for compressed images
                tempImages.AddRange(GenerateByteArray(4, 0)); // Raw image size, check how to calc! My 32x32 test icon is 0x2000 or 8192

                // -----------------------------------------!!FIX THIS!!------------------------------------------
                // -----------------------------------------!!FIX THIS!!------------------------------------------
                // -----------------------------------------!!FIX THIS!!------------------------------------------
                // -----------------------------------------!!FIX THIS!!------------------------------------------
                

                tempImages.AddRange(GenerateByteArray(4, 0));           // Horizontal resolution, used for printing, unused for icons
                tempImages.AddRange(GenerateByteArray(4, 0));           // Vertical resolution in px/m
                tempImages.AddRange(GenerateByteArray(4, 0));           // Number of colors in palette, 0 means no palette is used (2^n ?)
                tempImages.AddRange(GenerateByteArray(4, 0));           // Number of important colors, 0 means all colors are important
                /**
                 * 
                 *  Bitmap header size (0x28 = 40, should be 40)
                 *  /\
                 *  /\
                 *  /\
                 *  Image width (0x20 = 32px)
                 *  /\
                 *  /\
                 *  /\
                 *  Image height (0x40 = 64px HEIGHT IS DOUBLED FOR 32BPP)
                 *  /\
                 *  /\
                 *  /\
                 *  No. color planes (should be 1)
                 *  /\
                 *  BPP (0x20 = 32bpp)
                 *  /\
                 *  Compression method (BI_RGB, uncompressed)
                 *  /\
                 *  /\
                 *  /\
                 *  Raw image size (0x2000 = 8192)
                 *  /\
                 *  /\
                 *  /\
                 *  H. res (0px/m)
                 *  /\
                 *  /\
                 *  /\
                 *  V. res (0px/m)
                 *  /\
                 *  /\
                 *  /\
                 *  No. colors in palette (2^n)
                 *  /\
                 *  /\
                 *  /\
                 *  No. important colors (All)
                 *  /\
                 *  /\
                 *  /\
                 * 
                 * */

                // ------------------------------------------------------------------ Image Data
                for (int i = 0; i < Math.Pow(iconSize,2); i++)
                {
                    tempImages.Add(currentImage.GetPixel(i % iconSize, i / iconSize).B);    // Blue
                    tempImages.Add(currentImage.GetPixel(i % iconSize, i / iconSize).G);    // Green
                    tempImages.Add(currentImage.GetPixel(i % iconSize, i / iconSize).R);    // Red
                    tempImages.Add(currentImage.GetPixel(i % iconSize, i / iconSize).A);    // Alpha

                    if (i % 8 == 0 && i != 0)
                    {
                        andMask.Add(maskBuilder);
                        maskBuilder = 0x00;

                        if (i % iconSize == 0)
                            for (int j = 0; j < maskPadding; j++)
                                andMask.Add(0x00);
                    }

                    maskBuilder = (byte)(maskBuilder | ((currentImage.GetPixel(i % iconSize, i / iconSize).A)<0x80?0x01:0x00) << (7-(i%8)));
                }
                andMask.Add(maskBuilder);
                for (int j = 0; j < maskPadding; j++)
                    andMask.Add(0x00);
                
                tempImages.AddRange(andMask);
            }

            returnIcon.AddRange(tempImages);
            return returnIcon.ToArray(); ;
        }


        /// <summary>
        /// Gives you the input value as a little endian byte array of fixed size
        /// </summary>
        /// <param name="length">Number of bytes you want</param>
        /// <param name="value">The value you want in byte format</param>
        /// <returns></returns>
        private byte[] GenerateByteArray(int length, int value)
        {
            byte[] returnArray = new byte[length];
            for(int i = 0; i< length; i++)
            {
                returnArray[i] = ((byte)(value >> 8*i));
            }
            return returnArray;
        }
    }
}
