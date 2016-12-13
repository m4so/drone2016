using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Hobbyking_4CH_WiFi
{
    public partial class Form1 : Form
    {

        int mouse_x = 0;
        int mouse_y = 0;
        bool mouse_down = false;
        int joy_x = 0;
        int joy_y = 0;

        int mouse_x2 = 0;
        int mouse_y2 = 0;
        bool mouse_down2 = false;
        int joy_x2 = 0;
        int joy_y2 = 0;


        TcpClient sock = new TcpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            mouse_x = 100;
            mouse_y = 180;
            joy_x = 100;
            joy_y = 0;


            mouse_x2 = 100;
            mouse_y2 = 100;
            joy_x2 = 100;
            joy_y2 = 100;

        }


        private void sendRawChannels(int ch1, int ch2, int ch3, int ch4)
        {
            byte[] buffer = new byte[11];

            //Header
            buffer[0] = 85;
            buffer[1] = 0;
            buffer[2] = 11;
            buffer[3] = 0;

            //Channels
            buffer[4] = (byte)(ch1 & 255);
            buffer[5] = (byte)(ch2 & 255);
            buffer[6] = (byte)(ch3 & 255);
            buffer[7] = (byte)(ch4 & 255);

            buffer[8] = 0;
            buffer[9] = 0;

            int sum = 0;
            for (int i = 0; i < 9; i++)
                sum += (int)buffer[i];

            buffer[10] = (byte)(sum % 256);

            sock.Client.Send(buffer);

        }

        private void panel_JoyStick_MouseDown(object sender, MouseEventArgs e)
        {
            if (mouse_down)
                return;
            
            mouse_x = e.X;
            mouse_y = e.Y;

            mouse_down = true;

            JoyStick();
        }


        private void panel_JoyStick_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_down = false;

            mouse_x = 100;

            JoyStick();
        }

        private void panel_JoyStick_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouse_down)
                return;
            
            mouse_x = e.X;
            mouse_y = e.Y;

            JoyStick();
        }

        private void JoyStick()
        {

            joy_x = mouse_x;
            joy_y = 200 + (0 - mouse_y);
            
            panel_JoyStick.Refresh();

            TXupdate();
        }




        private void panel_JoyStick_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Aquamarine);
            Pen pen = new Pen(Color.White);

            //e.Graphics.DrawPie(pen, new Rectangle(10, 10, 100, 100), 30.0f, 90.0f);

            //e.Graphics.RotateTransform(45.0f);

            e.Graphics.DrawArc(pen, new Rectangle(100 - 12, 100 - 12, 25, 25), 0.0f, 360.0f);

            e.Graphics.DrawLine(new Pen(Color.White, 10f), new Point(100, 100), new Point(mouse_x, mouse_y));

            e.Graphics.DrawArc(pen, new Rectangle(mouse_x - 25, mouse_y - 25, 50, 50), 0.0f, 360.0f);

            string s = joy_x.ToString() + " " + joy_y.ToString();

            e.Graphics.DrawString(s, this.Font, Brushes.Yellow, new PointF(10f, 10f));

            

        }


        private void panel_JoyStick2_MouseDown(object sender, MouseEventArgs e)
        {
            if (mouse_down2)
                return;

            mouse_x2 = e.X;
            mouse_y2 = e.Y;

            mouse_down2 = true;

            JoyStick2();
        }

        private void panel_JoyStick2_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_down2 = false;

            mouse_x2 = 100;
            mouse_y2 = 100;

            JoyStick2();
        }

        private void panel_JoyStick2_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouse_down2)
                return;

            mouse_x2 = e.X;
            mouse_y2 = e.Y;

            JoyStick2();
        }

        private void JoyStick2()
        {
            joy_x2 = mouse_x2;
            joy_y2 = 200 + (0 - mouse_y2);
                     
            panel_JoyStick2.Refresh();

            TXupdate();
        }

        private void panel_JoyStick2_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Aquamarine);
            Pen pen = new Pen(Color.White);


            e.Graphics.DrawArc(pen, new Rectangle(100 - 12, 100 - 12, 25, 25), 0.0f, 360.0f);

            e.Graphics.DrawLine(new Pen(Color.White, 10f), new Point(100, 100), new Point(mouse_x2, mouse_y2));

            e.Graphics.DrawArc(pen, new Rectangle(mouse_x2 - 25, mouse_y2 - 25, 50, 50), 0.0f, 360.0f);

            string s = joy_x2.ToString() + " " + joy_y2.ToString();

            e.Graphics.DrawString(s, this.Font, Brushes.Yellow, new PointF(10f, 10f));

            

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;

            if (!sock.Connected)
            {
                sock.Connect("10.10.100.254", 8899);
                btnConnect.Text = "Close";
                timerUpdate.Enabled = true;
            }
            else
            {
                timerUpdate.Enabled = false;
                sock.Close();
                btnConnect.Text = "Open";
            }

            btnConnect.Enabled = true;
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            TXupdate();
        }

        private void TXupdate()
        {
            //trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value

            int x = (joy_x  + (trackBar1.Value / 2)) / 2;
            int y = (joy_y + (trackBar2.Value / 2)) / 2;
            int x2 = (joy_x2 + (trackBar3.Value / 2)) / 2;
            int y2 = (joy_y2 + (trackBar4.Value / 2)) / 2;

            if (sock.Client.Connected)
                sendRawChannels(x, y, x2, y2);

        }

    }//Class
}
