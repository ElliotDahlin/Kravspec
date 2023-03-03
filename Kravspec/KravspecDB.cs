using MySql.Data.MySqlClient;
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
            string dbUser = "";
            string dbPass = "";
            string dbPort = "3306";
            string dbHost = "127.0.0.0.1";
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

        
        


         
        

       
        

        
    }
}
