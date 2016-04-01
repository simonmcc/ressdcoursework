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
    public partial class landmarksquizQ4 : Form
    {
        public landmarksquizQ4()
        {
            InitializeComponent();
            
            TrackBar tbarq4 = new TrackBar();
 

        }

        private void tbarq4_Scroll(object sender, EventArgs e)
        {
            int trys=0;
            this.tbarq4.Scroll += new System.EventHandler(this.tbarq4_Scroll);
            while (trys<=3)
            {
                if(tbarq4.Value == 1)
                {
                    MessageBox.Show("the 1500s");
                    trys++;

                }
            

            }
        }

    }
}
