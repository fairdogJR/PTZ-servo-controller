using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
//using System.Reflection;
//using System.Runtime.Serialization.Formatters;

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
//
//Issue with servos moving on startup (not really desired) this is discussed in this article
//there is no easy solution with a servo when there is no position feedback availble to the arduino
// if it was not at reset poition when shutting down its going to move
//pointed out in this article if you have a load attached and the server moves quickly , this can be an issue
//
//https://forum.arduino.cc/index.php?topic=65855.0
//9600 baud seems more stable
//turns out decoupling was not strong enough. i added to both the power at each motor ribbon connect 100uF and 400Uf on one and also small cap on data line as it was noisy
//reading data back from the serial can be tricky (I want to read the final positions from the arduino, this is a serial stream. I sdont need all the data just be able to read and maybe stor a position when learning a position
//https://stackoverflow.com/questions/44378327/read-all-buffer-data-from-serial-port-with-c-sharp


namespace ptz_controller
{

    public partial class Form1 : Form
    {
        const string portname = "COM5";
        const int baudrate = 57600;

        // Instantiate the communications
        // port with some basic settings
        SerialPort port = new SerialPort(
          portname, baudrate);
        int _totalDelta = 0;
        int _scaledDelta = 0;
        int oldxvalue = 0;
        int newxvalue = 0;
        int differencex = 0;
        int differencey = 0;
        int newyvalue = 0;
        int oldyvalue = 0;
        
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
                    { port.Write("t\n");
            }
            if (_scaledDelta < 0)
            {
                port.Write("g\n");
            }

            Flush_Reads();
        }

