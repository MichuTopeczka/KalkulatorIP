using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;


namespace kalkulator_ip
{
    public partial class Form1 : Form
    {
        static Regex rgx = new Regex(@"(^|\.)0+(?!\.|$)", RegexOptions.Compiled);
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CalculateIP(object sender, EventArgs e) {
            String ipString = IPBox.Text;
           ipString =  rgx.Replace(ipString, ".");

            IPAddress ipAddress = IPAddress.Parse(ipString);
            IPAddress maskAddress = IPAddress.Parse(MaskaTextBox.Text);
            byte[] ip = ipAddress.GetAddressBytes();
            byte[] mask = maskAddress.GetAddressBytes();
            byte[] reversedMask = maskAddress.GetAddressBytes();
            byte[] network = new byte[4];
            byte[] broadcast = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                network[i] = (byte)(ip[i] & mask[i]);
                reversedMask[i] = (byte)~mask[i];
                broadcast[i] = (byte)(network[i] | reversedMask[i]);
                   
            }
            string networkAddressString = "";
            string broadbastAddressString = "";
            for (int i = 0; i < 4; i++) {
                //network
                String ipFragment = network[i].ToString();
                ipFragment = ipFragment.PadLeft(3, '0');
               networkAddressString += ipFragment;
                //rozgloszeniowy
               ipFragment = broadcast[i].ToString();
                ipFragment = ipFragment.PadLeft(3, '0');
                broadbastAddressString += ipFragment;
            }
            networkAddressTextBox.Text = networkAddressString;
            BroadcastTextBox.Text = broadbastAddressString;
        }
         private void button1_Click(object sender, EventArgs e)
        {
            byte[] ipAddress = new byte[4];
            ipAddress[0] = (byte)ipOktet1.Value;
            ipAddress[1] = (byte)ipOktet2.Value;
            ipAddress[2] = (byte)ipOktet3.Value;
            ipAddress[3] = (byte)ipOktet4.Value;
            IPAddress ip = new IPAddress(ipAddress);
            IPNetwork network = IPNetwork.Parse(ip.ToString(), (byte)cidrText.Value);
            IPBox.Text = network.Value;
            MaskaTextBox.Text = network.Netmask.ToString();
            networkAddressTextBox.Text = network.Network.ToString();
            BroadcastTextBox.Text = network.Broadcast.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            byte[] ipAddress = new byte[4];
            ipAddress[0] = (byte)ipOktet1.Value;
            ipAddress[1] = (byte)ipOktet2.Value;
            ipAddress[2] = (byte)ipOktet3.Value;
            ipAddress[3] = (byte)ipOktet4.Value;
            IPAddress ip = new IPAddress(ipAddress);
            IPNetwork network = IPNetwork.Parse(ip.ToString(), (byte)cidrText.Value);
            IPBox.Text = network.Value;
            MaskaTextBox.Text = network.Netmask.ToString();
            networkAddressTextBox.Text = network.Network.ToString();
            BroadcastTextBox.Text = network.Broadcast.ToString();
        }
    }
}
