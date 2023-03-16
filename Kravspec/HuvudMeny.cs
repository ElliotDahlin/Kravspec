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
    public partial class HuvudMeny : Form
    {
        public HuvudMeny()
        {
            InitializeComponent();
        }

        public static void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.ColumnIndex == 0)
            {
                
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            Addmovie addmovie = new Addmovie();
            addmovie.Show();
            this.Hide();
        }
    }
}
