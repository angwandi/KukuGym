using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using MySql.Data.MySqlClient;
using static kukugym.DB;

namespace kukugym
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            //AddUser();
            //AddCoach();
            //AddAdmin();
            addActivity();
            //loginAdmin();
            LoadRandomActivity();
            //Console.WriteLine("Hello World");
            InitializeComponent();
        }

        private static void AddAdmin()
        {
            string sql = null;
            var con = Connect();
            con.Open();
            sql = "INSERT INTO admin (name, phone_number) VALUE (?name, ?number)";
            try
            {
                using (MySqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("?name", "Admin");
                    cmd.Parameters.AddWithValue("?number", "0798764323");
                
                    //execute query
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show(e.ToString());
                throw;
            }
        }

        private static void AddUser()
        {
            string sql = null;
            var con = Connect();
            con.Open();
            sql = "INSERT INTO users (name, age, gender, paid, phone_number) VALUE (?name, ?age, ?gender, ?paid, ?number)";
            try
            {
                using (MySqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("?name", "Violet");
                    cmd.Parameters.AddWithValue("?age", 49);
                    cmd.Parameters.AddWithValue("?gender", "Transgender");
                    cmd.Parameters.AddWithValue("?paid", 1);
                    cmd.Parameters.AddWithValue("?number", "0798764321");
                
                    //execute query
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show(e.ToString());
                throw;
            }
        }

         private static void AddCoach()
        {
            string sql = null;
            var con = Connect();
            con.Open();
            sql = "INSERT INTO coaches (name, age, gender, rating, phone_number) VALUE (?name, ?age, ?gender, ?rating, ?number)";

            try
            {
                using (MySqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("?name", "Tobey");
                    cmd.Parameters.AddWithValue("?age", 19);
                    cmd.Parameters.AddWithValue("?gender", "HeShe");
                    cmd.Parameters.AddWithValue("?rating", 1);
                    cmd.Parameters.AddWithValue("?number", "0798764322");
                    
                    //execute query
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show(e.ToString());
                throw;
            }
        }

        private void login()
        {
            //define variables
            string name = null;
            int phone = 0;
            
            //connect to db
            var con = Connect();
            //open connection
            con.Open();
            
            //set values for name and age from user entry
            name = "Violet";
            phone = 0798764321;

            try
            {
                //search for user in db using both vars
                using (MySqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText =  "SELECT * FROM users WHERE name = ?name AND phone_number = ?phone";
                    cmd.Parameters.AddWithValue("?name", name);
                    cmd.Parameters.AddWithValue("?phone", phone);
                    var mySqlDataReader = cmd.ExecuteReader();

                    if (mySqlDataReader.HasRows)//if result is found
                    {
                        //log user in
                        TextBox1.Text = mySqlDataReader.Read().ToString();
                        MessageBox.Show(mySqlDataReader.GetString(1));
                    }
                    else //else
                    {
                        //show error
                    }
                    //cmd.ExecuteNonQuery();
/*                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                    mySqlDataAdapter.SelectCommand = cmd;
                    
                    var dataTable = new DataTable();
                    mySqlDataAdapter.Fill(dataTable);
                    MessageBox.Show(dataTable.ToString());*/
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }

        }
        
         private void loginCoach()
        {
            //define variables
            string name = null;
            int phone = 0;
            
            //connect to db
            var con = Connect();
            //open connection
            con.Open();
            
            //set values for name and age from user entry
            name = "Tobey";
            phone = 0798764322;

            try
            {
                //search for user in db using both vars
                using (MySqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText =  "SELECT * FROM coaches WHERE name = ?name AND phone_number = ?phone";
                    cmd.Parameters.AddWithValue("?name", name);
                    cmd.Parameters.AddWithValue("?phone", phone);
                    MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

                    if (mySqlDataReader.HasRows)//if result is found
                    {
                        //log user in
                        TextBox1.Text = mySqlDataReader.Read().ToString();
                        MessageBox.Show(mySqlDataReader.GetString(1));
                    }
                    else //else
                    {
                        //show error
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }

        }
        
         private void loginAdmin()
        {
            //define variables
            string name = null;
            int phone = 0;
            
            //connect to db
            var con = Connect();
            //open connection
            con.Open();
            
            //set values for name and age from user entry
            name = "Admin";
            phone = 0798764323;

            try
            {
                //search for user in db using both vars
                using (MySqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText =  "SELECT * FROM admin WHERE name = ?name AND phone_number = ?phone";
                    cmd.Parameters.AddWithValue("?name", name);
                    cmd.Parameters.AddWithValue("?phone", phone);
                    MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

                    if (mySqlDataReader.HasRows)//if result is found
                    {
                        //log user in
                        TextBox1.Text = mySqlDataReader.Read().ToString();
                        MessageBox.Show(mySqlDataReader.GetString(1));
                    }
                    else //else
                    {
                        //show error
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }

        }

         private bool addActivity()
         {
             var duration = "10min";
             var name = "Push Ups";
             var description = "Place all four limbs on the floor in a straightened position, with palms on the floor, an toes on the floor, lift you body up and down continuously.";

             var con = Connect();
             con.Open();
             
             try
             {
                 using (var cmd = con.CreateCommand())
                 {
                     cmd.CommandText = "INSERT INTO activities (duration, name, description) VALUE (?dur, ?name, ?desc)";
                     cmd.Parameters.AddWithValue("?dur", duration);
                     cmd.Parameters.AddWithValue("?name", name);
                     cmd.Parameters.AddWithValue("?desc", description);

                     if (cmd.ExecuteNonQuery() == 1)
                     {
                         return true;
                     }
                 }
             }
             catch (Exception e)
             {
                 MessageBox.Show(e.ToString());
                 throw;
             }
             
             return false;
         }

         private void LoadRandomActivity()
         {
             var con = Connect();
               con.Open();
               try
               {
                   using (var cmd = con.CreateCommand())
                   {
                       cmd.CommandText = "SELECT * FROM activities ORDER BY RAND() LIMIT 1";
                       var mySqlDataReader = cmd.ExecuteReader();

                       if (mySqlDataReader.HasRows)//if result is found
                       {
                           //log user in
                           /*//TextBox1.Text =*/ mySqlDataReader.Read();
                           var duration = mySqlDataReader.GetString(1);
                           var name = mySqlDataReader.GetString(2);
                           var description = mySqlDataReader.GetString(3);
                           MessageBox.Show("Today Exercise duration: " + duration + " Name: " + name + " Description: " + description );
                       }
                       else //else
                       {
                           //show error
                       }
                   }
               }
               catch (Exception e)
               {
                   MessageBox.Show(e.ToString());
                   throw;
               }
             
         }
        private void TextBox1_OnContextMenuClosing(object sender, ContextMenuEventArgs e)
        {
            
            throw new NotImplementedException();
        }

        private void Login_OnClick(object sender, RoutedEventArgs e)
        {
            loginAdmin();
            
            //throw new NotImplementedException();
        }
    }
}