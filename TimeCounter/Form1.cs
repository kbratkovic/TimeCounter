using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.ComponentModel;

namespace TimeCounter
{
    public partial class Form1 : Form
    {
        private int totalSeconds;
        SoundPlayer player = new SoundPlayer(Properties.Resources.alert);

        public Form1()
        {
            InitializeComponent();
            buttonStop.Enabled = false;

            for (int i = 0; i < 60; i++)
            {
                inputMinutes.Items.Add(i.ToString());
                inputSeconds.Items.Add(i.ToString());
            }

            inputMinutes.SelectedIndex = 5;
            inputSeconds.SelectedIndex = 4;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelOutput.Visible = true;

            buttonStart.Enabled = false;
            buttonStop.Enabled = true;

            int minutes = int.Parse(inputMinutes.SelectedItem.ToString());
            int seconds = int.Parse(inputSeconds.SelectedItem.ToString());
            totalSeconds = (minutes * 60) + seconds;


            if (minutes < 10 && seconds >= 10)
                labelOutput.Text = '0' + minutes.ToString() + ':' + seconds.ToString();
            else if (minutes >= 10 && seconds < 10)
                labelOutput.Text = minutes.ToString() + ':' + '0' + seconds.ToString();
            else if (minutes >= 10 && seconds >= 10)
                labelOutput.Text = minutes.ToString() + ':' + seconds.ToString();
            else
                labelOutput.Text = '0' + minutes.ToString() + ':' + '0' + seconds.ToString();

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds - (minutes * 60);

                if (minutes < 10 && seconds >= 10)
                    labelOutput.Text = '0' + minutes.ToString() + ':' + seconds.ToString();
                else if (minutes >= 10 && seconds < 10)
                    labelOutput.Text = minutes.ToString() + ':' + '0' + seconds.ToString();
                else if (minutes >= 10 && seconds >= 10)
                    labelOutput.Text = minutes.ToString() + ':' + seconds.ToString();
                else
                    labelOutput.Text = '0' + minutes.ToString() + ':' + '0' + seconds.ToString();

            if (minutes < 5 && (seconds % 2 != 0))
            { 
                labelOutput.ForeColor = Color.Gray;
                player.Play();
            }
            else
                labelOutput.ForeColor = Color.Black;
            }

            if (totalSeconds == 0)
            {
                player.Stop();
                timer1.Enabled = false;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            player.Stop();
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;

            labelOutput.Visible = false;
            inputMinutes.Visible = true;
            inputSeconds.Visible = true;

            totalSeconds = 0;
            timer1.Enabled = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (timer1.Enabled)
                e.Cancel = true;
            base.OnClosing(e);
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = false;

            if (checkBox.Checked)
                TopMost = true;            
        }
    }
}