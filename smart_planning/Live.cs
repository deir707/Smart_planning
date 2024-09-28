using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace smart_planning
{
    public partial class Live : Form
    {
        int value;
        public Live()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Pet_care().Show();
            this.Close();
        }

        private void Live_Load(object sender, EventArgs e)
        {
            String assist = Assistant.assist;
            if (assist == "Tom")
            {
                pictureBox1.Image = Image.FromFile(@"images\tom_small.png");
            }
            if (assist == "Carry")
            {
                pictureBox1.Image = Image.FromFile(@"images\carry_small.png");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            axWindowsMediaPlayer1.URL = @"video\doggy.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int time = value++;
            if (time == 1)
            {
                richTextBox1.Text = "Danny is quite so far.";
            }
            else if (time == 10)
            {
                richTextBox1.Text = "He has eaten all of his food and he is pacing all over the house, most of the time.";
            }
            else if (time == 30)
            {
                richTextBox1.Text = "Maybe it is a good idea for him to have another dog to play.";
            }
            else if (time == 60)
            {
                richTextBox1.Text = "Do you think is time to have a new pet?";
            }
            else if (time == 80)
            {
                richTextBox1.Text = "Now he is in the bedroom and is having a nap.";
            }
            else if (time == 110)
            {
                richTextBox1.Text = "He is up and is pacing again.";
            }
            else if (time == 130) 
            {
                richTextBox1.Text = "He is looking for something to play on.";
            }
            else if (time == 175)
            {
                richTextBox1.Text = "He is playing with his snake toy. But I think he wants something new.";
            }
            else if (time == 190)
            {
                richTextBox1.Text = "Again in the bedroom and waiting.";
            }
            else if (time >= 200)
            {
                richTextBox1.Text = "";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            timer1.Stop();
            richTextBox1.Text = "";
        }
    }
}
