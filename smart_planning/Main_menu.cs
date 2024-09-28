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
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }

        private void Main_menu_Load(object sender, EventArgs e)
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
            new Home_control().Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Pet_care().Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Scheduling().Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"online manual\Online-help.chm");
        }
    }
}
