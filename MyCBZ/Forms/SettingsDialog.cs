﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Win_CBZ.Data;

namespace Win_CBZ.Forms
{
    public partial class SettingsDialog : Form
    {

        public String[] NewDefaults;

        public String[] NewValidTagList;

        public bool ValidateTagsSetting;

        public bool TagValidationIgnoreCase;

        public SettingsDialog()
        {
            InitializeComponent();

            if (Win_CBZSettings.Default.CustomDefaultProperties != null)
            {
                NewDefaults = Win_CBZSettings.Default.CustomDefaultProperties.OfType<String>().ToArray();
            }

            if (Win_CBZSettings.Default.ValidKnownTags != null)
            {
                NewValidTagList = Win_CBZSettings.Default.ValidKnownTags.OfType<String>().ToArray();
            }

            ValidateTagsSetting = Win_CBZSettings.Default.ValidateTags;
            TagValidationIgnoreCase = Win_CBZSettings.Default.TagValidationIgnoreCase;

            // ----------------------------------------

            ValidTags.Lines = NewValidTagList;
            CustomDefaultKeys.Lines = NewDefaults;

            CheckBoxValidateTags.Checked = ValidateTagsSetting;
            CheckBoxTagValidationIgnoreCase.Checked = !TagValidationIgnoreCase;

            MetaDataConfigTabControl.Dock = DockStyle.Fill;
            ImageProcessingTabControl.Dock = DockStyle.Fill;

            MetaDataConfigTabControl.Visible = true;
            ImageProcessingTabControl.Visible = false;

            DialogResult = DialogResult.Cancel;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;  
        }

        private void SettingsDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                Program.ProjectModel.MetaData.CustomDefaultProperties = new List<String>(CustomDefaultKeys.Lines.ToArray<String>());            
                try
                {
                    Program.ProjectModel.MetaData.MakeDefaultKeys(Program.ProjectModel.MetaData.CustomDefaultProperties);

                    Program.ProjectModel.MetaData.ValidateDefaults();

                    if (CheckBoxValidateTags.Checked)
                    {
                        List<String> test = new List<String>(ValidTags.Lines);
                        String[] duplicateTags = DataValidation.ValidateDuplicateStrings(test.ToArray());
                        if (duplicateTags.Length > 0)
                        {
                            //ApplicationMessage.ShowWarning("Validateion Error! Duplicate Tags [" + duplicateTags.Select(r => r + ", ") + "] not allowed!", "Validation Error", ApplicationMessage.DialogType.MT_WARNING, ApplicationMessage.DialogButtons.MB_OK);
                            MessageLogger.Instance.Log(LogMessageEvent.LOGMESSAGE_TYPE_WARNING, "Validateion Error! Duplicate Tags [" + String.Join(",", duplicateTags) + "] not allowed!");

                            throw new MetaDataValidationException("", "", "Validateion Error! Duplicate Tags [" + String.Join(",", duplicateTags) + "] not allowed!");
                        }
                    }

                    // -------------- DANGER!  All validation goes above this line --------------------


                    if (Win_CBZSettings.Default.CustomDefaultProperties != null)
                    {
                        Win_CBZSettings.Default.CustomDefaultProperties.Clear();
                    }
                    else
                    {
                        Win_CBZSettings.Default.CustomDefaultProperties = new StringCollection();
                    }

                    if (Win_CBZSettings.Default.ValidKnownTags != null)
                    {
                        Win_CBZSettings.Default.ValidKnownTags.Clear();
                    }
                    else
                    {
                        Win_CBZSettings.Default.ValidKnownTags = new StringCollection();
                    }

                    NewDefaults = CustomDefaultKeys.Lines.ToArray<String>();
                    NewValidTagList = ValidTags.Lines.ToArray<String>();
                    ValidateTagsSetting = CheckBoxValidateTags.Checked;
                    TagValidationIgnoreCase = !CheckBoxTagValidationIgnoreCase.Checked;
                }
                catch (MetaDataValidationException mv)
                {
                    DialogResult = DialogResult.Cancel;
                    e.Cancel = true;
                    MessageLogger.Instance.Log(LogMessageEvent.LOGMESSAGE_TYPE_ERROR, mv.Message);
                    ApplicationMessage.ShowWarning(mv.Message, "Validation Error", ApplicationMessage.DialogType.MT_WARNING, ApplicationMessage.DialogButtons.MB_OK);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomDefaultKeys.Text = Program.ProjectModel.MetaData.GetDefaultKeys();
        }

        private void SettingsTablePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckBoxValidateTags_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBoxTagValidationIgnoreCase.Enabled = CheckBoxValidateTags.CheckState == CheckState.Checked;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToolButtonSortAscending_Click(object sender, EventArgs e)
        {
            ValidTags.Lines = ValidTags.Lines.OrderBy(s => s).ToArray();
        }

        private void SettingsSectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SettingsSectionList.SelectedIndex == 0)
            {
                MetaDataConfigTabControl.Visible = true;
                ImageProcessingTabControl.Visible = false;
            }

            if (SettingsSectionList.SelectedIndex == 1)
            {
                MetaDataConfigTabControl.Visible = false;
                ImageProcessingTabControl.Visible = true;   
            }
        }
    }
}
