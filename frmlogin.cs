using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace quizv4
{
    public partial class frmlogin : Form
    {
        player newplayer = new player();
        player[] players;

        public frmlogin()
        {
            InitializeComponent();
            
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {}

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Program.LoadObject(ref players);
            for (int x = 0; x < players.Length; x++)
            {
                if (players[x] != null)
                {

                    if (txtusername.Text == players[x].Name)
                    {
                        if (txtpassword.Text == players[x].Password)
                        {
                            if (proofofhumantxt.Text == "7pyr4")
                            {
                                newplayer = players[x];
                                Form quizlist = new quizlists(ref newplayer);
                                quizlist.Show();
                                this.Hide();
                                x = players.Length;

                            }
                            else
                            {
                                MessageBox.Show("incorrect varification please correct your proof of human text");
                                lblXathuman.Visible = true;
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("please enter the correct password");
                            lblxpassword.Visible = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username or password2");
                    lblxpassword.Visible = true;
                    lblxusername.Visible = true;
                }
            }
        }
        
        private void proofofhumantxt_DoubleClick(object sender, EventArgs e)
        {

        }

        private void proofofhumantxt_Click(object sender, EventArgs e)
        {
            proofofhumantxt.Clear();
        }

        private void notbot_checklbl_Click(object sender, EventArgs e)
        {

        }

        private void notbot_checklbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form createac = new frmCreatenewaccount();
            createac.Show();
            this.Hide();
        }
    } 
}
