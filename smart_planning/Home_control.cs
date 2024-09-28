using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smart_planning
{
    public partial class Home_control : Form
    {
        Boolean alarm = false;
        Boolean robot_on = false;
        public Home_control()
        {
            InitializeComponent();
        }

        private void Home_control_Load(object sender, EventArgs e)
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
            button2.Image = Image.FromFile(@"images\alarm_off.png");
            button6.Image = Image.FromFile(@"images\robotic_vacuum_cleaner_off.png");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Main_menu().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (alarm == false)
            {
                alarm = true;
                SoundPlayer player = new SoundPlayer(@"sound\security_alarm.wav");
                player.Play();
                button2.Image = Image.FromFile(@"images\alarm_on.png");
                richTextBox1.Text = "The security alarm is activated.";
            }
            else if (alarm == true)
            {
                alarm = false;
                button2.Image = Image.FromFile(@"images\alarm_off.png");
                richTextBox1.Text = "The security alarm is disactivated.";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Washing_machine().Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (robot_on == false)
            {
                robot_on = true;
                SoundPlayer player = new SoundPlayer(@"sound\robot_on.wav");
                player.Play();
                button6.Image = Image.FromFile(@"images\robotic_vacuum_cleaner_on.png");
                richTextBox1.Text = "The robotic vacuum cleaner is activated.";
            }
            else if (robot_on == true)
            {
                robot_on = false;
                SoundPlayer player = new SoundPlayer(@"sound\robot_off.wav");
                player.Play();
                button6.Image = Image.FromFile(@"images\robotic_vacuum_cleaner_off.png");
                richTextBox1.Text = "The robotic vacuum cleaner is disactivated.";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Air_conditioning().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Lights().Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
