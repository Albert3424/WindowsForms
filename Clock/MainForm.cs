﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Clock
{
    public partial class MainForm : Form
    {
        ChooseFontForm fontDialog = null;
        public MainForm()
        {
            InitializeComponent();
            labelTime.BackColor = Color.Black;
            labelTime.ForeColor = Color.Red;

            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);
            SetVisibility(false);

            cmShowConsole.Checked = true;
            fontDialog = new ChooseFontForm();
        }

        void SetVisibility(bool visible)
        {
            cbShowDate.Visible = visible;
            btnHideControls.Visible = visible;
            btnHideControls.Visible = visible;
            this.TransparencyKey = visible ? Color.Empty : this.BackColor;
            this.FormBorderStyle = visible ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
            this.ShowInTaskbar = visible;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString
                (
                "hh:mm:ss tt",
                System.Globalization.CultureInfo.InvariantCulture
                );
            if (cbShowDate.Checked)
            {
                labelTime.Text += "\n";
                labelTime.Text += DateTime.Now.ToString("yyyy.MM.dd");
            }
            if (cbShowWeekDay.Checked)
            {
                labelTime.Text += "\n";
                labelTime.Text += DateTime.Now.DayOfWeek;
            }
            notifyIcon.Text = labelTime.Text;
        }

        private void btnHideControls_Click(object sender, EventArgs e)
        {
            SetVisibility(cmShowControls.Checked = false);
        }

        private void labelTime_DoubleClick(object sender, EventArgs e)
        {
            SetVisibility(true);
        }

        private void cmTopmost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = cmTopmost.Checked;
        }

        private void cmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmShowDate_CheckedChanged(object sender, EventArgs e)
        {
            cbShowDate.Checked = cmShowDate.Checked;
        }

        private void cbShowDate_CheckedChanged(object sender, EventArgs e)
        {
            cmShowDate.Checked = cbShowDate.Checked;
        }

        private void cmShowWeekDay_CheckedChanged(object sender, EventArgs e)
        {
            cbShowWeekDay.Checked = cmShowWeekDay.Checked;
        }

        private void cbShowWeekDay_CheckedChanged(object sender, EventArgs e)
        {
            cmShowWeekDay.Checked = cbShowWeekDay.Checked;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if(!this.TopMost)
            {
                this.TopMost = true;
                this.TopMost = false;
            }
        }

        private void cmShowControls_CheckedChanged(object sender, EventArgs e)
        {
            SetVisibility(cmShowControls.Checked);
        }

        private void SetColor(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            switch ((sender as ToolStripMenuItem).Text)
            {
                case "Background color": dialog.Color = labelTime.BackColor; break;
                case "Foreground color": dialog.Color = labelTime.ForeColor; break;
            }
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                switch ((sender as ToolStripMenuItem).Text)
                {
                    case "Background color": labelTime.BackColor = dialog.Color; break;
                    case "Foreground color": labelTime.ForeColor = dialog.Color; break;
                }
            }
        }

        private void cmChooseFont_Click(object sender, EventArgs e)
        {
            if(fontDialog.ShowDialog() == DialogResult.OK)
                labelTime.Font = fontDialog.Font;
        }

        private void cmShowConsole_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Checked)
                AllocConsole();
            else
                FreeConsole();
        }
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();
    }
}
