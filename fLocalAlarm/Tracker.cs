using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Media;

namespace fLocalAlarm
{
    public partial class Tracker
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            tracker = new Tracker();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(infoBox = new InfoBox());
        }

        public static InfoBox infoBox;
        public static Tracker tracker;

        static Color enemyCol = Color.FromArgb(150, 5, 5);
        static Color neutCol = Color.FromArgb(140, 140, 140);
        static Color corpCol = Color.FromArgb(25, 120, 25);
        static Color allyCol = Color.FromArgb(5, 35, 120);
        static Color friendCol = Color.FromArgb(45, 100, 200);
        static Color fleetCol = Color.FromArgb(120, 35, 180);

        Boolean running = false;
        Thread t;
        long ticks;
        int x, y, h;
        int enemy = 0;
        int neut = 0;
        int corp = 0;
        int ally = 0;
        int friend = 0;
        int fleet = 0;
        int unknown = 0;

        public Boolean enemyAlarm, neutAlarm;

        public Tracker()
        {
            updateSettings();
            t = new Thread(run);
            t.Start();
        }

        public void stop()
        {
            t.Abort();
        }

        private void run()
        {
            while (true)
            {
                if (running)
                {
                    int oldEnemy = enemy;
                    int oldNeut = neut;
                    enemy = 0;
                    neut = 0;
                    corp = 0;
                    ally = 0;
                    friend = 0;
                    fleet = 0;
                    unknown = 0;
                    Bitmap screen = getScreen(x, y, 10, (h * 18) + 10);
                    int tolerance = 20;
                    for (int i = 0; i < h; i++)
                    {
                        Color col1 = screen.GetPixel(0, (i * 18));
                        Color col2 = screen.GetPixel(8, (i * 18) + 8);
                        if (isCloseTo(col1, enemyCol, tolerance) && isCloseTo(col2, enemyCol, tolerance)) enemy++;
                        else if (isCloseTo(col1, neutCol, tolerance) && isCloseTo(col2, neutCol, tolerance)) neut++;
                        else if (isCloseTo(col1, corpCol, tolerance) && isCloseTo(col2, corpCol, tolerance)) corp++;
                        else if (isCloseTo(col1, allyCol, tolerance) && isCloseTo(col2, allyCol, tolerance)) ally++;
                        else if (isCloseTo(col1, friendCol, tolerance) && isCloseTo(col2, friendCol, tolerance)) friend++;
                        else if (isCloseTo(col1, fleetCol, tolerance) && isCloseTo(col2, fleetCol, tolerance)) fleet++;
                        else unknown++;
                    }
                    screen.Dispose();
                    if (neutAlarm && oldNeut > neut) new Thread(hand).Start();
                    else if (neutAlarm && oldNeut < neut) new Thread(beep).Start();
                    else if (enemyAlarm && oldEnemy > enemy) new Thread(hand).Start();
                    else if (enemyAlarm && oldEnemy < enemy) new Thread(beep).Start();
                    ticks++;
                    String output = "";
                    if (enemy > 0) output += ", Enemies: " + enemy;
                    if (neut > 0) output += ", Neut: " + neut;
                    if (corp > 0) output += ", Corp: " + corp;
                    if (ally > 0) output += ", Ally: " + ally;
                    if (friend > 0) output += " Friend: " + friend;
                    if (fleet > 0) output += " Fleet: " + fleet;
                    updateStatus("Running for " + ticks + " ticks" + output);
                }
                else
                {
                    updateStatus("Paused");
                }
                Thread.Sleep(500); // Sleep 0.5 seconds
            }
        }

        public bool isRunning()
        {
            return running;
        }

        public void setRunning(bool running)
        {
            this.running = running;
            if (running)
            {
                enemy = 0;
                neut = 0;
                corp = 0;
                ally = 0;
                friend = 0;
                fleet = 0;
                unknown = 0;
                updateStatus("Running for " + ticks + " ticks");
            }
        }

        private void updateStatus(String status)
        {
            if (infoBox == null) return;
            MethodInvoker mi = delegate()
            {
                infoBox.updateStatus("(fLocalAlarm) " + status);
            };
            infoBox.Invoke(mi);
        }

        public void updateSettings()
        {
            x = Properties.Settings.Default.x;
            y = Properties.Settings.Default.y;
            h = Properties.Settings.Default.h;
            enemyAlarm = Properties.Settings.Default.enemyAlarm;
            neutAlarm = Properties.Settings.Default.neutAlarm;
        }

        private static String getCategory(Color input)
        {
            if (isCloseTo(input, enemyCol, 10)) return "Enemy";
            if (isCloseTo(input, neutCol, 10)) return "Neut";
            if (isCloseTo(input, corpCol, 10)) return "Corp";
            if (isCloseTo(input, allyCol, 10)) return "Ally";
            if (isCloseTo(input, fleetCol, 10)) return "Fleet";
            return "Unknown";
        }

        private static Boolean isCloseTo(Color input, Color check, int tolerance)
        {
            if (input.R < check.R - tolerance || input.R > check.R + tolerance) return false;
            if (input.G < check.G - tolerance || input.G > check.G + tolerance) return false;
            if (input.B < check.B - tolerance || input.B > check.B + tolerance) return false;
            return true;
        }

        private static Bitmap getScreen(int x, int y, int width, int height)
        {
            Bitmap bmpScreenCapture = new Bitmap(width, height);
            Graphics p = Graphics.FromImage(bmpScreenCapture);
            p.CopyFromScreen(x, y, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
            return bmpScreenCapture;
        }

        public static void beep()
        {
            beep(10);
        }

        public static void hand()
        {
            hand(2);
        }

        public static void beep(int iterations) 
        {
            for (int i = 0; i < iterations; i++)
            {
                SystemSounds.Beep.Play();
                Thread.Sleep(200); // Sleep .2 sec.
            }
        }

        public static void hand(int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                SystemSounds.Hand.Play();
                Thread.Sleep(200); // Sleep .2 sec.
            }
        }

    }
}
