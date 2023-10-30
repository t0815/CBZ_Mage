﻿namespace Win_CBZ.Forms
{
    partial class SettingsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SettingsTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SettingsSectionList = new System.Windows.Forms.ListBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SettingsGroup1Panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomDefaultKeys = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CheckBoxValidateTags = new System.Windows.Forms.CheckBox();
            this.InfoIconTooltip = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValidTags = new System.Windows.Forms.TextBox();
            this.CheckBoxTagValidationIgnoreCase = new System.Windows.Forms.CheckBox();
            this.TagValidationTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SettingsTablePanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SettingsGroup1Panel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoIconTooltip)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsTablePanel
            // 
            this.SettingsTablePanel.ColumnCount = 3;
            this.SettingsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.40752F));
            this.SettingsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.59248F));
            this.SettingsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.SettingsTablePanel.Controls.Add(this.ButtonOk, 1, 2);
            this.SettingsTablePanel.Controls.Add(this.HeaderPanel, 0, 0);
            this.SettingsTablePanel.Controls.Add(this.SettingsSectionList, 0, 1);
            this.SettingsTablePanel.Controls.Add(this.ButtonCancel, 2, 2);
            this.SettingsTablePanel.Controls.Add(this.tabControl1, 1, 1);
            this.SettingsTablePanel.Location = new System.Drawing.Point(3, 2);
            this.SettingsTablePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingsTablePanel.Name = "SettingsTablePanel";
            this.SettingsTablePanel.RowCount = 3;
            this.SettingsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.02235F));
            this.SettingsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.97765F));
            this.SettingsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.SettingsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SettingsTablePanel.Size = new System.Drawing.Size(787, 514);
            this.SettingsTablePanel.TabIndex = 0;
            this.SettingsTablePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SettingsTablePanel_Paint);
            // 
            // ButtonOk
            // 
            this.ButtonOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOk.Location = new System.Drawing.Point(540, 460);
            this.ButtonOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(111, 33);
            this.ButtonOk.TabIndex = 2;
            this.ButtonOk.Text = "Ok";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.SettingsTablePanel.SetColumnSpan(this.HeaderPanel, 3);
            this.HeaderPanel.Controls.Add(this.HeaderLabel);
            this.HeaderPanel.Controls.Add(this.pictureBox1);
            this.HeaderPanel.Location = new System.Drawing.Point(3, 2);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(780, 82);
            this.HeaderPanel.TabIndex = 0;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(111, 33);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(85, 16);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Configuration";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Win_CBZ.Properties.Resources.window_gear_large;
            this.pictureBox1.Location = new System.Drawing.Point(24, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 55);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SettingsSectionList
            // 
            this.SettingsSectionList.FormattingEnabled = true;
            this.SettingsSectionList.ItemHeight = 16;
            this.SettingsSectionList.Items.AddRange(new object[] {
            "Meta Data"});
            this.SettingsSectionList.Location = new System.Drawing.Point(3, 107);
            this.SettingsSectionList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingsSectionList.Name = "SettingsSectionList";
            this.SettingsSectionList.Size = new System.Drawing.Size(188, 324);
            this.SettingsSectionList.TabIndex = 1;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(665, 460);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(119, 33);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // tabControl1
            // 
            this.SettingsTablePanel.SetColumnSpan(this.tabControl1, 2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(202, 107);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 327);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SettingsGroup1Panel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(573, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Default";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SettingsGroup1Panel
            // 
            this.SettingsGroup1Panel.Controls.Add(this.button1);
            this.SettingsGroup1Panel.Controls.Add(this.label2);
            this.SettingsGroup1Panel.Controls.Add(this.label1);
            this.SettingsGroup1Panel.Controls.Add(this.CustomDefaultKeys);
            this.SettingsGroup1Panel.Location = new System.Drawing.Point(5, 6);
            this.SettingsGroup1Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingsGroup1Panel.Name = "SettingsGroup1Panel";
            this.SettingsGroup1Panel.Size = new System.Drawing.Size(563, 270);
            this.SettingsGroup1Panel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 228);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Fill Predifined";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "One Key per Line\r\nTo set a default value for a given key use <key>=<value> format" +
    "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Default MetaData Keys";
            // 
            // CustomDefaultKeys
            // 
            this.CustomDefaultKeys.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomDefaultKeys.Location = new System.Drawing.Point(3, 26);
            this.CustomDefaultKeys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomDefaultKeys.Multiline = true;
            this.CustomDefaultKeys.Name = "CustomDefaultKeys";
            this.CustomDefaultKeys.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CustomDefaultKeys.Size = new System.Drawing.Size(547, 169);
            this.CustomDefaultKeys.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(573, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tags";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.54717F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.45283F));
            this.tableLayoutPanel1.Controls.Add(this.CheckBoxValidateTags, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.InfoIconTooltip, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ValidTags, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CheckBoxTagValidationIgnoreCase, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.28302F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.71698F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(565, 290);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CheckBoxValidateTags
            // 
            this.CheckBoxValidateTags.AutoSize = true;
            this.CheckBoxValidateTags.Location = new System.Drawing.Point(3, 2);
            this.CheckBoxValidateTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBoxValidateTags.Name = "CheckBoxValidateTags";
            this.CheckBoxValidateTags.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.CheckBoxValidateTags.Size = new System.Drawing.Size(286, 25);
            this.CheckBoxValidateTags.TabIndex = 0;
            this.CheckBoxValidateTags.Text = "Validate Tags against a list of known Tags";
            this.CheckBoxValidateTags.UseVisualStyleBackColor = true;
            this.CheckBoxValidateTags.CheckStateChanged += new System.EventHandler(this.CheckBoxValidateTags_CheckStateChanged);
            // 
            // InfoIconTooltip
            // 
            this.InfoIconTooltip.Image = global::Win_CBZ.Properties.Resources.information;
            this.InfoIconTooltip.InitialImage = global::Win_CBZ.Properties.Resources.information;
            this.InfoIconTooltip.Location = new System.Drawing.Point(325, 0);
            this.InfoIconTooltip.Margin = new System.Windows.Forms.Padding(0);
            this.InfoIconTooltip.Name = "InfoIconTooltip";
            this.InfoIconTooltip.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tableLayoutPanel1.SetRowSpan(this.InfoIconTooltip, 2);
            this.InfoIconTooltip.Size = new System.Drawing.Size(44, 46);
            this.InfoIconTooltip.TabIndex = 5;
            this.InfoIconTooltip.TabStop = false;
            this.TagValidationTooltip.SetToolTip(this.InfoIconTooltip, "This options allows you, to validate matadata tags against your own list of valid" +
        " tags, \r\npreventing typos and duplicate, invalid tags being generated/shown with" +
        "in applications.\r\n");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "One Tag per Line";
            // 
            // ValidTags
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ValidTags, 2);
            this.ValidTags.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidTags.Location = new System.Drawing.Point(3, 67);
            this.ValidTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValidTags.Multiline = true;
            this.ValidTags.Name = "ValidTags";
            this.ValidTags.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ValidTags.Size = new System.Drawing.Size(536, 154);
            this.ValidTags.TabIndex = 3;
            // 
            // CheckBoxTagValidationIgnoreCase
            // 
            this.CheckBoxTagValidationIgnoreCase.AutoSize = true;
            this.CheckBoxTagValidationIgnoreCase.Enabled = false;
            this.CheckBoxTagValidationIgnoreCase.Location = new System.Drawing.Point(4, 33);
            this.CheckBoxTagValidationIgnoreCase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckBoxTagValidationIgnoreCase.Name = "CheckBoxTagValidationIgnoreCase";
            this.CheckBoxTagValidationIgnoreCase.Padding = new System.Windows.Forms.Padding(24, 5, 0, 0);
            this.CheckBoxTagValidationIgnoreCase.Size = new System.Drawing.Size(143, 25);
            this.CheckBoxTagValidationIgnoreCase.TabIndex = 6;
            this.CheckBoxTagValidationIgnoreCase.Text = "Case Sensitive";
            this.CheckBoxTagValidationIgnoreCase.UseVisualStyleBackColor = true;
            this.CheckBoxTagValidationIgnoreCase.Visible = false;
            // 
            // TagValidationTooltip
            // 
            this.TagValidationTooltip.AutoPopDelay = 30000;
            this.TagValidationTooltip.InitialDelay = 200;
            this.TagValidationTooltip.IsBalloon = true;
            this.TagValidationTooltip.ReshowDelay = 100;
            this.TagValidationTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TagValidationTooltip.ToolTipTitle = "Custom Tag Validation";
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.SettingsTablePanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsDialog_FormClosing);
            this.SettingsTablePanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.SettingsGroup1Panel.ResumeLayout(false);
            this.SettingsGroup1Panel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoIconTooltip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel SettingsTablePanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.ListBox SettingsSectionList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Panel SettingsGroup1Panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomDefaultKeys;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox CheckBoxValidateTags;
        private System.Windows.Forms.TextBox ValidTags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox InfoIconTooltip;
        private System.Windows.Forms.ToolTip TagValidationTooltip;
        private System.Windows.Forms.CheckBox CheckBoxTagValidationIgnoreCase;
    }
}