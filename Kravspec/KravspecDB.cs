using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;

namespace Kravspec
{
    internal class KravspecDB 
    {
        
        public static MySqlConnection GetConnection()
        {
            string server = "Kravspec";
            string databas = "kravspec";
            string dbUser = "root";
            string dbPass = "Dahlin12345!";
            string dbPort = "3306";
            string dbHost = "127.0.0.1";
            string connString = $"SERVER={server};DATABASE={databas};UID={dbUser};PASSWORD={dbPass};PORT={dbPort};HOST={dbHost};Allow User Variables=true";

            MySqlConnection con = new MySqlConnection(connString);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Connection!" + ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void Regist(Krav krav)
        {
            string connString = "INSERT INTO user(Username, Password, Email) VALUES (@Username, @Password, @Email)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(connString, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Username", MySqlDbType.VarChar).Value = krav.Username;
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = krav.Password;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = krav.Email;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Account not inserted" + ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static bool Login(Krav krav)
        {
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM user WHERE username = @Username AND password = @Password",con);
            cmd.Parameters.AddWithValue("username", krav.Username);
            cmd.Parameters.AddWithValue("password", krav.Password);
            MySqlDataReader reader = cmd.ExecuteReader();
            
            bool isloggedIn = false; 
            if(reader.Read())
            {
                isloggedIn = true;

            }
            else
            {
                isloggedIn = false;
            }

            return isloggedIn;
           
        }

       


        
        
    }
}
