﻿using MyCBZ;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CBZMage
{
    internal class CBZImage
    {

        public const int IMAGE_STATUS_NEW = 0;
        public const int IMAGE_STATUS_COMPRESSED = 1;

        public String Filename { get; set; }

        public String Name { get; set; }

        public int Number { get; set; }

        public long Size { get; set; }

        public String WokringDir { get; set; }

        public String LocalPath { get; set; }

        public String TempPath { get; set; }    

        public bool Compressed { get; set; }

        public bool Changed { get; set; }

        public bool Deleted { get; set; }

        public bool ReadOnly { get; set; }

        public int W { get; set; }

        public int H { get; set; }

        public int Index { get; set; }

        public DateTimeOffset LastModified { get; set; }

        protected int ThumbW { get; set; } = 128;

        protected int ThumbH { get; set; } = 256;

        private Image Image;

        private Image Thumbnail;

        private Stream ImageStream;

        private FileInfo ImageFileInfo;

        public delegate EventHandler<FileOperationEvent> FileOperationEventHandler();
        
        public CBZImage(String fileName)
        {
            ImageFileInfo = new FileInfo(fileName);
            FileStream ImageStream = ImageFileInfo.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            Filename = ImageFileInfo.Name;
            LocalPath = ImageFileInfo.Directory.FullName;
            Name = ImageFileInfo.Name;
        }
        

        public CBZImage(FileInfo fileInfoAccess)
        {
            ImageFileInfo = fileInfoAccess;
            try
            {
                ImageStream = fileInfoAccess.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            } catch (UnauthorizedAccessException uae)
            {
                // MessageBox.Show(uae.Message);

                ImageStream = fileInfoAccess.Open(FileMode.Open, FileAccess.Read, FileShare.Read);
                ReadOnly = true;
            }

            Filename = fileInfoAccess.FullName;
            LocalPath = fileInfoAccess.Directory.FullName;
            Name = fileInfoAccess.Name;
        }

        public CBZImage(Stream fileInputStream, String name)
        {
            ImageStream = fileInputStream;
            Name = name;
        }

        public CBZImage(GZipStream zipInputStream, String name)
        {
            ImageStream = zipInputStream;
            Name = name;
        }

        public Image GetImage()
        {
            this.loadImage();

            return Image;
        }

        public Image GetThumbnail(Image.GetThumbnailImageAbort callback, IntPtr data)
        {
            this.loadImage();

            Thumbnail = Image.GetThumbnailImage(ThumbW, ThumbH, callback, data);

            Image.Dispose();
            Image = null;

            return Thumbnail;
        }


        public void createLocalWorkingCopy()
        {

        }


        private void loadImage()
        {
            if (Image == null && ImageStream.CanRead)
            {
                Image = Image.FromStream(ImageStream);
            }

            if (Image != null)
            {
                if (!Image.Size.IsEmpty)
                {
                    W = Image.Width;
                    H = Image.Height;
                }

                ImageStream.Close();
            }
        }


        public void FreeImage()
        {
            if (Image != null)
            {
                Image.Dispose();
            }
        }
    }
}
