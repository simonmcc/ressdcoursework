using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizv4
{
    public partial class quizlists : Form
    {
        player newplayer;

        public quizlists()
        {
            InitializeComponent();
        }

        public quizlists( ref player tempplayer)
        {
            InitializeComponent();
            newplayer = tempplayer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form landmarks = new landmarksquizQ1( ref newplayer);
            landmarks.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form login = new frmlogin();
            login.Show();
            this.Close();
        }

        private void btnendprogram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
