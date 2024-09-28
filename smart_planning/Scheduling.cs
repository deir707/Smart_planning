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
    public partial class Scheduling : Form
    {
        public static String event1;
        public static String event2;
        public static String event3;
        public static String event4;
        public static String event5;
        public static String time1;
        public static String time2;
        public static String time3;
        public static String time4;
        public static String time5;
        public static String time6;
        public static String time7;
        public static String time8;
        public static String time9;
        public static String time10;
        public Scheduling()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Main_menu().Show();
            this.Close();
        }

        private void Schedule_day_Load(object sender, EventArgs e)
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
            event1 = null;
            event2 = null;
            event3 = null;
            event4 = null;
            event5 = null;
            time1 = null;
            time2 = null;
            time3 = null;
            time4 = null;
            time5 = null;
            time6 = null;
            time7 = null;
            time8 = null;
            time9 = null;
            time10 = null;
    }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox8.SelectedItem != null && comboBox9.SelectedItem != null)
            {
                if (comboBox1.SelectedItem != null && comboBox8.SelectedItem != null && comboBox9.SelectedItem != null &&
                    comboBox2.SelectedItem == null && comboBox10.SelectedItem == null && comboBox11.SelectedItem == null &&
                    comboBox3.SelectedItem == null && comboBox12.SelectedItem == null && comboBox13.SelectedItem == null &&
                    comboBox4.SelectedItem == null && comboBox14.SelectedItem == null && comboBox15.SelectedItem == null &&
                    comboBox5.SelectedItem == null && comboBox16.SelectedItem == null && comboBox17.SelectedItem == null)
                {
                    event1 = comboBox1.SelectedItem.ToString();
                    time1 = comboBox8.SelectedItem.ToString();
                    time2 = comboBox9.SelectedItem.ToString();
                    new Plan_day().Show();
                    this.Close();
                }
                else if (comboBox1.SelectedItem != null && comboBox8.SelectedItem != null && comboBox9.SelectedItem != null &&
                        comboBox2.SelectedItem != null && comboBox10.SelectedItem != null && comboBox11.SelectedItem != null &&
                        comboBox3.SelectedItem == null && comboBox12.SelectedItem == null && comboBox13.SelectedItem == null &&
                        comboBox4.SelectedItem == null && comboBox14.SelectedItem == null && comboBox15.SelectedItem == null &&
                        comboBox5.SelectedItem == null && comboBox16.SelectedItem == null && comboBox17.SelectedItem == null)
                {
                    event1 = comboBox1.SelectedItem.ToString();
                    event2 = comboBox2.SelectedItem.ToString();
                    time1 = comboBox8.SelectedItem.ToString();
                    time2 = comboBox9.SelectedItem.ToString();
                    time3 = comboBox10.SelectedItem.ToString();
                    time4 = comboBox11.SelectedItem.ToString();
                    new Plan_day().Show();
                    this.Close();
                }
                else if (comboBox1.SelectedItem != null && comboBox8.SelectedItem != null && comboBox9.SelectedItem != null &&
                        comboBox2.SelectedItem != null && comboBox10.SelectedItem != null && comboBox11.SelectedItem != null &&
                        comboBox3.SelectedItem != null && comboBox12.SelectedItem != null && comboBox13.SelectedItem != null &&
                        comboBox4.SelectedItem == null && comboBox14.SelectedItem == null && comboBox15.SelectedItem == null &&
                        comboBox5.SelectedItem == null && comboBox16.SelectedItem == null && comboBox17.SelectedItem == null)
                {
                    event1 = comboBox1.SelectedItem.ToString();
                    event2 = comboBox2.SelectedItem.ToString();
                    event3 = comboBox3.SelectedItem.ToString();
                    time1 = comboBox8.SelectedItem.ToString();
                    time2 = comboBox9.SelectedItem.ToString();
                    time3 = comboBox10.SelectedItem.ToString();
                    time4 = comboBox11.SelectedItem.ToString();
                    time5 = comboBox12.SelectedItem.ToString();
                    time6 = comboBox13.SelectedItem.ToString();
                    new Plan_day().Show();
                    this.Close();
                }
                else if (comboBox1.SelectedItem != null && comboBox8.SelectedItem != null && comboBox9.SelectedItem != null &&
                        comboBox2.SelectedItem != null && comboBox10.SelectedItem != null && comboBox11.SelectedItem != null &&
                        comboBox3.SelectedItem != null && comboBox12.SelectedItem != null && comboBox13.SelectedItem != null &&
                        comboBox4.SelectedItem != null && comboBox14.SelectedItem != null && comboBox15.SelectedItem != null &&
                        comboBox5.SelectedItem == null && comboBox16.SelectedItem == null && comboBox17.SelectedItem == null)
                {
                    event1 = comboBox1.SelectedItem.ToString();
                    event2 = comboBox2.SelectedItem.ToString();
                    event3 = comboBox3.SelectedItem.ToString();
                    event4 = comboBox4.SelectedItem.ToString();
                    time1 = comboBox8.SelectedItem.ToString();
                    time2 = comboBox9.SelectedItem.ToString();
                    time3 = comboBox10.SelectedItem.ToString();
                    time4 = comboBox11.SelectedItem.ToString();
                    time5 = comboBox12.SelectedItem.ToString();
                    time6 = comboBox13.SelectedItem.ToString();
                    time7 = comboBox14.SelectedItem.ToString();
                    time8 = comboBox15.SelectedItem.ToString();
                    new Plan_day().Show();
                    this.Close();
                }
                else if (comboBox1.SelectedItem != null && comboBox8.SelectedItem != null && comboBox9.SelectedItem != null &&
                        comboBox2.SelectedItem != null && comboBox10.SelectedItem != null && comboBox11.SelectedItem != null &&
                        comboBox3.SelectedItem != null && comboBox12.SelectedItem != null && comboBox13.SelectedItem != null &&
                        comboBox4.SelectedItem != null && comboBox14.SelectedItem != null && comboBox15.SelectedItem != null &&
                        comboBox5.SelectedItem != null && comboBox16.SelectedItem != null && comboBox17.SelectedItem != null)
                {
                    event1 = comboBox1.SelectedItem.ToString();
                    event2 = comboBox2.SelectedItem.ToString();
                    event3 = comboBox3.SelectedItem.ToString();
                    event4 = comboBox4.SelectedItem.ToString();
                    event5 = comboBox5.SelectedItem.ToString();
                    time1 = comboBox8.SelectedItem.ToString();
                    time2 = comboBox9.SelectedItem.ToString();
                    time3 = comboBox10.SelectedItem.ToString();
                    time4 = comboBox11.SelectedItem.ToString();
                    time5 = comboBox12.SelectedItem.ToString();
                    time6 = comboBox13.SelectedItem.ToString();
                    time7 = comboBox14.SelectedItem.ToString();
                    time8 = comboBox15.SelectedItem.ToString();
                    time9 = comboBox16.SelectedItem.ToString();
                    time10 = comboBox17.SelectedItem.ToString();
                    new Plan_day().Show();
                    this.Close();
                }
            }
            else
            {
                richTextBox1.Text = "Some columns must be fullfilled or time is incorrect.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox8.SelectedItem != null && comboBox9.SelectedItem != null &&
                    comboBox2.SelectedItem == null && comboBox10.SelectedItem == null && comboBox11.SelectedItem == null &&
                    comboBox3.SelectedItem == null && comboBox12.SelectedItem == null && comboBox13.SelectedItem == null &&
                    comboBox4.SelectedItem == null && comboBox14.SelectedItem == null && comboBox15.SelectedItem == null &&
                    comboBox5.SelectedItem == null && comboBox16.SelectedItem == null && comboBox17.SelectedItem == null)
            {
                event1 = comboBox1.SelectedItem.ToString();
                new Shoes_choice().Show();
                this.Close();
            }
            else if (comboBox1.SelectedItem != null && comboBox8.SelectedItem != null && comboBox9.SelectedItem != null &&
                    comboBox2.SelectedItem != null && comboBox10.SelectedItem != null && comboBox11.SelectedItem != null &&
                    comboBox3.SelectedItem == null && comboBox12.SelectedItem == null && comboBox13.SelectedItem == null &&
                    comboBox4.SelectedItem == null && comboBox14.SelectedItem == null && comboBox15.SelectedItem == null &&
                    comboBox5.SelectedItem == null && comboBox16.SelectedItem == null && comboBox17.SelectedItem == null)
            {
                event1 = comboBox1.SelectedItem.ToString();
                event2 = comboBox2.SelectedItem.ToString();
                new Shoes_choice().Show();
                this.Close();
            }
            else if (comboBox1.SelectedItem != null && comboBox8.SelectedItem != null && comboBox9.SelectedItem != null &&
                    comboBox2.SelectedItem != null && comboBox10.SelectedItem != null && comboBox11.SelectedItem != null &&
                    comboBox3.SelectedItem != null && comboBox12.SelectedItem != null && comboBox13.SelectedItem != null &&
                    comboBox4.SelectedItem == null && comboBox14.SelectedItem == null && comboBox15.SelectedItem == null &&
                    comboBox5.SelectedItem == null && comboBox16.SelectedItem == null && comboBox17.SelectedItem == null)
            {
                event1 = comboBox1.SelectedItem.ToString();
                event2 = comboBox2.SelectedItem.ToString();
                event3 = comboBox3.SelectedItem.ToString();
                new Shoes_choice().Show();
                this.Close();
            }
            else if (comboBox1.SelectedItem != null && comboBox8.SelectedItem != null && comboBox9.SelectedItem != null &&
                    comboBox2.SelectedItem != null && comboBox10.SelectedItem != null && comboBox11.SelectedItem != null &&
                    comboBox3.SelectedItem != null && comboBox12.SelectedItem != null && comboBox13.SelectedItem != null &&
                    comboBox4.SelectedItem != null && comboBox14.SelectedItem != null && comboBox15.SelectedItem != null &&
                    comboBox5.SelectedItem == null && comboBox16.SelectedItem == null && comboBox17.SelectedItem == null)
            {
                event1 = comboBox1.SelectedItem.ToString();
                event2 = comboBox2.SelectedItem.ToString();
                event3 = comboBox3.SelectedItem.ToString();
                event4 = comboBox4.SelectedItem.ToString();
                new Shoes_choice().Show();
                this.Close();
            }
            else if (comboBox1.SelectedItem != null && comboBox8.SelectedItem != null && comboBox9.SelectedItem != null &&
                    comboBox2.SelectedItem != null && comboBox10.SelectedItem != null && comboBox11.SelectedItem != null &&
                    comboBox3.SelectedItem != null && comboBox12.SelectedItem != null && comboBox13.SelectedItem != null &&
                    comboBox4.SelectedItem != null && comboBox14.SelectedItem != null && comboBox15.SelectedItem != null &&
                    comboBox5.SelectedItem != null && comboBox16.SelectedItem != null && comboBox17.SelectedItem != null)
            {
                event1 = comboBox1.SelectedItem.ToString();
                event2 = comboBox2.SelectedItem.ToString();
                event3 = comboBox3.SelectedItem.ToString();
                event4 = comboBox4.SelectedItem.ToString();
                event5 = comboBox5.SelectedItem.ToString();
                new Shoes_choice().Show();
                this.Close();
            }
            else
            {
                richTextBox1.Text = "Some columns must be fullfilled or time is incorrect.";
            }
        }
    }
}
