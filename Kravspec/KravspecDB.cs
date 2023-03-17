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
using System.Threading;
using System.Data;
using static Kravspec.KravspecDB;

namespace Kravspec
{
    internal class KravspecDB 
    {

        public static MySqlConnection GetConnection()
        {
            string server = "Kravspec";
            string databas = "kravspec";
            string dbUser = "root";
            string dbPass = "";
            string dbPort = "";
            string dbHost = "";
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
            cmd.Parameters.AddWithValue("@Username", krav.Username);
            cmd.Parameters.AddWithValue("@Password", krav.Password);           
            MySqlDataReader reader = cmd.ExecuteReader();

            bool isloggedIn = false;
            if (reader.Read())
            {
                isloggedIn = true;

            }
            else
            {
                isloggedIn = false;
            }

            return isloggedIn;
           
        }

        public static void SelectMovie(Movie movie, DataGridView datagrid)
        {
            MySqlConnection con = GetConnection();
            string connString = "SELECT FROM movies WHERE ID = @ID, Title = @Title, Director = @Director, Moviereldate = @Moviereldate, Rating = @Rating";
            MySqlCommand cmd = new MySqlCommand(connString, con);
            cmd.Parameters.AddWithValue("@ID", movie);
            cmd.Parameters.AddWithValue("@Title", movie);
            cmd.Parameters.AddWithValue("@Director", movie);
            cmd.Parameters.AddWithValue("@Moviereldate", movie);
            cmd.Parameters.AddWithValue("@Rating", movie);
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                
                movie.Title = reader.GetString(1);
                movie.Director = reader.GetString(2);
                movie.Moviereldate = reader.GetString(3);
                movie.Rating = reader.GetString(4);
            }
            reader.Close();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            datagrid.DataSource = dt;
            con.Close();

        }


        public void GetMovie()
        {
           // MySqlConnection con = GetConnection();
           // MySqlCommand cmd = new MySqlCommand("SELECT * movies WHERE Title = @Title", );
           
            
        }

      

       


        
        
    }
}
