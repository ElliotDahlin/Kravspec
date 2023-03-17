using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kravspec
{
    public partial class Addmovie : Form
    {
        public Addmovie()
        {
            InitializeComponent();
        }
       

        public void Addmovie_Load(object sender, EventArgs e)
        {
            KravspecDB kravspecdb = new KravspecDB();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        ///private void 
        

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HuvudMeny huvudMeny = new HuvudMeny();
            huvudMeny.Show();
            this.Close();
        }

        private void ratingbtn_Click(object sender, EventArgs e)
        {

            Rating rating = new Rating();
            rating.Show();
        }
    }
}
