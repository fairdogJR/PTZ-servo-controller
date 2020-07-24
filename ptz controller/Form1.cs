﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.Reflection;
using System.Runtime.Serialization.Formatters;

//references  and Todo
//serial port access
//https://web.archive.org/web/20130709121945/http://msmvps.com/blogs/coad/archive/2005/03/23/SerialPort-_2800_RS_2D00_232-Serial-COM-Port_2900_-in-C_2300_-.NET.aspx
//https://stackoverflow.com/questions/38123361/how-to-set-the-flow-control-of-serial-port
//
//better reference here
// https://create.arduino.cc/projecthub/whitebank/arduino-serial-communication-visual-studio-3f5c77
//http://www.blackwasp.co.uk/MouseWheel.aspx
//
//port flushing or getting stuck issue
//https://stackoverflow.com/questions/4739445/c-sharp-serial-port-flushing-for-small-data-chunks
//bytes to read is increasing, I thing nothing is reading them so I should read them and dump them
//this worked
// had to get relative mouse position
//essentially just got the actual location and store the old value and compare 
//I do see a larger offset then just 1 but I dont care as much
// compare old vs new if it is same do nothing , bigger move one way, smaller mover the other



namespace ptz_controller
{
    public partial class Form1 : Form
    {
        // Instantiate the communications
        // port with some basic settings
        SerialPort port = new SerialPort(
          "COM5", 57600);
        int _totalDelta = 0;
        int _scaledDelta = 0;
        int oldxvalue = 0;
        int newxvalue = 0;
        int difference = 0;
        public Form1()
        {
            InitializeComponent();
            this.MouseWheel += Form_MouseWheel;

        }

        private void Form_MouseWheel(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
            _totalDelta = _totalDelta + e.Delta;
            DeltaLabel.Text = e.Delta.ToString();
            _scaledDelta = e.Delta / 120;
            TotalDeltaLabel.Text = _scaledDelta.ToString();
            if (_scaledDelta>0)
                    { port.Write("w");
            }
            if (_scaledDelta < 0)
            {
                port.Write("s");
            }
 
            Console.WriteLine(port.BytesToWrite);
            Console.WriteLine(port.BytesToRead);
            int count = port.BytesToRead;
            byte[] data = new byte[count];
            rcvbuf.Text=(port.Read(data, 0, data.Length)).ToString();

            Console.WriteLine(port.BytesToRead);
            Console.WriteLine(" ");
        }

        private void Flush_Reads ()
        {
            //Required or read buffer fills and nothing else CancelButton happen
            Console.WriteLine(port.BytesToWrite);
            Console.WriteLine(port.BytesToRead);
            int count = port.BytesToRead;
            byte[] data = new byte[count];
            rcvbuf.Text = (port.Read(data, 0, data.Length)).ToString();

            Console.WriteLine(port.BytesToRead);
            Console.WriteLine(" ");
        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Open the port for communications
            port.Open();
            port.DiscardInBuffer();
            port.DiscardOutBuffer();
            port.DtrEnable = true;
            port.RtsEnable = true;
            //port.Handshake = Handshake.XOnXOff;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Write a string
            //not working sn
            port.Write("q");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            port.Write("e");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close the port
            port.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Up_Click(object sender, EventArgs e)
        {
            port.Write("w");
        }

        private void down_Click(object sender, EventArgs e)
        {
            port.Write("s");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rcvbuf_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Console.WriteLine( e.Location);
            newxvalue = e.Location.X;
            difference = newxvalue - oldxvalue;
            Console.WriteLine(difference);
            oldxvalue = newxvalue;

            if (port.IsOpen)
            {

                if (difference > 0)
                {
                    port.Write("a");
                }
                if (difference < 0)
                {
                    port.Write("d");
                }
                Flush_Reads();
            }
           
        }
    }
}