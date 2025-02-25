﻿
namespace DesktopClientWinforms
{
    partial class CreateShowPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.btnCreateShow = new System.Windows.Forms.Button();
            this.comboSound = new System.Windows.Forms.ComboBox();
            this.lblSound = new System.Windows.Forms.Label();
            this.comboGraphic = new System.Windows.Forms.ComboBox();
            this.lblGraphic = new System.Windows.Forms.Label();
            this.comboSubtitles = new System.Windows.Forms.ComboBox();
            this.lblSub = new System.Windows.Forms.Label();
            this.comboDub = new System.Windows.Forms.ComboBox();
            this.lblDubLanguage = new System.Windows.Forms.Label();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.lblRoomId = new System.Windows.Forms.Label();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.lblMovieId = new System.Windows.Forms.Label();
            this.datePickePanel = new System.Windows.Forms.Panel();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.backgroundPanel.SuspendLayout();
            this.datePickePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.backgroundPanel.Controls.Add(this.btnCreateShow);
            this.backgroundPanel.Controls.Add(this.comboSound);
            this.backgroundPanel.Controls.Add(this.lblSound);
            this.backgroundPanel.Controls.Add(this.comboGraphic);
            this.backgroundPanel.Controls.Add(this.lblGraphic);
            this.backgroundPanel.Controls.Add(this.comboSubtitles);
            this.backgroundPanel.Controls.Add(this.lblSub);
            this.backgroundPanel.Controls.Add(this.comboDub);
            this.backgroundPanel.Controls.Add(this.lblDubLanguage);
            this.backgroundPanel.Controls.Add(this.txtRoomId);
            this.backgroundPanel.Controls.Add(this.lblRoomId);
            this.backgroundPanel.Controls.Add(this.txtMovieId);
            this.backgroundPanel.Controls.Add(this.lblMovieId);
            this.backgroundPanel.Controls.Add(this.datePickePanel);
            this.backgroundPanel.Controls.Add(this.lblDate);
            this.backgroundPanel.Controls.Add(this.lblTitle);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backgroundPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(867, 528);
            this.backgroundPanel.TabIndex = 0;
            // 
            // btnCreateShow
            // 
            this.btnCreateShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnCreateShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateShow.FlatAppearance.BorderSize = 0;
            this.btnCreateShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateShow.Location = new System.Drawing.Point(0, 483);
            this.btnCreateShow.Name = "btnCreateShow";
            this.btnCreateShow.Size = new System.Drawing.Size(867, 45);
            this.btnCreateShow.TabIndex = 5;
            this.btnCreateShow.Text = "Create";
            this.btnCreateShow.UseVisualStyleBackColor = false;
            this.btnCreateShow.Click += new System.EventHandler(this.btnCreateShow_Click);
            // 
            // comboSound
            // 
            this.comboSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.comboSound.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSound.ForeColor = System.Drawing.SystemColors.Window;
            this.comboSound.FormattingEnabled = true;
            this.comboSound.Location = new System.Drawing.Point(0, 445);
            this.comboSound.Name = "comboSound";
            this.comboSound.Size = new System.Drawing.Size(867, 38);
            this.comboSound.TabIndex = 18;
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSound.Location = new System.Drawing.Point(0, 415);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(126, 30);
            this.lblSound.TabIndex = 17;
            this.lblSound.Text = "Sound Type:";
            // 
            // comboGraphic
            // 
            this.comboGraphic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.comboGraphic.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboGraphic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboGraphic.ForeColor = System.Drawing.SystemColors.Window;
            this.comboGraphic.FormattingEnabled = true;
            this.comboGraphic.Location = new System.Drawing.Point(0, 377);
            this.comboGraphic.Name = "comboGraphic";
            this.comboGraphic.Size = new System.Drawing.Size(867, 38);
            this.comboGraphic.TabIndex = 16;
            // 
            // lblGraphic
            // 
            this.lblGraphic.AutoSize = true;
            this.lblGraphic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGraphic.Location = new System.Drawing.Point(0, 347);
            this.lblGraphic.Name = "lblGraphic";
            this.lblGraphic.Size = new System.Drawing.Size(138, 30);
            this.lblGraphic.TabIndex = 15;
            this.lblGraphic.Text = "Graphic Type:";
            // 
            // comboSubtitles
            // 
            this.comboSubtitles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.comboSubtitles.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboSubtitles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSubtitles.ForeColor = System.Drawing.SystemColors.Window;
            this.comboSubtitles.FormattingEnabled = true;
            this.comboSubtitles.Location = new System.Drawing.Point(0, 309);
            this.comboSubtitles.Name = "comboSubtitles";
            this.comboSubtitles.Size = new System.Drawing.Size(867, 38);
            this.comboSubtitles.TabIndex = 13;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSub.Location = new System.Drawing.Point(0, 279);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(194, 30);
            this.lblSub.TabIndex = 14;
            this.lblSub.Text = "Subtitles Language:";
            // 
            // comboDub
            // 
            this.comboDub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.comboDub.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboDub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboDub.ForeColor = System.Drawing.SystemColors.Window;
            this.comboDub.FormattingEnabled = true;
            this.comboDub.Location = new System.Drawing.Point(0, 241);
            this.comboDub.Name = "comboDub";
            this.comboDub.Size = new System.Drawing.Size(867, 38);
            this.comboDub.TabIndex = 12;
            // 
            // lblDubLanguage
            // 
            this.lblDubLanguage.AutoSize = true;
            this.lblDubLanguage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDubLanguage.Location = new System.Drawing.Point(0, 211);
            this.lblDubLanguage.Name = "lblDubLanguage";
            this.lblDubLanguage.Size = new System.Drawing.Size(154, 30);
            this.lblDubLanguage.TabIndex = 11;
            this.lblDubLanguage.Text = "Dub Language:";
            // 
            // txtRoomId
            // 
            this.txtRoomId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.txtRoomId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomId.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRoomId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtRoomId.Location = new System.Drawing.Point(0, 183);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(867, 28);
            this.txtRoomId.TabIndex = 9;
            this.txtRoomId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoomId_KeyPress);
            // 
            // lblRoomId
            // 
            this.lblRoomId.AutoSize = true;
            this.lblRoomId.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRoomId.Location = new System.Drawing.Point(0, 153);
            this.lblRoomId.Name = "lblRoomId";
            this.lblRoomId.Size = new System.Drawing.Size(96, 30);
            this.lblRoomId.TabIndex = 8;
            this.lblRoomId.Text = "Room Id:";
            // 
            // txtMovieId
            // 
            this.txtMovieId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.txtMovieId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMovieId.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMovieId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtMovieId.Location = new System.Drawing.Point(0, 125);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(867, 28);
            this.txtMovieId.TabIndex = 7;
            this.txtMovieId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMovieId_KeyPress);
            // 
            // lblMovieId
            // 
            this.lblMovieId.AutoSize = true;
            this.lblMovieId.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMovieId.Location = new System.Drawing.Point(0, 95);
            this.lblMovieId.Name = "lblMovieId";
            this.lblMovieId.Size = new System.Drawing.Size(99, 30);
            this.lblMovieId.TabIndex = 6;
            this.lblMovieId.Text = "Movie Id:";
            // 
            // datePickePanel
            // 
            this.datePickePanel.Controls.Add(this.datePicker);
            this.datePickePanel.Controls.Add(this.timePicker);
            this.datePickePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.datePickePanel.Location = new System.Drawing.Point(0, 60);
            this.datePickePanel.Name = "datePickePanel";
            this.datePickePanel.Size = new System.Drawing.Size(867, 35);
            this.datePickePanel.TabIndex = 19;
            // 
            // datePicker
            // 
            this.datePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.datePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.datePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.datePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datePicker.Location = new System.Drawing.Point(485, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowUpDown = true;
            this.datePicker.Size = new System.Drawing.Size(382, 35);
            this.datePicker.TabIndex = 10;
            // 
            // timePicker
            // 
            this.timePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.timePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.timePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.timePicker.Dock = System.Windows.Forms.DockStyle.Left;
            this.timePicker.Location = new System.Drawing.Point(0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(485, 35);
            this.timePicker.TabIndex = 11;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDate.Location = new System.Drawing.Point(0, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(62, 30);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 30);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Create Show";
            // 
            // CreateShowPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backgroundPanel);
            this.Name = "CreateShowPage";
            this.Size = new System.Drawing.Size(867, 528);
            this.Load += new System.EventHandler(this.CreateShowPage_Load);
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            this.datePickePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnCreateShow;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.Label lblRoomId;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.Label lblMovieId;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox comboDub;
        private System.Windows.Forms.Label lblDubLanguage;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.ComboBox comboSubtitles;
        private System.Windows.Forms.ComboBox comboSound;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.ComboBox comboGraphic;
        private System.Windows.Forms.Label lblGraphic;
        private System.Windows.Forms.Panel datePickePanel;
        private System.Windows.Forms.DateTimePicker timePicker;
    }
}
