using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace NetflixServer
{
    public partial class Form1 : Form
    {
        const int screenSaverActiveFlag = 17;
        const int screenSaverUpdateProfile = 2;
        int screenSaverRetVal = 0;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool SystemParametersInfo(int uAction, int uParam, ref int lpvParam, int flags);

        public Form1()
        {
            InitializeComponent();
        }

        private void disable_Click(object sender, EventArgs e)
        {
            changeScreenSaver(0);
        }

        private void Enable_Click(object sender, EventArgs e)
        {
            changeScreenSaver(1);
        }

        private void changeScreenSaver(int state)
        {
            
            SystemParametersInfo(screenSaverActiveFlag, state, ref screenSaverRetVal, screenSaverUpdateProfile);
        }
    }
}
