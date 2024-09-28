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
    public partial class Pet_care : Form
    {
        public Pet_care()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Main_menu().Show();
            this.Close();
        }

        private void Pet_care_Load(object sender, EventArgs e)
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
            new Live().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Feeder().Show();
            this.Close();
        }
    }
}
