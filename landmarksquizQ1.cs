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
    public partial class landmarksquizQ1 : Form
    {
        player newplayer;
        public landmarksquizQ1()
        {
            InitializeComponent();
        }
               
        public landmarksquizQ1( ref player tempplayer)
        {
            InitializeComponent();
            newplayer = tempplayer;
        }
        private void nextbtn_Click(object sender, EventArgs e)
        {
            Form Q2 = new landmarksquizQ2();
            Q2.Show();
            this.Hide();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form quizlist = new quizlists();
            quizlist.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form quizlist = new quizlists();
            quizlist.Show();
            this.Hide();
        }

        private void Helpbtn_Click(object sender, EventArgs e)
        {
            Form help = new helpscreendraganddrop();
            help.Show();
        }

        private void landmarksquizQ1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form landmarks = new landmarksquizQ2();
            landmarks.Show();
            this.Hide();
        }
    }
}
