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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace smart_planning
{
    public partial class Shoes_choice : Form
    {
        int img;
        int value;
        public Shoes_choice()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            new Scheduling().Show();
            this.Close();
        }

        private void Shoes_choice_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String assist = Assistant.assist;
            if (assist == "Tom")
            {
                pictureBox1.Image = Image.FromFile(@"images\tom_small.png");
            }
            if (assist == "Carry")
            {
                pictureBox1.Image = Image.FromFile(@"images\carry_small.png");
            }
            timer1.Enabled = true;
            label2.Text = img.ToString();
            String choice1 = Scheduling.event1;
            listBox1.Items.Add(choice1);
            if (Scheduling.event2 != null)
            {
                String choice2 = Scheduling.event2;
                listBox1.Items.Add(choice2);
            }
            if (Scheduling.event3 != null)
            {
                String choice3 = Scheduling.event3;
                listBox1.Items.Add(choice3);
            }
            if (Scheduling.event4 != null)
            {
                String choice4 = Scheduling.event4;
                listBox1.Items.Add(choice4);
            }
            if (Scheduling.event5 != null)
            {
                String choice5 = Scheduling.event5;
                listBox1.Items.Add(choice5);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (img <= 6)
                {
                    img++;
                    pictureBox2.BackgroundImage = imageList1.Images[img];
                } 
            }
            else if (radioButton2.Checked == true)
            {
                if (img <= 6)
                {
                    img++;
                    pictureBox2.BackgroundImage = imageList2.Images[img];
                } 
            }
            label2.Text = img.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (img >= 1)
                {
                    img--;
                    pictureBox2.BackgroundImage = imageList1.Images[img];
                }   
            }
            else if (radioButton2.Checked == true)
            {
                if (img >= 1)
                {
                    img--;
                    pictureBox2.BackgroundImage = imageList2.Images[img];
                } 
            }
            label2.Text = img.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int time = value++;
            if (time == 30)
            {
                SoundPlayer player = new SoundPlayer(@"sound\ding.wav");
                player.Play();
                linkLabel1.Enabled = true;
                linkLabel1.Visible = true;
                linkLabel1.Text = "https://www.nak.gr/gr/";
                richTextBox1.Text = "If you can't find the best choice, I suggest to have a look in the website below and make a new purchase.";
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.nak.gr/gr/");
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.BackgroundImage = imageList1.Images[img];
            richTextBox1.Text = "";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.BackgroundImage = imageList2.Images[img];
            richTextBox1.Text = "";
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (listBox1.SelectedItem.ToString() == "Work")
                {
                    richTextBox1.Text = "I suggest that the best pick is between 3,4 and 5.";
                }
                else if (listBox1.SelectedItem.ToString() == "Gym")
                {
                    richTextBox1.Text = "I suggest that the best pick is 7.";
                }
                else if (listBox1.SelectedItem.ToString() == "Cinema")
                {
                    richTextBox1.Text = "I suggest that the best pick is between 0,1 and 7.";
                }
                else if (listBox1.SelectedItem.ToString() == "Party")
                {
                    richTextBox1.Text = "I suggest that the best pick is between 2,3,4,5 and 6.";
                }
                else if (listBox1.SelectedItem.ToString() == "Restaurant")
                {
                    richTextBox1.Text = "I suggest that the best pick is between 1,2,3,4 and 5.";
                }
                else if (listBox1.SelectedItem.ToString() == "Shopping")
                {
                    richTextBox1.Text = "I suggest that the best pick is between 0,1 and 7.";
                }
                else if (listBox1.SelectedItem.ToString() == "Take dog for a walk")
                {
                    richTextBox1.Text = "I suggest that the best pick is between 0,1 and 7.";
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (listBox1.SelectedItem.ToString() == "Work")
                {
                    richTextBox1.Text = "I suggest that the best pick is between 4,5,6 and 7.";
                }
                else if (listBox1.SelectedItem.ToString() == "Gym")
                {
                    richTextBox1.Text = "I suggest that the best pick is 3.";
                }
                else if (listBox1.SelectedItem.ToString() == "Cinema")
                {
                    richTextBox1.Text = "I suggest that the best pick is between 0,1,2,5,6 and 7.";
                }
                else if (listBox1.SelectedItem.ToString() == "Party")
                {
                    richTextBox1.Text = "I suggest that the best pick is between 1,4,5,6 and 7.";
                }
                else if (listBox1.SelectedItem.ToString() == "Restaurant")
                {
                    richTextBox1.Text = "I suggest that the best pick is between 4,5,6 and 7.";
                }
                else if (listBox1.SelectedItem.ToString() == "Shopping")
                {
                    richTextBox1.Text = "I suggest that the best pick is between 0,1 and 2.";
                }
                else if (listBox1.SelectedItem.ToString() == "Take dog for a walk")
                {
                    richTextBox1.Text = "I suggest that the best pick is between 0,1,2 and 3.";
                }
            }
        }
    }
}
