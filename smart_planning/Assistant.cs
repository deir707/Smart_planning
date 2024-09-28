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
    public partial class Assistant : Form
    {
        public static String assist;
        public Assistant()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            assist = "Tom";
            SoundPlayer player = new SoundPlayer(@"sound\hello_tom.wav");
            player.Play();
            new Main_menu().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            assist = "Carry";
            SoundPlayer player = new SoundPlayer(@"sound\hello_carry.wav");
            player.Play();
            new Main_menu().Show();
            this.Close();
        }
    }
}
