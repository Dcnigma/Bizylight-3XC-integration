using BusylightTester;
using System;
using System.Windows.Forms;
using MyPhonePlugins;
using System.Reflection;

namespace MyCRMPlugins
{
    [CRMPluginLoader]
    public class MyCrmPlugin
    {
        private static MyCrmPlugin _instance;
        private static IMyPhoneCallHandler _callHandler;
       // disabled because not used
       // private Busylight.SDK busylight = null;

        [CRMPluginInitializer]
       
 
        public static void Loader(IMyPhoneCallHandler callHandler)
        {
        //show busylight Mainform Disabled in final version
            frmMain frm = new frmMain();
         //   frm.Show();
            _instance = new MyCrmPlugin(callHandler);
         //start busylight Green on load
         frm.busylight.Light(Busylight.BusylightColor.Green);
          // Test button click another form
          //  frm.btnRedWithSound_Click(null, EventArgs.Empty);      
        }

        public MyCrmPlugin(IMyPhoneCallHandler callHandler)
        {
            _callHandler = callHandler;
            _callHandler.OnCallStatusChanged += CallHandlerOnOnCallStatusChanged;
            _callHandler.OnMyPhoneStatusChanged += CallHandlerOnOnMyPhoneStatusChanged;
        }


        public void CallHandlerOnOnCallStatusChanged(object sender, CallStatus callInfo)
        {
            if (callInfo.State == CallState.Connected)
            {
                frmMain frm = new frmMain();
                frm.busylight.Light(Busylight.BusylightColor.Red);
            }
            else if (callInfo.State == CallState.Ringing)
            {
                frmMain frm = new frmMain();
                // Blue Light (Working)
                //frm.busylight.Light(Busylight.BusylightColor.Blue);

                // Blink Red Light  (non working)

                // Busylight.PulseSequence ps = Busylight.PulseSequence.Standard;
                // ps.Color = Busylight.BusylightColor.Red;
                // busylight.Pulse(ps);
                //frm.btnRBFlash_Click(null, EventArgs.Empty);

                // Blink Red Light and Play sound (non working)
                //Busylight.BusylightVolume vol = Busylight.BusylightVolume.Max;
                //busylight.Alert(Busylight.BusylightColor.Red, Busylight.BusylightSoundClip.KuandoTrain, vol);
                frm.btnRedWithSound_Click(null, EventArgs.Empty);
            }
            else if (callInfo.State == CallState.Ended)
            {
                frmMain frm = new frmMain();
                frm.busylight.Light(Busylight.BusylightColor.Green);
              
            }
            else if (callInfo.State == CallState.Dialing)
            {
                frmMain frm = new frmMain();
                frm.busylight.Light(Busylight.BusylightColor.Yellow);
            }
        }
        private void CallHandlerOnOnMyPhoneStatusChanged(object sender, MyPhoneStatus Status)
        {
        }
        public CallStatus MakeCall(string destination)
        {
            frmMain frm = new frmMain();
            frm.busylight.Light(Busylight.BusylightColor.Red);
            return _callHandler.MakeCall(destination);
        }

    }
}
