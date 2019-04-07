using System;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace kukugym
{
    public class DB
    {
        public static MySqlConnection Connect()
        {
            using (var con = new MySqlConnection("server=localhost;user=root;database=kukugym;port=3306;password="))
            {
                return con;
            }
            
        }
    }
}