        private void Flush_Reads ()
        {
            //Required for getting data feedback from Arduino on servo present positions
            //this may get more sets of data than expected but the last data position will be caught
            //this can be used when learning favorite axis positions and setting as presets
            int bytestoread = 0;
            try
            {
                bytestoread = port.BytesToRead;
            }

            catch (InvalidOperationException ex)
            {
//good luck
            }

            if (port.IsOpen)
            {
                if (bytestoread != 0)
                {

                    byte[] temp = new byte[bytestoread];

                    if (port.IsOpen)
                        port.Read(temp, 0, bytestoread);

                    rcvbuf.Text = (Encoding.Default.GetString(temp));

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Open the port for communications
            port.Open();
            portinfo.Text = portname +" "+ baudrate.ToString();
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
            port.Write("q\n");
            Flush_Reads();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            port.Write("e\n");
            Flush_Reads();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close the port
            port.Close();
            portinfo.Text = "port closed";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Up_Click(object sender, EventArgs e)
        {
            port.Write("s\n");
            Flush_Reads();
        }

        private void down_Click(object sender, EventArgs e)
        {
            port.Write("w\n");
            Flush_Reads();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rcvbuf_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {

                //Console.WriteLine( e.Location);
                newxvalue = e.Location.X;
                differencex = newxvalue - oldxvalue;
                //Console.WriteLine(differencex);
                oldxvalue = newxvalue;

                newyvalue = e.Location.Y;
                differencey = newyvalue - oldyvalue;
                // Console.WriteLine(differencey);
                oldyvalue = newyvalue;

                if (port.IsOpen)
                {

                    if (differencex > 0)
                    {
                        port.Write("a\n");
                    }
                    if (differencex < 0)
                    {
                        port.Write("d\n");
                    }

                    if (differencey > 0)
                    {
                        port.Write("w\n");
                    }
                    if (differencey < 0)
                    {
                        port.Write("s\n");
                    }
                    x_position.Text = newxvalue.ToString();
                    Flush_Reads();

                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void fave1_Click_2(object sender, EventArgs e)
        {

        }

        private void fave2_Click(object sender, EventArgs e)
        {

        }

        private void store1_Click(object sender, EventArgs e)
        {
            fave1.Text = rcvbuf.Text;
        }

        private void store2_Click(object sender, EventArgs e)
        {
            fave2.Text = rcvbuf.Text;
        }

        private void store3_Click(object sender, EventArgs e)
        {
            fave3.Text = rcvbuf.Text;
        }

        private void store4_Click(object sender, EventArgs e)
        {
            fave4.Text = rcvbuf.Text;
        }

        private void portinfo_Click(object sender, EventArgs e)
        {

        }

        private void motorPositions_Click(object sender, EventArgs e)
        {
            port.Write("get_motor_positions\n");
            Flush_Reads(); //should rename this function later
        }

        private void preset1_Click(object sender, EventArgs e)
        {
            port.Write("set_motor_positions 117 45 107\n");
            Flush_Reads(); //should rename this function later
        }

        private void preset2_Click(object sender, EventArgs e)
        {
            port.Write("set_motor_positions 117 45 107\n");
            Flush_Reads(); //should rename this function later
        }

        private void preset3_Click(object sender, EventArgs e)
        {
            port.Write("set_motor_positions 117 45 107\n");
            Flush_Reads(); //should rename this function later
        }

        private void preset4_Click(object sender, EventArgs e)
        {
            port.Write("set_motor_positions 117 45 107\n");
            Flush_Reads(); //should rename this function later
        }

        private void upfaster_Click(object sender, EventArgs e)
        {
            port.Write("s\n");
            port.Write("s\n");
            port.Write("s\n");
            port.Write("s\n");
            port.Write("s\n");
            port.Write("s\n");
            port.Write("s\n");
            port.Write("s\n");
            port.Write("s\n");
            port.Write("s\n");

            Flush_Reads();
        }

        private void downfaster_Click(object sender, EventArgs e)
        {
            port.Write("w\n");
            port.Write("w\n");
            port.Write("w\n");
            port.Write("w\n");
            port.Write("w\n");
            port.Write("w\n");
            port.Write("w\n");
            port.Write("w\n");
            port.Write("w\n");
            port.Write("w\n");

            Flush_Reads();
        }

        private void left_Click(object sender, EventArgs e)
        {
            port.Write("a\n");
            Flush_Reads();
        }

        private void right_Click(object sender, EventArgs e)
        {
            port.Write("a\n");
            Flush_Reads();
        }

        private void leftfaster_Click(object sender, EventArgs e)
        {
            port.Write("a\n");
            port.Write("a\n");
            port.Write("a\n");
            port.Write("a\n");
            port.Write("a\n");
            port.Write("a\n");
            port.Write("a\n");
            port.Write("a\n");
            port.Write("a\n");
            port.Write("a\n");

            Flush_Reads();
        }

        private void rightfaster_Click(object sender, EventArgs e)
        {
            port.Write("d\n");
            port.Write("d\n");
            port.Write("d\n");
            port.Write("d\n");
            port.Write("d\n");
            port.Write("d\n");
            port.Write("d\n");
            port.Write("d\n");
            port.Write("d\n");
            port.Write("d\n");

            Flush_Reads();
        }

        private void wristupfaster_Click(object sender, EventArgs e)
        {
            port.Write("t\n");
            port.Write("t\n");
            port.Write("t\n");
            port.Write("t\n");
            port.Write("t\n");
            port.Write("t\n");
            port.Write("t\n");
            port.Write("t\n");
            port.Write("t\n");
            port.Write("t\n");
            Flush_Reads();
        }

        private void wristup_Click(object sender, EventArgs e)
        {
            port.Write("t\n");
            Flush_Reads();
        }

        private void wristdown_Click(object sender, EventArgs e)
        {
            port.Write("g\n");
            Flush_Reads();
        }

        private void wristdownfaster_Click(object sender, EventArgs e)
        {
            port.Write("g\n");
            port.Write("g\n");
            port.Write("g\n");
            port.Write("g\n");
            port.Write("g\n");
            port.Write("g\n");
            port.Write("g\n");
            port.Write("g\n");
            port.Write("g\n");
            port.Write("g\n");
            Flush_Reads();
        }
    }
}
