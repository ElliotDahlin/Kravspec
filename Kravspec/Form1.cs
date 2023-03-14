using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kravspec
{
    public partial class Form1 : Form
    {
        string username;
        string password;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblReg_Click(object sender, EventArgs e)
        {
         Register register = new Register();
         register.Show();
         this.Hide();

        }

        

        private void LgnBtn_Click(object sender, EventArgs e)
        {
            KravspecDB kravspecDB = new KravspecDB();
            Krav krav = new Krav(txtUser.Text,txtPass.Text);
            bool isLoggedIn = KravspecDB.Login(krav);
           
            

            if (isLoggedIn)
            {
                MessageBox.Show("You are logged in");
            }
            else
            {
                MessageBox.Show("Please try again");
            }


            if (txtUser.Text.Trim().Length < 1)
            {
                MessageBox.Show("Username is empty");
                return;
            }
            if (txtPass.Text.Trim().Length < 1)
            {
                MessageBox.Show("Password is empty");
                return;
            }





        }
    }
}
