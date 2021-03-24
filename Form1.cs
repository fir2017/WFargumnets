using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFargs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] args;
        public void writetheargsuments()
        {
            foreach (string s in args)
            {
                textBox1.Text += s + "\r\n";
            
            
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            args = Environment.GetCommandLineArgs();
            writetheargsuments();
        }
    }
}
