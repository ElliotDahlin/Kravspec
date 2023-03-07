using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Connection!" + ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        public static void Reg(Krav log)
        {
            string connstring = "INSERT INTO register(Username, Password, Email) VALUES (@Username, @Password, @Email)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(connstring, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@Username",MySqlDbType.VarChar).Value = log.Username;
            cmd.Parameters.AddWithValue("@Password", MySqlDbType.VarChar).Value = log.Password;
            cmd.Parameters.AddWithValue("@Email", MySqlDbType.VarChar).Value = log.Email;
            cmd.ExecuteNonQuery();

            try
            {
                cmd.ExecuteNonQuery();
                
            }
            catch(MySqlException ex)
            {

            }


        }



        public static void Login(Krav reg)
        {
            
        }

        
        


         
        

       
        

        
    }
}
