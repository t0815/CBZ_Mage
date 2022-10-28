﻿namespace Win_CBZ.Forms
{
    partial class ErrorDialog
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
            this.ErrorDialogTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.DialogIconPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErrorMessageTitle = new System.Windows.Forms.Label();
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ErrorDialogTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DialogIconPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorDialogTablePanel
            // 
            this.ErrorDialogTablePanel.BackColor = System.Drawing.Color.White;
            this.ErrorDialogTablePanel.ColumnCount = 4;
            this.ErrorDialogTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.ErrorDialogTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ErrorDialogTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.ErrorDialogTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.ErrorDialogTablePanel.Controls.Add(this.DialogIconPictureBox, 0, 0);
            this.ErrorDialogTablePanel.Controls.Add(this.panel1, 1, 0);
            this.ErrorDialogTablePanel.Controls.Add(this.TextBoxMessage, 2, 0);
            this.ErrorDialogTablePanel.Controls.Add(this.ButtonOk, 2, 2);
            this.ErrorDialogTablePanel.Controls.Add(this.ButtonCancel, 3, 2);
            this.ErrorDialogTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorDialogTablePanel.Location = new System.Drawing.Point(0, 0);
            this.ErrorDialogTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.ErrorDialogTablePanel.Name = "ErrorDialogTablePanel";
            this.ErrorDialogTablePanel.RowCount = 3;
            this.ErrorDialogTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.ErrorDialogTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ErrorDialogTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.ErrorDialogTablePanel.Size = new System.Drawing.Size(567, 340);
            this.ErrorDialogTablePanel.TabIndex = 0;
            // 
            // DialogIconPictureBox
            // 
            this.DialogIconPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DialogIconPictureBox.Location = new System.Drawing.Point(3, 3);
            this.DialogIconPictureBox.Name = "DialogIconPictureBox";
            this.DialogIconPictureBox.Size = new System.Drawing.Size(74, 74);
            this.DialogIconPictureBox.TabIndex = 0;
            this.DialogIconPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.ErrorDialogTablePanel.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.ErrorMessageTitle);
            this.panel1.Location = new System.Drawing.Point(83, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 74);
            this.panel1.TabIndex = 2;
            // 
            // ErrorMessageTitle
            // 
            this.ErrorMessageTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ErrorMessageTitle.AutoSize = true;
            this.ErrorMessageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessageTitle.Location = new System.Drawing.Point(44, 28);
            this.ErrorMessageTitle.Name = "ErrorMessageTitle";
            this.ErrorMessageTitle.Size = new System.Drawing.Size(133, 20);
            this.ErrorMessageTitle.TabIndex = 0;
            this.ErrorMessageTitle.Text = "[MessageTitle]";
            this.ErrorMessageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorDialogTablePanel.SetColumnSpan(this.TextBoxMessage, 4);
            this.TextBoxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMessage.Location = new System.Drawing.Point(8, 88);
            this.TextBoxMessage.Margin = new System.Windows.Forms.Padding(8);
            this.TextBoxMessage.Multiline = true;
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.ReadOnly = true;
            this.TextBoxMessage.Size = new System.Drawing.Size(551, 184);
            this.TextBoxMessage.TabIndex = 1;
            this.TextBoxMessage.Text = "[Error Message]";
            // 
            // ButtonOk
            // 
            this.ButtonOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOk.Location = new System.Drawing.Point(335, 292);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(104, 36);
            this.ButtonOk.TabIndex = 1;
            this.ButtonOk.Text = "Ok";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(455, 292);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(104, 36);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ErrorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 340);
            this.Controls.Add(this.ErrorDialogTablePanel);
            this.Name = "ErrorDialog";
            this.ShowIcon = false;
            this.Text = "Application Error";
            this.ErrorDialogTablePanel.ResumeLayout(false);
            this.ErrorDialogTablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DialogIconPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ErrorDialogTablePanel;
        private System.Windows.Forms.PictureBox DialogIconPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ErrorMessageTitle;
        private System.Windows.Forms.TextBox TextBoxMessage;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonCancel;
    }
}