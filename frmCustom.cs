using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Busylight;

namespace BusylightTester
{
    public partial class frmCustom : Form
    {
        frmMain _parent = null;

        public frmCustom(frmMain parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void ShowColor()
        {
            BusylightColor color = new BusylightColor();
            color.BlueRgbValue = tbBlue.Value;
            color.RedRgbValue = tbRed.Value;
            color.GreenRgbValue = tbGreen.Value;
            _parent.busylight.Light(color);
        }

        private void tbRed_Scroll(object sender, EventArgs e)
        {
            txtRed.Text = tbRed.Value.ToString();
            ShowColor();
        }

        private void txtRed_TextChanged(object sender, EventArgs e)
        {
            int i = tbRed.Value;

            if (Int32.TryParse(txtRed.Text, out i))
            {
                tbRed.Value = i;
            }
            ShowColor();
        }

        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            txtGreen.Text = tbGreen.Value.ToString();
            ShowColor();
        }

        private void txtGreen_TextChanged(object sender, EventArgs e)
        {
            int i = tbGreen.Value;
            if (Int32.TryParse(txtGreen.Text, out i))
            {
                tbGreen.Value = i;
            }
            ShowColor();
        }

        private void tbBlue_Scroll(object sender, EventArgs e)
        {
            txtBlue.Text = tbBlue.Value.ToString();
            ShowColor();
        }

        private void txtBlue_TextChanged(object sender, EventArgs e)
        {
            int i = tbBlue.Value;
            if (Int32.TryParse(txtBlue.Text, out i))
            {
                tbBlue.Value = i;
            }
            ShowColor();
        }

        private void frmCustom_FormClosing(object sender, FormClosingEventArgs e)
        {
            BusylightColor color = new BusylightColor();
            color.BlueRgbValue = 0;
            color.RedRgbValue = 0;
            color.GreenRgbValue = 0;
            _parent.busylight.Light(color);
        }

        private void frmCustom_Shown(object sender, EventArgs e)
        {
            ShowColor();
        }


    }
}
