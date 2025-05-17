using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class Notifylcon : Form
    {
        public Notifylcon()
        {
            InitializeComponent();
        }

        private void Notification_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon=SystemIcons.Application;
            notifyIcon1.BalloonTipIcon=ToolTipIcon.Warning;
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void notifyIcon1_BalloonTipShown(object sender, EventArgs e)
        {
            Form form = new frmMain();
            form.ShowDialog();
        }
    }
}
