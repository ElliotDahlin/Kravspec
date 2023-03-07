using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Kravspec
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
        }

        private void Regbtn_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show("Your account has been created");
            this.Close();
            Form1 loginForm = new Form1();
            loginForm.Show();
            

        }

        public void Reg(object sender, EventArgs e)
        {
            Regbtn_Click(sender, e);
        }
        
        
        
        
            
        
    }
}
