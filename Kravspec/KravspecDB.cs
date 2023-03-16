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

        internal class Database
        {
            private MySqlConnection conn;

            private string server;

            private string database;

            private string user;

            private string password;

            private string port;

            private string host;

            public Database()
            {

                server = "Kravspec";
                database = "kravspec";
                user = "root";
                password = "Dahlin12345!";
                port = "3306";
                host = "127.0.0.1";



                string connString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={password};PORT={port};HOST={host};Allow User Variables=true";

                conn = new MySqlConnection(connString);

            }


            public MySqlConnection GetConnection()
            {
                return conn;
            }

            public bool OpenConnection()
            {
                try
                {
                    conn.Open();
                    return true;

                }
                catch (MySqlException e)
                {
                    switch (e.Number)
                    {
                        case 0:
                            break;
                        case 1045:
                            break;
                    }

                    return false;
                }


            }

            public bool CloseConnection()
            {
                try
                {
                    conn.Close();
                    return true;

                }
                catch (MySqlException e)
                {
                    switch (e.Number)
                    {
                        case 0:
                            break;
                        case 1045:
                            break;
                    }

                    return false;
                }

            }


        }

        public static void Regist(Krav krav)
        {
            Database database = new Database();
            string connString = "INSERT INTO user(Username, Password, Email) VALUES (@Username, @Password, @Email)";
            database.OpenConnection();
            MySqlConnection conn = database.GetConnection();
            MySqlCommand cmd = new MySqlCommand(connString, conn);
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
            conn.Close();
        }

        public static bool Login(Krav krav)
        {
            Database database = new Database();
            string connString = "SELECT * FROM user WHERE username = @Username AND password = @Password";
            database.OpenConnection();
            MySqlConnection conn = database.GetConnection();
            MySqlCommand cmd = new MySqlCommand(connString, conn);
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

        public static void SelectMovie(Movie movie, DataGridView datagrid)
        {
            Database database = new Database();          
            string connString = "SELECT FROM movies WHERE ID = @ID, Title = @Title, Director = @Director, Moviereldate = @Moviereldate, Rating = @Rating";
            database.OpenConnection();
            MySqlConnection conn = database.GetConnection();
            MySqlCommand cmd = new MySqlCommand(connString, conn);
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
            conn.Close();

        }


        public void GetMovie()
        {
           // MySqlConnection con = GetConnection();
           // MySqlCommand cmd = new MySqlCommand("SELECT * movies WHERE Title = @Title", );
           
            
        }

      

       


        
        
    }
}
