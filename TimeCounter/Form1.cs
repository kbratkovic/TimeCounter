using System;
using System.Windows.Forms;

namespace TimeCounter
{
    public partial class Form1 : Form
    {
        private int totalSeconds;

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

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelOutput.Visible = true;

            buttonStart.Enabled = false;
            buttonStop.Enabled = true;

            int minutes = int.Parse(inputMinutes.SelectedItem.ToString());
            int seconds = int.Parse(inputSeconds.SelectedItem.ToString());
            totalSeconds = (minutes * 60) + seconds;

            timer1.Enabled = true;
        }

    }
}
