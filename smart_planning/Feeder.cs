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
    public partial class Feeder : Form
    {
        public Feeder()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Pet_care().Show();
            this.Close();
        }

        private void Feeder_Load(object sender, EventArgs e)
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
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                richTextBox1.Text = "You have to select one of the options.";
            }
            else
            {
                DateTime started = Convert.ToDateTime(dateTimePicker1.Text);
                DateTime ended = Convert.ToDateTime(dateTimePicker2.Text);

                if (started > ended)
                {
                    richTextBox1.Text = "Date started is greater than date ended.";
                }
                else
                {
                    SoundPlayer player = new SoundPlayer(@"sound\food_served.wav");
                    player.Play();
                    richTextBox1.Text = "Feeder is activated.";
                }
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = true;
            label1.Enabled = true;
            numericUpDown2.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            richTextBox1.Text = "Here you can set the number of meals per day with a maximum value of 5. So be aware.";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
            label1.Enabled = false;
            numericUpDown2.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            richTextBox1.Text = "Here you can set ml of water per day with a maximum value of 2000ml. So be aware.";
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = true;
            label1.Enabled = true;
            numericUpDown2.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            richTextBox1.Text = "Here you can set both the number of meals and ml of water per day. Keep in mind the maximum values.";
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Keep in mind that dogs needs 400-500ml water per day.";
        }
    }
}
