namespace quizv4
{
    partial class landmarksquizQ1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(landmarksquizQ1));
            this.backbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnbeginquiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.backbtn.Location = new System.Drawing.Point(77, 378);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(289, 23);
            this.backbtn.TabIndex = 1;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exitbtn.Location = new System.Drawing.Point(77, 26);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(289, 23);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(2, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(426, 351);
            this.button3.TabIndex = 8;
            this.button3.Text = "Begin Quiz";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnbeginquiz
            // 
            this.btnbeginquiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbeginquiz.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnbeginquiz.Image = ((System.Drawing.Image)(resources.GetObject("btnbeginquiz.Image")));
            this.btnbeginquiz.Location = new System.Drawing.Point(77, 99);
            this.btnbeginquiz.Name = "btnbeginquiz";
            this.btnbeginquiz.Size = new System.Drawing.Size(289, 242);
            this.btnbeginquiz.TabIndex = 3;
            this.btnbeginquiz.Text = "Begin Quiz";
            this.btnbeginquiz.UseVisualStyleBackColor = true;
            this.btnbeginquiz.Click += new System.EventHandler(this.button3_Click);
            // 
            // landmarksquizQ1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(447, 428);
            this.Controls.Add(this.btnbeginquiz);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.backbtn);
            this.Name = "landmarksquizQ1";
            this.Text = "landmarksquizQ1";
            this.Load += new System.EventHandler(this.landmarksquizQ1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnbeginquiz;
    }
}