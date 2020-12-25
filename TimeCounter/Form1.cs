using System;
using System.Windows.Forms;

namespace TimeCounter
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            buttonStop.Enabled = false;

            for (int i = 0; i < 60; i++)
            {
                inputMinutes.Items.Add(i.ToString());
                inputSeconds.Items.Add(i.ToString());
            }
        }

    }
}
