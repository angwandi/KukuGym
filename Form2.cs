﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KukuGym
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome welcome = new Welcome();
            welcome.Show();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;
            if
            ("Admin".Equals(username) && "kuku".Equals(password))

            { this.Close();
            Update update = new Update();
            update.Show(); }
           else
            Console.WriteLine("Login failed");

        }
    }
}
