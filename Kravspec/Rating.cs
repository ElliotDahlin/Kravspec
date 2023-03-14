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
            pictureBox1.Image = Resources.icons8 - kebab - 60;
        }
    }
}
