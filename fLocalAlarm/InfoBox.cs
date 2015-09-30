using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace fLocalAlarm
{
    public partial class InfoBox : Form
    {
        Boolean moving;
        int movingX, movingY;

        public InfoBox()
        {
            InitializeComponent();
            this.Opacity = 0.5;
            this.TopMost = true;
            onTopToolStripMenuItem.Checked = this.TopMost;
            this.SetDesktopLocation(100, 0);
            //Console.WriteLine(this.Height);


            enemyAlarmToolStripMenuItem.Checked = Tracker.tracker.enemyAlarm;
            neutralAlarmToolStripMenuItem.Checked = Tracker.tracker.neutAlarm;
        }

        public void updateStatus(String str)
        {
            status.Text = str;
        }

        private void startMoving(MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                moving = true;
                movingX = MousePosition.X - this.Location.X;
                movingY = MousePosition.Y - this.Location.Y;
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.ContextMenuStrip = contextMenu;
            }
        }

        private void stopMoving()
        {
            moving = false;
        }

        private void move()
        {
            if (moving)
            {
                this.SetDesktopLocation(MousePosition.X - movingX, MousePosition.Y - movingY);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Tracker.tracker.stop();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tracker.tracker.setRunning(!Tracker.tracker.isRunning());
            if (Tracker.tracker.isRunning()) startToolStripMenuItem.Text = "Stop";
            else startToolStripMenuItem.Text = "Start";
        }

        private void onTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            onTopToolStripMenuItem.Checked = this.TopMost;
        }

        private void enemyAlarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enemyAlarmToolStripMenuItem.Checked = !enemyAlarmToolStripMenuItem.Checked;
            Tracker.tracker.enemyAlarm = enemyAlarmToolStripMenuItem.Checked;
            Properties.Settings.Default.enemyAlarm = Tracker.tracker.enemyAlarm;
            Properties.Settings.Default.Save();
        }

        private void neutralAlarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            neutralAlarmToolStripMenuItem.Checked = !neutralAlarmToolStripMenuItem.Checked;
            Tracker.tracker.neutAlarm = neutralAlarmToolStripMenuItem.Checked;
            Properties.Settings.Default.neutAlarm = Tracker.tracker.neutAlarm;
            Properties.Settings.Default.Save();
        }

        private void advancedSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog(this);
            Tracker.tracker.updateSettings();
            enemyAlarmToolStripMenuItem.Checked = Tracker.tracker.enemyAlarm;
            neutralAlarmToolStripMenuItem.Checked = Tracker.tracker.neutAlarm;
        }

        private void testAlarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Thread(Tracker.beep).Start();
        }

        private void InfoBox_MouseDown(object sender, MouseEventArgs e)
        {
            startMoving(e);
        }

        private void InfoBox_MouseUp(object sender, MouseEventArgs e)
        {
            stopMoving();
        }

        private void InfoBox_MouseMove(object sender, MouseEventArgs e)
        {
            move();
        }

        private void status_MouseDown(object sender, MouseEventArgs e)
        {
            startMoving(e);
        }

        private void status_MouseUp(object sender, MouseEventArgs e)
        {
            stopMoving();
        }

        private void status_MouseMove(object sender, MouseEventArgs e)
        {
            move();
        }
    }
}
