using Kravspec.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kravspec
{
    public partial class Rating : Form
    {
        public Rating()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.icons8_kebab_60; // färglogga på alla = slutar på 60
            pictureBox2.Image = Resources.icons8_kebab_60;
            pictureBox3.Image = Resources.icons8_kebab_60;
            pictureBox4.Image = Resources.icons8_kebab_60;
            pictureBox5.Image = Resources.icons8_kebab_60;
            lblRating.Text = "5";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.icons8_kebab_60;
            pictureBox2.Image = Resources.icons8_kebab_60;
            pictureBox3.Image = Resources.icons8_kebab_60;
            pictureBox4.Image = Resources.icons8_kebab_60;
            pictureBox5.Image = Resources.icons8_kebab_60__1_;
            lblRating.Text = "4";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.icons8_kebab_60;
            pictureBox2.Image = Resources.icons8_kebab_60;
            pictureBox3.Image = Resources.icons8_kebab_60;
            pictureBox4.Image = Resources.icons8_kebab_60__1_;
            pictureBox5.Image = Resources.icons8_kebab_60__1_;
            lblRating.Text = "3";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.icons8_kebab_60;
            pictureBox2.Image = Resources.icons8_kebab_60;
            pictureBox3.Image = Resources.icons8_kebab_60__1_;
            pictureBox4.Image = Resources.icons8_kebab_60__1_;
            pictureBox5.Image = Resources.icons8_kebab_60__1_;
            lblRating.Text = "2";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.icons8_kebab_60;
            pictureBox2.Image = Resources.icons8_kebab_60__1_;
            pictureBox3.Image = Resources.icons8_kebab_60__1_;
            pictureBox4.Image = Resources.icons8_kebab_60__1_;
            pictureBox5.Image = Resources.icons8_kebab_60__1_;
            lblRating.Text = "1";
        }
    }
}
