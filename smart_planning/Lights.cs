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
    public partial class Lights : Form
    {
        Boolean lights_on1 = false;
        Boolean lights_on2 = false;
        Boolean lights_on3 = false;
        Boolean lights_on4 = false;
        Boolean lights_on5 = false;
        Boolean lights_on6 = false;
        public Lights()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lights_on1 == false && lights_on2 == false && lights_on3 == false && lights_on4 == false && lights_on5 == false && lights_on6 == false)
            {
                new Home_control().Show();
                this.Close();
            }
            else
            {
                richTextBox1.Text = "You have left lights on. You need to turn them off in order to continue.";
            }
            
        }

        private void Lights_Load(object sender, EventArgs e)
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
            button1.BackgroundImage = Image.FromFile(@"images\master_bedroom_off.jpg");
            button4.BackgroundImage = Image.FromFile(@"images\kitchen_off.jpg");
            button6.BackgroundImage = Image.FromFile(@"images\bedroom2_off.jpg");
            button2.BackgroundImage = Image.FromFile(@"images\living room_off.jpg");
            button3.BackgroundImage = Image.FromFile(@"images\bathroom_off.jpg");
            button7.BackgroundImage = Image.FromFile(@"images\wc_off.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lights_on1 == false)
            {
                lights_on1 = true;
                SoundPlayer player = new SoundPlayer(@"sound\lights_on.wav");
                player.Play();
                button1.BackgroundImage = Image.FromFile(@"images\master_bedroom_on.jpg");
                button1.ForeColor = Color.Black;
                richTextBox1.Text = "Master bedroom's lights are on.";

            }
            else
            {
                lights_on1 = false;
                SoundPlayer player = new SoundPlayer(@"sound\lights_off.wav");
                player.Play();
                button1.BackgroundImage = Image.FromFile(@"images\master_bedroom_off.jpg");
                button1.ForeColor = Color.White;
                richTextBox1.Text = "Master bedroom's lights are off.";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lights_on2 == false)
            {
                lights_on2 = true;
                SoundPlayer player = new SoundPlayer(@"sound\lights_on.wav");
                player.Play();
                button4.BackgroundImage = Image.FromFile(@"images\kitchen_on.jpg");
                button4.ForeColor = Color.Black;
                richTextBox1.Text = "Kitchen's lights are on.";
            }
            else
            {
                lights_on2 = false;
                SoundPlayer player = new SoundPlayer(@"sound\lights_off.wav");
                player.Play();
                button4.BackgroundImage = Image.FromFile(@"images\kitchen_off.jpg");
                button4.ForeColor = Color.White;
                richTextBox1.Text = "Kitchen's lights are off.";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lights_on3 == false)
            {
                lights_on3 = true;
                SoundPlayer player = new SoundPlayer(@"sound\lights_on.wav");
                player.Play();
                button6.BackgroundImage = Image.FromFile(@"images\bedroom2_on.jpg");
                button6.ForeColor = Color.Black;
                richTextBox1.Text = "Bedroom's 2 lights are on.";
            }
            else
            {
                lights_on3 = false;
                SoundPlayer player = new SoundPlayer(@"sound\lights_off.wav");
                player.Play();
                button6.BackgroundImage = Image.FromFile(@"images\bedroom2_off.jpg");
                button6.ForeColor = Color.White;
                richTextBox1.Text = "Bedroom's 2 lights are off.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lights_on4 == false)
            {
                lights_on4 = true;
                SoundPlayer player = new SoundPlayer(@"sound\lights_on.wav");
                player.Play();
                button2.BackgroundImage = Image.FromFile(@"images\living room_on.jpg");
                button2.ForeColor = Color.Black;
                richTextBox1.Text = "Living room's lights are on.";
            }
            else
            {
                lights_on4 = false;
                SoundPlayer player = new SoundPlayer(@"sound\lights_off.wav");
                player.Play();
                button2.BackgroundImage = Image.FromFile(@"images\living room_off.jpg");
                button2.ForeColor = Color.White;
                richTextBox1.Text = "Living room's lights are off.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lights_on5 == false)
            {
                lights_on5 = true;
                SoundPlayer player = new SoundPlayer(@"sound\lights_on.wav");
                player.Play();
                button3.BackgroundImage = Image.FromFile(@"images\bathroom_on.jpg");
                button3.ForeColor = Color.Black;
                richTextBox1.Text = "Bathroom's lights are on.";
            }
            else
            {
                lights_on5 = false;
                SoundPlayer player = new SoundPlayer(@"sound\lights_off.wav");
                player.Play();
                button3.BackgroundImage = Image.FromFile(@"images\bathroom_off.jpg");
                button3.ForeColor = Color.White;
                richTextBox1.Text = "Bathroom's lights are off.";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lights_on6 == false)
            {
                lights_on6 = true;
                SoundPlayer player = new SoundPlayer(@"sound\lights_on.wav");
                player.Play();
                button7.BackgroundImage = Image.FromFile(@"images\wc_on.jpg");
                button7.ForeColor = Color.Black;
                richTextBox1.Text = "WC's lights are on.";
            }
            else
            {
                lights_on6 = false;
                SoundPlayer player = new SoundPlayer(@"sound\lights_off.wav");
                player.Play();
                button7.BackgroundImage = Image.FromFile(@"images\wc_off.jpg");
                button7.ForeColor = Color.White;
                richTextBox1.Text = "WC's lights are off.";
            }
        }
    }
}
