using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gulyaev_AG_9
{
    public partial class Form1 : Form
    {
        ushort radius, cnt_streams, speed;
        int cnt_all = 0;
        int cnt = 0;
        int x_c, y_c;
        double area = 0;

        private void trackBarRadius_Scroll(object sender, EventArgs e)
        {
            labelRadiusValue.Text = trackBarRadius.Value.ToString();
            radius = Convert.ToUInt16(trackBarRadius.Value);
        }

        private void trackBarCnt_Scroll(object sender, EventArgs e)
        {
            labelCntValue.Text = trackBarCnt.Value.ToString();
            cnt_streams = Convert.ToUInt16(trackBarCnt.Value);
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            labelSpeedValue.Text = trackBarSpeed.Value.ToString();
            speed = Convert.ToUInt16(trackBarSpeed.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBarRadius_Scroll(sender, e);
            trackBarCnt_Scroll(sender, e);
            trackBarSpeed_Scroll(sender, e);
        }

        private void buttonArea_Click(object sender, EventArgs e)
        {
            area = radius * radius * 4 * cnt / cnt_all;
            MessageBox.Show("Площадь круга равна " + area);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            trackBarRadius.Enabled = false;
            trackBarCnt.Enabled = false;
            trackBarSpeed.Enabled = false;
            CreateGraphics().DrawRectangle(new Pen(Color.Black, 1), 1, 20, 2 * radius, 2 * radius);
            CreateGraphics().DrawEllipse(new Pen(Color.Black, 1), 1, 20, 2 * radius, 2 * radius);
            x_c = 1 + radius;
            y_c = 20 + radius;
            cnt_all = 200*cnt_streams;

            for (ushort i = 1; i <= cnt_streams; i++)
            {
                ThreadPool.QueueUserWorkItem(Count);
                Thread.Sleep(20);
            }
            //Thread.Sleep((230 - speed)*150);
            //labelArea.Text = (radius * radius * 4 * cnt / cnt_all).ToString();
        }

        private void Count(object o)
        {
            Random rnd = new Random();
            int R = rnd.Next(0, 255);
            int G = rnd.Next(0, 255);
            int B = rnd.Next(0, 255);

            for (int i = 1; i <= 200; i++)
            {
                int x = rnd.Next(1, 1 + 2 * radius);
                int y = rnd.Next(20, 20 + 2 * radius);
                if ((x - x_c) * (x - x_c) + (y - y_c) * (y - y_c) <= radius * radius) cnt++;
                CreateGraphics().DrawEllipse(new Pen(Color.FromArgb(R, G, B), 2), x, y, 2, 2);
                Thread.Sleep(220 - speed);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

    }
}
