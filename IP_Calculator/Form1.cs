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

namespace IP_Calculator
{
    public partial class Form1 : Form
    {
        private int oct1, //octet 1
                    oct2, //octet 2
                    oct3, //octet 3
                    oct4, //octet 4
                    mask, // netmask
                    subnet; // submask for subnet (can be calculated or not (depends if ckeckbox is...checked))
        private double hosts; //number of hosts
        const int bit = 32; 

        public Form1()
        {
            InitializeComponent();
            
        }

        //Method for validation of the first octet
        private void octet1_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(octet1.Text, out oct1) || oct1 < 0 || oct1 > 255)
            {
                e.Cancel = true;
                octet1.Focus();
                MessageBox.Show("The value must be numeric and be between 0 and 255!");
                errorProvider1.SetError(octet1, "The value should be between 0 and 255");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(octet1, "");
            }
        }

        //Method for validation of the second octet
        private void octet2_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(octet2.Text, out oct2) || oct2 < 0 || oct2 > 255 && octet2.TextLength == 0)
            {
                e.Cancel = true;
                octet2.Focus();
                MessageBox.Show("The value must be numeric and be between 0 and 255!");
                errorProvider1.SetError(octet2, "The value should be between 0 and 255");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(octet2, "");
            }
        }

        //Method for validation of the 3rd octet
        private void octet3_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(octet3.Text, out oct3) || oct3 < 0 || oct3 > 255 && octet3.TextLength == 0)
            {
                e.Cancel = true;
                octet3.Focus();
                MessageBox.Show("The value must be numeric and be between 0 and 255!");
                errorProvider1.SetError(octet3, "The value should be between 0 and 255");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(octet3, "");
            }
        }

        //Method for validation of the 4th octet
        private void octet4_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(octet4.Text, out oct4) || oct4 < 0 || oct4 > 255 && octet4.TextLength == 0)
            {
                e.Cancel = true;
                octet4.Focus();
                MessageBox.Show("The value must be numeric and be between 0 and 255!");
                errorProvider1.SetError(octet4, "The value should be between 0 and 255");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(octet4, "");
            }
        }

        //Method for validation of the netmask
        private void netmask_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(netmask.Text, out mask) || mask < 24 || mask > 31 && netmask.TextLength == 0)
            {
                e.Cancel = true;
                netmask.Focus();
                MessageBox.Show("The value must be numeric and be between 24 and 31!");
                errorProvider1.SetError(netmask, "The value should be between 24 and 31");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(netmask, "");
            }
        }

        //Method for validation of the subnet mask
        private void submask_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(submask.Text, out subnet) || subnet < 24 || subnet > 31 && submask.TextLength == 0)
            {
                e.Cancel = true;
                submask.Focus();
                MessageBox.Show("The value must be numeric and be between 24 and 31!");
                errorProvider1.SetError(submask, "The value should be between 24 and 31");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(submask, "");
            }
        }

        //By clicking on the Button, the information is shown in textbox + 
        // + if checkbox "calculate subnet" is checked - it will be calculated and also be displayed  
        private void button1_Click(object sender, EventArgs e)
        {
            Hosts();
            StringBuilder sb = new StringBuilder();
            sb.Append($"Address: {oct1}.{oct2}.{oct3}.{oct4} \r\n");
            sb.Append($"Netmask: {MaskCalculation()} \r\n");
            sb.Append($"Network: {oct1}.{oct2}.{oct3}.{oct4 - 1}/{mask} \r\n");
            sb.Append($"Broadcast: {oct1}.{oct2}.{oct3}.{hosts + 1} \r\n");
            sb.Append("\r\n" + Hosts() + "\r\n");
            if(subnet_check.Checked == true)
                sb.Append(Subnets());

            bigBox.Text = sb.ToString();
        }

        //Calculation of mask 
        private string MaskCalculation()
        {
            switch (mask)
            {
                case 24:
                    return "255.255.255.0 = 24";
                case 25:
                    return "255.255.255.128 = 25";
                case 26:
                    return "255.255.255.192 = 26";
                case 27:
                    return "255.255.255.224 = 27";
                case 28:
                    return "255.255.255.240 = 28";
                case 29:
                    return "255.255.255.248 = 29";
                case 30:
                    return "255.255.255.252 = 30";
                case 31:
                    return "255.255.255.254 = 31";
                case 32:
                    return "255.255.255.255 = 32";
                default:
                    return "Error";
            }
        }

        //method for calculating number of hosts, first and last one
        private string Hosts()
        {
            double bitOcc;
            bitOcc = bit - mask;
            double firstHost, lastHost;
            lastHost = Math.Pow(2, bitOcc);
            hosts = lastHost - 2;
            firstHost = lastHost - hosts - 1;
            return $"First host: {oct1}.{oct2}.{oct3}.{firstHost} \r\n" +
                   $"Last host: {oct1}.{oct2}.{oct3}.{hosts} \r\n" +
                   $"Hosts: {hosts} \r\n";
        }

        //Method for subnet calculating
        private string Subnets()
        {
            double subnets;
            double n;
            double bitOcc;
            bitOcc = bit - subnet;
            n = 8 - bitOcc;
            subnets = Math.Pow(2, n);
            return $"Subnets: {subnets} \r\n" +
                   $"{SubnetHosts(subnets)}";
        }

        //Calculating the number of hosts in each subnet
        private string SubnetHosts(double subnets)
        {
            double subnetHosts = hosts;
            int n = subnet - mask;
            double tmp = 2;
            double hostsInNetwork = 0;
            for (int i = 0; i < n; i++)
            {
                subnetHosts -= tmp;
                hostsInNetwork = subnetHosts / tmp;
                tmp *= 2;
            }
            return $"Hosts: {subnetHosts} \r\n" +
                   $"Hosts in each network: {hostsInNetwork}";
        }

        //If checkbox for subnet is checked, then the textbox for input apears. Otherwise it will remain hidden
        private void subnet_check_CheckedChanged(object sender, EventArgs e)
        {
            if (subnet_check.Checked)
            {
                submask.Visible = true;
                label10.Visible = true;
            }
            else
            {
                submask.Visible = false;
                label10.Visible = false;
            }
        }
    }
}
