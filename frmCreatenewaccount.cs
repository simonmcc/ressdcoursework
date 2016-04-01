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
    public partial class frmCreatenewaccount : Form
    {
        player[] players;
        player newplayer = new player();
        int avatar_number;
        public frmCreatenewaccount()
        {
            InitializeComponent();
            picbxselectedavatar.AllowDrop = true;
        }

        private void picbxBradPitt_MouseDown(object sender, MouseEventArgs e)
        {
            avatar_number = 1;
            DoDragDrop((picbxBradPitt as PictureBox).Image, DragDropEffects.Copy);
        }

        private void picbxselectedavatar_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect &  DragDropEffects.Copy) !=0 && e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect=DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void picbxselectedavatar_DragDrop(object sender, DragEventArgs e)
        {
            (sender as PictureBox).Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picbxBorrisJ_MouseDown(object sender, MouseEventArgs e)
        {
            avatar_number = 2;
            DoDragDrop((sender as PictureBox).Image,DragDropEffects.Copy);
        }

        private void picbxArny_MouseDown(object sender, MouseEventArgs e)
        {
            avatar_number = 3;
            DoDragDrop((sender as PictureBox).Image,DragDropEffects.Copy);
        }

        private void picbxDonaldt_MouseDown(object sender, MouseEventArgs e)
        {
            avatar_number = 4;
            DoDragDrop((sender as PictureBox).Image, DragDropEffects.Copy);
        }
        //code to check all data is entered 
        private void btncreateacc_Click(object sender, EventArgs e)
        {
            Program.LoadObject(ref players);
           

            if (txtUsername.Text == string.Empty)
            {
                MessageBox.Show("Please enter a username");
                lblxusername.Visible = true;
            }
            else
            {
                lblxusername.Visible = false;
                if (txtPassword.Text == string.Empty)
                {
                    MessageBox.Show("Please enter your password");
                    lblxpassword1.Visible = true;
                }
                else
                {
                    lblxpassword1.Visible = false;
                    if (txtCnfrmPassword.Text == string.Empty)
                    {
                        MessageBox.Show("Please confirm your password");
                        lblxCnfrmpassword.Visible = true;
                    }
                    else
                    {
                        lblxCnfrmpassword.Visible = false;
                        if (txtPassword.Text != txtCnfrmPassword.Text)
                        {
                            MessageBox.Show("Your passwords do not match");
                            lblxpassword1.Visible = true;
                            lblxCnfrmpassword.Visible = true;
                        }
                        else
                        {
                            lblxpassword1.Visible = false;
                            lblxCnfrmpassword.Visible = false;
                            if (combaccrcvQ.SelectedIndex < 0)
                            {
                                MessageBox.Show("Please select an account recovery question");
                                lblxaccrq.Visible = true;
                            }
                            else
                            {
                                lblxaccrq.Visible = false;
                                if (txtaccrevryQAns.Text == string.Empty)
                                {
                                    MessageBox.Show("Please answer your recovery question");
                                    lblxaccrA.Visible = true;
                                }
                                else
                                {
                                    lblxaccrA.Visible = false;
                                    if (picbxselectedavatar.Image == null)
                                    {
                                        MessageBox.Show("please select an avatar and drag into into the red highlighted box");
                                        picbxselectedavatar.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        Array.Resize(ref players, players.Length + 1);
                                        newplayer.Name = txtUsername.Text;
                                        newplayer.Password = txtPassword.Text;
                                        newplayer.Security_Question = combaccrcvQ.SelectedIndex;
                                        newplayer.Security_Answer = txtaccrevryQAns.Text;
                                        newplayer.avatar_numbers = avatar_number;

                                        players[players.Length - 1] = newplayer;

                                        Program.SaveObject(players);
                                        Form quizlists = new quizlists(ref newplayer);
                                        quizlists.Show();
                                        this.Hide();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            

        }
        private void frmCreatenewaccount_Load(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form help = new frmcreateacchelpscreen();
            help.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLOgin_Click(object sender, EventArgs e)
        {
            Form lgin = new frmlogin();
            lgin.Show();
            this.Hide();
        }

       
    }
}
