using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smart_planning
{
    public partial class Plan_day : Form
    {
        int i;
        int value;
        int choice;
        public Plan_day()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Scheduling().Show();
            this.Close();
        }

        private void Plan_day_Load(object sender, EventArgs e)
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
            String choice1 = Scheduling.time1 + " - " + Scheduling.time2 + "  " + Scheduling.event1;
            listBox1.Items.Add(choice1);
            if (Scheduling.event2 != null)
            {
                String choice2 = Scheduling.time3 + " - " + Scheduling.time4 + "  " + Scheduling.event2;
                listBox1.Items.Add(choice2);
            }
            if (Scheduling.event3 != null)
            {
                String choice3 = Scheduling.time5 + " - " + Scheduling.time6 + "  " + Scheduling.event3;
                listBox1.Items.Add(choice3);
            }
            if (Scheduling.event4 != null)
            {
                String choice4 = Scheduling.time7 + " - " + Scheduling.time8 + "  " + Scheduling.event4;
                listBox1.Items.Add(choice4);
            }
            if (Scheduling.event5 != null)
            {
                String choice5 = Scheduling.time9 + " - " + Scheduling.time10 + "  " + Scheduling.event5;
                listBox1.Items.Add(choice5);
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            if (i == 0)
            {
                button4.Enabled = true;
                choice = 1;
            }
            else if (i == 1)
            {
                button6.Enabled = true;
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.Green;
            button3.BackColor = Color.White;
            if (i == 0)
            {
                button4.Enabled = true;
                choice = 2;
            }
            else if (i == 1)
            {
                button6.Enabled = true;
            }   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.Green;
            if (i == 0)
            {
                button4.Enabled = true;
                choice = 3;
            }
            else if (i == 1)
            {
                button6.Enabled = true;
            }   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i++;
            button4.Visible = false;
            button6.Visible = true;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            if (listBox1.SelectedItem.ToString().Contains("Work"))
            {
                richTextBox1.Text = "Are you going to make a stop for a coffee?";
                button1.Text = "Yes";
                button2.Text = "Later";
                button3.Text = "No";
            }
            else if (listBox1.SelectedItem.ToString().Contains("Gym"))
            {
                richTextBox1.Text = "Do you take your gym card with you?";
                button1.Text = "Yes";
                button2.Text = "Not necessary";
                button3.Text = "No";
            }
            else if (listBox1.SelectedItem.ToString().Contains("Cinema"))
            {
                richTextBox1.Text = "Have you booked a ticket?";
                button1.Text = "Yes";
                button2.Text = "Friend has it";
                button3.Text = "Buy there";
            }
            else if (listBox1.SelectedItem.ToString().Contains("Party"))
            {
                richTextBox1.Text = "Have you got any present for the organizer?";
                button1.Text = "Yes";
                button2.Text = "Not yet";
                button3.Text = "Purchase online";
            }
            else if (listBox1.SelectedItem.ToString().Contains("Restaurant"))
            {
                richTextBox1.Text = "Have you dicided what will you order?";
                button1.Text = "Chicken";
                button2.Text = "Spaghetti";
                button3.Text = "Pizza";
            }
            else if (listBox1.SelectedItem.ToString().Contains("Shopping"))
            {
                richTextBox1.Text = "What will the new purchase be?";
                button1.Text = "Shoes";
                button2.Text = "Clothes";
                button3.Text = "Gadgets";
            }
            else if (listBox1.SelectedItem.ToString().Contains("Take dog for a walk"))
            {
                richTextBox1.Text = "Are you going to make a stop for a coffee?";
                button1.Text = "Yes";
                button2.Text = "Later";
                button3.Text = "No";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            pictureBox2.BackgroundImage = Image.FromFile(@"images\proccessing.png");
            richTextBox1.Text = "Calculating...";
            timer1.Enabled = true;
            timer1.Start();
            value = 0;
            listBox1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int time = value++;
            if (time == 3)
            {
                if (listBox1.SelectedItem.ToString().Contains("Work"))
                {
                    if (choice == 1)
                    {
                        richTextBox1.Text = "Here is the fastest route. I marked with red circle possible shops to buy coffee, if you want.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_work1.png");
                    }
                    else if (choice == 2)
                    {
                        richTextBox1.Text = "Here is the fastest route. I marked with green circle possible parking spots and with red circle possible shops to buy coffee, if you want.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_work2.png");
                    }
                    else if (choice == 3)
                    {
                        richTextBox1.Text = "Here is the fastest route. I marked with red circle possible shops to buy coffee, if you want.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_work3.png");
                    }
                }
                else if (listBox1.SelectedItem.ToString().Contains("Gym"))
                {
                    if (choice == 1)
                    {
                        richTextBox1.Text = "The is no public transport for this route.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\no_public.png");
                    }
                    else if (choice == 2)
                    {
                        richTextBox1.Text = "Here is the fastest route.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_gym2.png");
                    }
                    else if (choice == 3)
                    {
                        richTextBox1.Text = "Here is the fastest route.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_gym3.png");
                    }
                }
                else if (listBox1.SelectedItem.ToString().Contains("Cinema"))
                {
                    if (choice == 1)
                    {
                        richTextBox1.Text = "Here is the fastest route.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_cinema1.png");
                    }
                    else if (choice == 2)
                    {
                        richTextBox1.Text = "Here is the fastest route. I marked with green circle possible parking spots.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_cinema2.png");
                    }
                    else if (choice == 3)
                    {
                        richTextBox1.Text = "Here is the fastest route.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_cinema3.png");
                    }
                }
                else if (listBox1.SelectedItem.ToString().Contains("Party"))
                {
                    if (choice == 1)
                    {
                        richTextBox1.Text = "Here is the fastest route. I marked with red circle possible shops to buy a present, if you haven't bought yet.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_party1.png");
                    }
                    else if (choice == 2)
                    {
                        richTextBox1.Text = "Here is the fastest route. I marked with green circle possible parking spots and with red circle possible shops to buy a present, if you haven't bought yet.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_party2.png");
                    }
                    else if (choice == 3)
                    {
                        richTextBox1.Text = "Here is the fastest route. I marked with red circle possible shops to buy a present, if you haven't bought yet.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_party3.png");
                    }
                }
                else if (listBox1.SelectedItem.ToString().Contains("Restaurant"))
                {
                    if (choice == 1)
                    {
                        richTextBox1.Text = "Here is the fastest route.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_restaurant1.png");
                    }
                    else if (choice == 2)
                    {
                        richTextBox1.Text = "Here is the fastest route. I marked with green circle possible parking spots.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_restaurant2.png");
                    }
                    else if (choice == 3)
                    {
                        richTextBox1.Text = "Here is the fastest route.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_restaurant3.png");
                    }
                }
                else if (listBox1.SelectedItem.ToString().Contains("Shopping"))
                {
                    if (choice == 1)
                    {
                        richTextBox1.Text = "Here is the fastest route.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_shopping1.png");
                    }
                    else if (choice == 2)
                    {
                        richTextBox1.Text = "Here is the fastest route. I marked with green circle possible parking spots.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_shopping2.png");
                    }
                    else if (choice == 3)
                    {
                        richTextBox1.Text = "Here is the fastest route.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_shopping3.png");
                    }
                }
                else if (listBox1.SelectedItem.ToString().Contains("Take dog for a walk"))
                {
                    if (choice == 1)
                    {
                        richTextBox1.Text = "Here is the fastest route. I marked with red circle possible shops to buy coffee, if you want.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_dog_walking1.png");
                    }
                    else if (choice == 2)
                    {
                        richTextBox1.Text = "Here is the fastest route. I marked with red circle possible shops to buy coffee, if you want.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_dog_walking2.png");
                    }
                    else if (choice == 3)
                    {
                        richTextBox1.Text = "Here is the fastest route. I marked with red circle possible shops to buy coffee, if you want.";
                        pictureBox2.BackgroundImage = Image.FromFile(@"images\maps\map_dog_walking3.png");
                    }
                }
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            i = 0;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            listBox1.Enabled = false;
            pictureBox2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            if (listBox1.SelectedItem.ToString().Contains("Work"))
            {
                pictureBox2.BackgroundImage = Image.FromFile(@"images\work.png");
                richTextBox1.Text = "Which transport are you going to use?";
                button1.Text = "Public";
                button2.Text = "Car";
                button3.Text = "Taxi";
            }
            else if (listBox1.SelectedItem.ToString().Contains("Gym"))
            {
                pictureBox2.BackgroundImage = Image.FromFile(@"images\gym.png");
                richTextBox1.Text = "Which transport are you going to use?";
                button1.Text = "Public";
                button2.Text = "Car";
                button3.Text = "Walking";
            }
            else if (listBox1.SelectedItem.ToString().Contains("Cinema"))
            {
                pictureBox2.BackgroundImage = Image.FromFile(@"images\cinema.png");
                richTextBox1.Text = "Which transport are you going to use?";
                button1.Text = "Public";
                button2.Text = "Car";
                button3.Text = "Taxi";
            }
            else if (listBox1.SelectedItem.ToString().Contains("Party"))
            {
                pictureBox2.BackgroundImage = Image.FromFile(@"images\party.png");
                richTextBox1.Text = "Which transport are you going to use?";
                button1.Text = "Public";
                button2.Text = "Car";
                button3.Text = "Walking";
            }
            else if (listBox1.SelectedItem.ToString().Contains("Restaurant"))
            {
                pictureBox2.BackgroundImage = Image.FromFile(@"images\restaurant.png");
                richTextBox1.Text = "Which transport are you going to use?";
                button1.Text = "Public";
                button2.Text = "Car";
                button3.Text = "Taxi";
            }
            else if (listBox1.SelectedItem.ToString().Contains("Shopping"))
            {
                pictureBox2.BackgroundImage = Image.FromFile(@"images\shopping.png");
                richTextBox1.Text = "Which transport are you going to use?";
                button1.Text = "Public";
                button2.Text = "Car";
                button3.Text = "Walking";
            }
            else if (listBox1.SelectedItem.ToString().Contains("Take dog for a walk"))
            {
                pictureBox2.BackgroundImage = Image.FromFile(@"images\dog_walking.png");
                richTextBox1.Text = "Where are you going to?";
                button1.Text = "Nea Filadelfia Park";
                button2.Text = "Antonis Tritsis Park";
                button3.Text = "Veikou Park";
            }
        }
    }
}
