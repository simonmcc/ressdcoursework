using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace quizv4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Launch splash screen
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();

            //Return to frmMain after 4.5 seconds
            Thread.Sleep(4500);
            InitializeComponent();
            t.Abort();
        }

        public void SplashStart()
        {
            //Run splash screen
            Application.Run(new splashscreen3());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form account = new frmCreatenewaccount();
            account.Show();
            this.Hide();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form login = new frmlogin();
            login.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
