using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyPhonePlugins;
using Busylight;
using Microsoft.Win32;
using MyCRMPlugin.Properties;
using System.Diagnostics;
using System.Management;
using MyCRMPlugins;

namespace BusylightTester
{

    public partial class frmMain : Form

    {
        // private static frmMain instance = null;
        internal Busylight.SDK busylight = null;


        public frmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            busylight = new Busylight.SDK();


            cmbSensivity.Items.Clear();
            cmbSensivity.Items.Add(new KeyValuePair<string, byte>("1", 0));
            cmbSensivity.Items.Add(new KeyValuePair<string, byte>("2", 2));
            cmbSensivity.Items.Add(new KeyValuePair<string, byte>("3", 4));
            cmbSensivity.Items.Add(new KeyValuePair<string, byte>("4", 8));
            cmbSensivity.Items.Add(new KeyValuePair<string, byte>("5", 16));
            cmbSensivity.SelectedItem = cmbSensivity.Items[2];

            cmbTimeout.Items.Clear();
            for (byte i = 3; i <= 20; i++)
            {
                cmbTimeout.Items.Add(new KeyValuePair<string, byte>(i.ToString(), i));
            }
            cmbTimeout.SelectedItem = cmbTimeout.Items[1];

            cmbTriggertime.Items.Clear();
            cmbTriggertime.Items.Add(new KeyValuePair<string, byte>("1", 85));
            cmbTriggertime.Items.Add(new KeyValuePair<string, byte>("2", 126));
            cmbTriggertime.Items.Add(new KeyValuePair<string, byte>("3", 167));
            cmbTriggertime.Items.Add(new KeyValuePair<string, byte>("4", 208));
            cmbTriggertime.Items.Add(new KeyValuePair<string, byte>("5", 250));
            cmbTriggertime.SelectedItem = cmbTriggertime.Items[0];

           // this.Text = "Testje" + busylight.Version;

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {

            busylight.BusyLightChanged += busylight_BusyLightChanged;
            busylight.KuandoBoxActivityDetected += busylight_KuandoBoxActivityDetected;
            FillListBox();
        }

        void busylight_KuandoBoxActivityDetected(bool obj)
        {
            if (obj)
            {
                pbColor.BackColor = Color.Green;
            }
            else
            {
                pbColor.BackColor = Color.LimeGreen;
            }
        }

        void busylight_BusyLightChanged(object sender, EventArgs e)
        {
            FillListBox();
        }

        void FillListBox()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    FillListBox();
                });
                return;
            }
            else
            {
                bool inputsupported = false;
                listBox1.Items.Clear();
                var list = busylight.GetAttachedBusylightDeviceList();
                foreach (var s in list)
                {
                    listBox1.Items.Add(s.ProductID + "  " + s.USBID + " " + s.FirmwareRelease + " " + "test");
                    if (s.IsInputEventSupported)
                    {
                        inputsupported = true;
                    }
                }
                pnlKuandoBox.Visible = inputsupported;
            }
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            busylight.Light(Busylight.BusylightColor.Green);
        }

        internal void btnRedWithSound_Click(object sender, EventArgs e)
        {

            Busylight.BusylightVolume vol = (Busylight.BusylightVolume)tbVolume.Value;
            busylight.Alert(Busylight.BusylightColor.Red, Busylight.BusylightSoundClip.KuandoTrain, vol);
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            busylight.Terminate();
        }

        private void btnPulse_Click(object sender, EventArgs e)
        {
            /*
            Busylight.PulseSequence ps = new Busylight.PulseSequence
            {
                Color = Busylight.BusylightColor.Yellow,
                Step1 = 3,
                Step2 = 21,
                Step3 = 36,
                Step4 = 50,
                Step5 = 36,
                Step6 = 21,
                Step7 = 10,
                //Step8 = 21
            };*/

            Busylight.PulseSequence ps = Busylight.PulseSequence.Standard;
            ps.Color = Busylight.BusylightColor.Green;
            busylight.Pulse(ps);

            //busylight.Pulse(Busylight.BusylightColor.Green);
        }

        private void cmbSensivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (busylight != null)
            {
                busylight.DPI_Sensivity = ((KeyValuePair<string, byte>)cmbSensivity.SelectedItem).Value;
            }
        }

        private void cmbTimeout_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (busylight != null)
            {
                busylight.DPI_Timeout = ((KeyValuePair<string, byte>)cmbTimeout.SelectedItem).Value;
            }
        }

        private void cmbTriggertime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (busylight != null)
            {
                busylight.DPI_Triggertime = ((KeyValuePair<string, byte>)cmbTriggertime.SelectedItem).Value;
            }
        }

        private void btnJingle_Click(object sender, EventArgs e)
        {
            if (busylight != null)
            {
                Busylight.BusylightVolume vol = (Busylight.BusylightVolume)tbVolume.Value;
                busylight.Jingle(Busylight.BusylightColor.Yellow, Busylight.BusylightJingleClip.IM1, vol);
            }
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            frmCustom frcu = new frmCustom(this);
            frcu.Show();
        }

        private void btnJingle2_Click(object sender, EventArgs e)
        {
            if (busylight != null)
            {
                Busylight.BusylightVolume vol = (Busylight.BusylightVolume)tbVolume.Value;
                busylight.Jingle(Busylight.BusylightColor.Yellow, Busylight.BusylightJingleClip.IM2, vol);
            }
        }

        private void btnGBFlash_Click(object sender, EventArgs e)
        {
            if (busylight != null)
            {
                busylight.ColorWithFlash(Busylight.BusylightColor.Green, Busylight.BusylightColor.Blue);
            }
        }

        private void btnRBFlash_Click(object sender, EventArgs e)
        {
            if (busylight != null)
            {
                busylight.ColorWithFlash(Busylight.BusylightColor.Red, Busylight.BusylightColor.Blue);
            }
        }

        private void btnYBFlash_Click(object sender, EventArgs e)
        {
            if (busylight != null)
            {
                busylight.Blink(Busylight.BusylightColor.Red, 5, 5); // 500ms on, 500ms of -> 1Hz)
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
