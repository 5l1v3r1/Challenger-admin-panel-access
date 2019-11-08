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
using System.Diagnostics;

namespace Challenger_Network_Admin_Panel_Access
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WebClient webClient = new WebClient();
            if (!webClient.DownloadString("https://www.thechallenger346youtube.tk/version-83475837.html").Contains("1.0.0.1"))
            {
                if (MessageBox.Show("Looks like there is an update, would you like to download it?", "Challenger Network Admin Panel Access", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://www.thechallenger346youtube.tk/index.html");
                }
                else
                {
                    
                }
            }
            else
            {
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
            f1.Hide();
            f2.ShowDialog();
            f1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form3 f3 = new Form3();
            f1.Hide();
            f3.ShowDialog();
            f1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form4 f4 = new Form4();
            f1.Hide();
            f4.ShowDialog();
            f1.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox1 a1 = new AboutBox1();
            a1.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WebClient webClient = new WebClient();
            if (!webClient.DownloadString("https://www.thechallenger346youtube.tk/version-83475837.html").Contains("1.0.0.1"))
            {
                if (MessageBox.Show("Looks like there is an update, would you like to download it?", "Challenger Network Admin Panel Access", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://www.thechallenger346youtube.tk/index.html");
                }
                else
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Looks like you are up to date!", "Challenger Network Admin Panel Access");
            }
        }
    }
}
