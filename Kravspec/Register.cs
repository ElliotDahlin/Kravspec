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
        public string username, password, email;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
        }

        public void Clear()
        {
            txtUser1.Text = string.Empty;
            txtPass1.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
       

        private void Regbtn_Click(object sender, EventArgs e)
        {
           if(txtUser1.Text.Trim().Length < 1)
            {
                MessageBox.Show("Username is empty");
                return;
            }
            if (txtPass1.Text.Trim().Length < 8)
            {
                MessageBox.Show("Password is empty");
                return;
            }
            if (txtEmail.Text.Trim().Length < 1)
            {
                MessageBox.Show("Email is empty");
                return;
            }

            if(Regbtn.Text == "Register")
            {
                Krav krav = new Krav(txtUser1.Text.Trim(), txtPass1.Text.Trim(), txtEmail.Text.Trim());
                KravspecDB.Regist(krav);
                Clear();
                
            }

            MessageBox.Show("Your account has been created");
            this.Close();
            Form1 loginForm = new Form1();
            loginForm.Show();


        }

        

       
        
        
        
        
            
        
    }
}
