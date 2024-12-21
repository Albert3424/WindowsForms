﻿
namespace Clock
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTime = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmShowControls = new System.Windows.Forms.ToolStripMenuItem();
            this.cmTopmost = new System.Windows.Forms.ToolStripMenuItem();
            this.showDateToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.cmShowDate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmShowWeekDay = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmColors = new System.Windows.Forms.ToolStripMenuItem();
            this.cmBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.cmForegroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cbShowDate = new System.Windows.Forms.CheckBox();
            this.btnHideControls = new System.Windows.Forms.Button();
            this.cbShowWeekDay = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmChooseFont = new System.Windows.Forms.ToolStripMenuItem();
            this.cmShowConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.ContextMenuStrip = this.contextMenu;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(13, 13);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(210, 51);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "labelTime";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmShowControls,
            this.cmTopmost,
            this.showDateToolStripMenuItem,
            this.cmShowDate,
            this.cmShowWeekDay,
            this.toolStripSeparator1,
            this.cmChooseFont,
            this.cmColors,
            this.toolStripSeparator2,
            this.cmExit,
            this.cmShowConsole});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(181, 220);
            // 
            // cmShowControls
            // 
            this.cmShowControls.CheckOnClick = true;
            this.cmShowControls.Name = "cmShowControls";
            this.cmShowControls.Size = new System.Drawing.Size(180, 22);
            this.cmShowControls.Text = "Show controls";
            this.cmShowControls.CheckedChanged += new System.EventHandler(this.cmShowControls_CheckedChanged);
            // 
            // cmTopmost
            // 
            this.cmTopmost.CheckOnClick = true;
            this.cmTopmost.Name = "cmTopmost";
            this.cmTopmost.Size = new System.Drawing.Size(180, 22);
            this.cmTopmost.Text = "Topmost";
            this.cmTopmost.CheckedChanged += new System.EventHandler(this.cmTopmost_CheckedChanged);
            // 
            // showDateToolStripMenuItem
            // 
            this.showDateToolStripMenuItem.Name = "showDateToolStripMenuItem";
            this.showDateToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // cmShowDate
            // 
            this.cmShowDate.CheckOnClick = true;
            this.cmShowDate.Name = "cmShowDate";
            this.cmShowDate.Size = new System.Drawing.Size(180, 22);
            this.cmShowDate.Text = "Show date";
            this.cmShowDate.CheckedChanged += new System.EventHandler(this.cmShowDate_CheckedChanged);
            // 
            // cmShowWeekDay
            // 
            this.cmShowWeekDay.CheckOnClick = true;
            this.cmShowWeekDay.Name = "cmShowWeekDay";
            this.cmShowWeekDay.Size = new System.Drawing.Size(180, 22);
            this.cmShowWeekDay.Text = "Show week day";
            this.cmShowWeekDay.CheckedChanged += new System.EventHandler(this.cmShowWeekDay_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // cmColors
            // 
            this.cmColors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmBackgroundColor,
            this.cmForegroundColor});
            this.cmColors.Name = "cmColors";
            this.cmColors.Size = new System.Drawing.Size(180, 22);
            this.cmColors.Text = "Colors";
            // 
            // cmBackgroundColor
            // 
            this.cmBackgroundColor.Name = "cmBackgroundColor";
            this.cmBackgroundColor.Size = new System.Drawing.Size(180, 22);
            this.cmBackgroundColor.Text = "Background color";
            this.cmBackgroundColor.Click += new System.EventHandler(this.SetColor);
            // 
            // cmForegroundColor
            // 
            this.cmForegroundColor.Name = "cmForegroundColor";
            this.cmForegroundColor.Size = new System.Drawing.Size(180, 22);
            this.cmForegroundColor.Text = "Foreground color";
            this.cmForegroundColor.Click += new System.EventHandler(this.SetColor);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // cmExit
            // 
            this.cmExit.Name = "cmExit";
            this.cmExit.Size = new System.Drawing.Size(180, 22);
            this.cmExit.Text = "Exit";
            this.cmExit.Click += new System.EventHandler(this.cmExit_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cbShowDate
            // 
            this.cbShowDate.AutoSize = true;
            this.cbShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowDate.Location = new System.Drawing.Point(22, 134);
            this.cbShowDate.Name = "cbShowDate";
            this.cbShowDate.Size = new System.Drawing.Size(176, 29);
            this.cbShowDate.TabIndex = 1;
            this.cbShowDate.Text = "Показать дату";
            this.cbShowDate.UseVisualStyleBackColor = true;
            this.cbShowDate.CheckedChanged += new System.EventHandler(this.cbShowDate_CheckedChanged);
            // 
            // btnHideControls
            // 
            this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHideControls.Location = new System.Drawing.Point(22, 217);
            this.btnHideControls.Name = "btnHideControls";
            this.btnHideControls.Size = new System.Drawing.Size(176, 46);
            this.btnHideControls.TabIndex = 2;
            this.btnHideControls.Text = "Hide Controls";
            this.btnHideControls.UseVisualStyleBackColor = true;
            this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
            // 
            // cbShowWeekDay
            // 
            this.cbShowWeekDay.AutoSize = true;
            this.cbShowWeekDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowWeekDay.Location = new System.Drawing.Point(22, 169);
            this.cbShowWeekDay.Name = "cbShowWeekDay";
            this.cbShowWeekDay.Size = new System.Drawing.Size(241, 29);
            this.cbShowWeekDay.TabIndex = 3;
            this.cbShowWeekDay.Text = "Показать день недели";
            this.cbShowWeekDay.UseVisualStyleBackColor = true;
            this.cbShowWeekDay.CheckedChanged += new System.EventHandler(this.cbShowWeekDay_CheckedChanged);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Colors";
            // 
            // cmChooseFont
            // 
            this.cmChooseFont.Name = "cmChooseFont";
            this.cmChooseFont.Size = new System.Drawing.Size(180, 22);
            this.cmChooseFont.Text = "Choose font";
            this.cmChooseFont.Click += new System.EventHandler(this.cmChooseFont_Click);
            // 
            // cmShowConsole
            // 
            this.cmShowConsole.CheckOnClick = true;
            this.cmShowConsole.Name = "cmShowConsole";
            this.cmShowConsole.Size = new System.Drawing.Size(180, 22);
            this.cmShowConsole.Text = "Show console";
            this.cmShowConsole.CheckedChanged += new System.EventHandler(this.cmShowConsole_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 296);
            this.Controls.Add(this.cbShowWeekDay);
            this.Controls.Add(this.btnHideControls);
            this.Controls.Add(this.cbShowDate);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Clock PV_319";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.CheckBox cbShowDate;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnHideControls;
        private System.Windows.Forms.CheckBox cbShowWeekDay;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem cmTopmost;
        private System.Windows.Forms.ToolStripSeparator showDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmShowDate;
        private System.Windows.Forms.ToolStripMenuItem cmShowWeekDay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmExit;
        private System.Windows.Forms.ToolStripMenuItem cmColors;
        private System.Windows.Forms.ToolStripMenuItem cmBackgroundColor;
        private System.Windows.Forms.ToolStripMenuItem cmForegroundColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmShowControls;
        private System.Windows.Forms.ToolStripMenuItem cmChooseFont;
        private System.Windows.Forms.ToolStripMenuItem cmShowConsole;
    }
}

