using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace Serial
{
    public partial class Form1: Form
    {
        int[]pins = new int[7];
        bool beabreitungsModus = false;
        static Thread readThread;
        public Form1()
        {
            InitializeComponent();
            GetPorts();
            pins[0] = Int16.Parse(nt1.Text);
            pins[1] = Int16.Parse(nt2.Text);
            pins[2] = Int16.Parse(nt3.Text);
            pins[3] = Int16.Parse(nt4.Text);
            pins[4] = Int16.Parse(nt5.Text);
            pins[5] = Int16.Parse(nt6.Text);
            pins[6] = Int16.Parse(nt7.Text);
        }

        private void ClickedPanel(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            string se = p.Name;
            if (p.BackColor == Color.DarkGray)
            {
                serialPort1.Write("HIGH:"+ pins[(int)se[5] - '0' -1] + "\n");
                p.BackColor = Color.Red;
            }
            else
            {
                serialPort1.Write("LOW:" + pins[(int)se[5] - '0' - 1] + "\n");
                p.BackColor = Color.DarkGray;
            }
        }

        public void GetPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            } 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConnectDisconnect_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.Open();
                ConnectDisconnect.Text = "Disconnect";
                readThread = new Thread(COM);
                readThread.Start();
            }
            else
            {
                serialPort1.Close();
                ConnectDisconnect.Text = "Connect";
            }

        }
        private void UpdateListBox(string e)
        {
            ListBox.Items.Add(e);
        }
        private void COM()
        {
            while (true)
            {
                try
                {
                    if (serialPort1.IsOpen && serialPort1.BytesToRead > 0)
                    {
                        string e = serialPort1.ReadLine();

                        this.Invoke((Action)(() => UpdateListBox(e)));

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fehler beim Lesen des Serial Ports: " + ex.Message);
                    break; 
                }
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!beabreitungsModus)
            {
                beabreitungsModus = true;
                nt1.Visible = true;
                nt2.Visible = true;
                nt3.Visible = true;
                nt4.Visible = true;
                nt5.Visible = true;
                nt6.Visible = true;
                nt7.Visible = true;
            }
            else
            {
                beabreitungsModus = false;
                nt1.Visible = false;
                nt2.Visible = false;
                nt3.Visible = false;
                nt4.Visible = false;
                nt5.Visible = false;
                nt6.Visible = false;
                nt7.Visible = false;

                pins[0] = Int16.Parse(nt1.Text);
                pins[1] = Int16.Parse(nt2.Text);
                pins[2] = Int16.Parse(nt3.Text);
                pins[3] = Int16.Parse(nt4.Text);
                pins[4] = Int16.Parse(nt5.Text);
                pins[5] = Int16.Parse(nt6.Text);
                pins[6] = Int16.Parse(nt7.Text);

            }
        }

        private void nt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void nt6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
