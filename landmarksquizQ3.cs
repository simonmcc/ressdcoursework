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
    public partial class landmarksquizQ3 : Form
    {
        player newplayer;
        public landmarksquizQ3()
        {
            InitializeComponent();
        }
        public landmarksquizQ3(ref player tempplayer)
        {
            InitializeComponent();
            newplayer = tempplayer;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form quizlist = new quizlists();
            quizlist.Show();
            this.Hide();
        }

        private void btnQ3_Click(object sender, EventArgs e)
        {
            Form q3 = new landmarksquizQ4();
            q3.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void chkbxindia_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (chkbxindia.Checked && chktajmahal.Checked)
            {
                MessageBox.Show("30 points awarded");
                newplayer.Score = newplayer.Score + 10;
                Form q4 = new landmarksquizQ4();
                q4.Show();
                this.Hide();
            }
            else
            {
                if (chktajmahal.Checked)
                {
                    MessageBox.Show("10 points awarded");
                    newplayer.Score = newplayer.Score + 10;
                    Form q4 = new landmarksquizQ4();
                    q4.Show();
                    this.Hide();
                }
                else
                {


                    if (chkbxindia.Checked)
                    {
                        MessageBox.Show("10 points awarded");
                        newplayer.Score = newplayer.Score + 10;
                        Form q4 = new landmarksquizQ4();
                        q4.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("incorrect zero points awarded");
                    }
                }
            }
            
        }
    }
}
