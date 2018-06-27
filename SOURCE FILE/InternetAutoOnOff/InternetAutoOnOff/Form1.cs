using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Data.SqlClient;

namespace InternetAutoOnOff
{
    public partial class frmMain : Form
    {
        /*
         *  --- Auto Internet On/Off
         *  Developed by Sampath Tharanga
         *  Version 1.0.0
         *  Copyright 2018
         * 
         */

        Timer t = new Timer();

        int WIDTH = 300, HEIGHT = 300, secHAND = 140, minHAND = 110, hrHAND = 80;

        //center
        int cx, cy;

        Bitmap bmp;
        Graphics g;

        DateTime DisableTime, EnableTime;

        public frmMain()
        {
            InitializeComponent();
            timer1.Start();
            NetworkChange.NetworkAvailabilityChanged += AvailabilityChanged;
            CheckInternetConnectionStatus();
        }

        private void CheckInternetConnectionStatus()
        {
            bool con = NetworkInterface.GetIsNetworkAvailable();
            if(con == true)
            {
                //Notication Enable
                lblInternet.Text = "Internet Connected!";
                lblInternet.ForeColor = Color.ForestGreen;
            }
            else
            {
                lblInternet.Text = "Internet Disconnected!";
                lblInternet.ForeColor = Color.Red;
            }
        }

        public void AvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            if (e.IsAvailable)
                MessageBox.Show("Network connected!", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Network disconnected!", "Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            InternetConnect();
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            InternetDisconnect();
        }

        void InternetConnect()
        {
            try
            {
                //REFERENCES : https://www.codeproject.com/Questions/680643/How-to-connect-and-disconnect-internet-connection
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = "ipconfig";
                info.Arguments = "/renew"; // or /release if you want to disconnect
                info.WindowStyle = ProcessWindowStyle.Hidden;
                Process p = Process.Start(info);
                p.WaitForExit();

                //Notication Enable
                lblInternet.Text = "Internet Connected!";
                lblInternet.ForeColor = Color.ForestGreen;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //int Current time
            DateTime CurrentTime = Convert.ToDateTime(DateTime.Now.ToShortTimeString());

            if (CurrentTime == DisableTime)
                InternetDisconnect();

            if (CurrentTime == EnableTime)
                InternetConnect();
        }

        private void dtpEnable_MouseDown(object sender, MouseEventArgs e)
        {
            dtpEnable.CustomFormat = "HH:mm";
        }

        private void dtpDisable_MouseDown(object sender, MouseEventArgs e)
        {
            dtpDisable.CustomFormat = "HH:mm";
        }

        void InternetDisconnect()
        {
            try
            {
                //REFERENCES : https://www.codeproject.com/Questions/680643/How-to-connect-and-disconnect-internet-connection
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = "ipconfig";
                info.Arguments = "/release"; // or /release if you want to disconnect
                info.WindowStyle = ProcessWindowStyle.Hidden;
                Process p = Process.Start(info);
                p.WaitForExit();

                //Notification Disable
                lblInternet.Text = "Internet Disconnected!";
                lblInternet.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAutoDisable_Click(object sender, EventArgs e)
        {
            //Assign time
            DisableTime = Convert.ToDateTime(dtpDisable.Value.ToShortTimeString());
            MessageBox.Show(DisableTime.ToShortTimeString() + "\nDisconnected time set successful.", "Time set", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            //Assign time
            EnableTime = Convert.ToDateTime(dtpEnable.Value.ToShortTimeString());
            MessageBox.Show(EnableTime.ToShortTimeString() + "\nConnected time set successful.", "Time set", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //ANALOG CLOCK DESIGN 
        //REFERENCES : https://github.com/yusufshakeel/CSharp-Project/blob/master/src/AnalogClock/Form1.cs
        private void frmMain_Load(object sender, EventArgs e)
        {
            //create bitmap
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);

            //center
            cx = WIDTH / 2;
            cy = HEIGHT / 2;

            //backcolor
            this.BackColor = Color.White;

            //timer
            t.Interval = 1000;      //in millisecond
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            //create graphics
            g = Graphics.FromImage(bmp);

            //get time
            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;

            int[] handCoord = new int[2];

            //clear
            g.Clear(Color.White);

            //draw circle
            g.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, WIDTH, HEIGHT);

            //draw figure
            g.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
            g.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
            g.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(142, 282));
            g.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));

            //second hand
            handCoord = msCoord(ss, secHAND);
            g.DrawLine(new Pen(Color.Red, 1f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            //minute hand
            handCoord = msCoord(mm, minHAND);
            g.DrawLine(new Pen(Color.Black, 2f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            //hour hand
            handCoord = hrCoord(hh % 12, mm, hrHAND);
            g.DrawLine(new Pen(Color.Gray, 3f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            //load bmp in picturebox1
            pictureBox1.Image = bmp;

            //disp time
            this.Text = "INTERNET AUTO/ENABLE/DISABLE -  " + hh + ":" + mm + ":" + ss;

            //dispose
            g.Dispose();
        }

        //coord for minute and second hand
        private int[] msCoord(int val, int hlen)
        {
            int[] coord = new int[2];
            val *= 6;   //each minute and second make 6 degree

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        //coord for hour hand
        private int[] hrCoord(int hval, int mval, int hlen)
        {
            int[] coord = new int[2];

            //each hour makes 30 degree
            //each min makes 0.5 degree
            int val = (int)((hval * 30) + (mval * 0.5));

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }
    }
}
