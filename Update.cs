using System;
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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void btnadddiet_Click(object sender, EventArgs e)
        {

        }

        private void mANAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            AddActivity addActivity = new AddActivity();
            addActivity.Show();

        }

        private void dietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            AddActivity addActivity = new AddActivity();
            addActivity.Show();
        }

        private void userToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            Delete delete = new Delete();
            delete.Show();
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            AddActivity addActivity = new AddActivity();
            addActivity.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            AddActivity addActivity = new AddActivity();
            addActivity.Show();
        }

        private void activityToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            AddActivity addActivity = new AddActivity();
            addActivity.Show();
        }

        private void dietToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            AddActivity addActivity = new AddActivity();
            addActivity.Show();
        }

        private void activityToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            Delete delete = new Delete();
            delete.Show();
        }

        private void dietToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            Delete delete = new Delete();
            delete.Show();
        }
    }
}
