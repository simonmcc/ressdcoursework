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
    public partial class landmarksquizQ2 : Form
    {
        player newplayer = new player();
        int country;
        int points = 10;
        public landmarksquizQ2()
        {
            InitializeComponent();     
        }
        public landmarksquizQ2(ref player tempplayer)
        {
            InitializeComponent();
            newplayer = tempplayer;
        }
        private void btnlondon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("London is not a country...");
            Form Q2 = new landmarksquizQ3();
            Q2.Show();
            this.Hide();
        }

        private void btnitaly_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer zero points awarded");
            Form Q2 = new landmarksquizQ3();
            Q2.Show();
            this.Hide();
        }

        private void BtnGermany_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer zero points awarded");
            Form Q2 = new landmarksquizQ3();
            Q2.Show();
            this.Hide();
        }

        private void btnfrance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct 10 points awarded!!");
            newplayer.Score = newplayer.Score + points;
            Form Q2 = new landmarksquizQ3();

            Q2.Show();
            this.Hide();
            
        }

        private void btnSaudiarabia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer zero points awarded");
            Form Q2 = new landmarksquizQ3();
            Q2.Show();
            this.Hide();
        }

        private void btnKenya_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong answer zero points awarded");
            Form Q2 = new landmarksquizQ3();
            Q2.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Form ql = new quizlists();
            ql.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
