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
    public partial class Washing_machine : Form
    {
        Boolean start_machine = false;
        public Washing_machine()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Home_control().Show();
            this.Close();
        }

        private void Washing_machine_Load(object sender, EventArgs e)
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
            if (start_machine == false)
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false && radioButton6.Checked == false)
                {
                    richTextBox1.Text = "You need to select program and temperature and click start again.";
                }
                else
                {
                    start_machine = true;
                    SoundPlayer player = new SoundPlayer(@"sound\washing-machine.wav");
                    player.Play();
                    richTextBox1.Text = "The washing machine has just started.";
                }
                
            }
            else if (start_machine == true)
            {
                richTextBox1.Text = "The washing machine is already in use.";
            }
        }
    }
}
