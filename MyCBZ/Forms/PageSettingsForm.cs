﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_CBZ.Forms
{
    internal partial class PageSettingsForm : Form
    {

        Page Page;
        Image PreviewThumb;
        Random RandomProvider;

        public PageSettingsForm(Page page)
        {
            InitializeComponent();

            RandomProvider = new Random();
            Page = new Page(page, RandomProvider.Next().ToString("X"));

            try
            {
                PreviewThumb = Page.GetThumbnail(ThumbAbort, Handle);
            } catch (Exception e) { 
                ApplicationMessage.ShowException(e);
            }

            PreviewThumbPictureBox.Image = PreviewThumb;

            TextBoxFileLocation.Text = Page.Compressed ? Page.TempPath : Page.Filename;
            PageNameTextBox.Text = Page.Name;
            PageIndexTextbox.Text = (Page.Index + 1).ToString();
            CheckBoxPageDeleted.Checked = Page.Deleted;
        }

        private void PageSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private bool ThumbAbort()
        {
            return true;
        }

        public Page GetResult()
        {
            return Page;
        }

        public void FreeResult()
        {
            Page.DeleteTemporaryFile();
            Page.FreeImage();
            Page = null;
        }

        private void PageNameTextBox_TextChanged(object sender, EventArgs e)
        {
            Page.Name = PageNameTextBox.Text;
        }

        private void PageIndexTextbox_TextChanged(object sender, EventArgs e)
        {
            int newIndex = Convert.ToInt32(PageIndexTextbox.Text);

            Page.Index = newIndex - 1;
            Page.Number = newIndex;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {

        }

        private void CheckBoxPageDeleted_CheckedChanged(object sender, EventArgs e)
        {
            Page.Deleted = CheckBoxPageDeleted.Checked;
            if (Page.Deleted)
            {
                Page.Index = -1;
                PageIndexTextbox.Text = "-1";
               
            } else
            {
                Page.Index = Page.OriginalIndex;
                PageIndexTextbox.Text = (Page.OriginalIndex + 1).ToString();
            }

            PageIndexTextbox.Enabled = !Page.Deleted;
        }
    }
}
