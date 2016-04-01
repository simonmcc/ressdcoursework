namespace quizv4
{
    partial class quizlists
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
            this.Landmarksbtn = new System.Windows.Forms.Button();
            this.sportscelebritiesbtn = new System.Windows.Forms.Button();
            this.Moviesbtn = new System.Windows.Forms.Button();
            this.anagramsbtn = new System.Windows.Forms.Button();
            this.quizlistlbl = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnendprogram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Landmarksbtn
            // 
            this.Landmarksbtn.BackColor = System.Drawing.Color.Transparent;
            this.Landmarksbtn.Location = new System.Drawing.Point(12, 94);
            this.Landmarksbtn.Name = "Landmarksbtn";
            this.Landmarksbtn.Size = new System.Drawing.Size(139, 99);
            this.Landmarksbtn.TabIndex = 0;
            this.Landmarksbtn.Text = "Landmarks";
            this.Landmarksbtn.UseVisualStyleBackColor = false;
            this.Landmarksbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // sportscelebritiesbtn
            // 
            this.sportscelebritiesbtn.Location = new System.Drawing.Point(193, 94);
            this.sportscelebritiesbtn.Name = "sportscelebritiesbtn";
            this.sportscelebritiesbtn.Size = new System.Drawing.Size(139, 99);
            this.sportscelebritiesbtn.TabIndex = 1;
            this.sportscelebritiesbtn.Text = "Sports Celebrities";
            this.sportscelebritiesbtn.UseVisualStyleBackColor = true;
            // 
            // Moviesbtn
            // 
            this.Moviesbtn.Location = new System.Drawing.Point(12, 238);
            this.Moviesbtn.Name = "Moviesbtn";
            this.Moviesbtn.Size = new System.Drawing.Size(139, 99);
            this.Moviesbtn.TabIndex = 2;
            this.Moviesbtn.Text = "Movies";
            this.Moviesbtn.UseVisualStyleBackColor = true;
            // 
            // anagramsbtn
            // 
            this.anagramsbtn.Location = new System.Drawing.Point(193, 238);
            this.anagramsbtn.Name = "anagramsbtn";
            this.anagramsbtn.Size = new System.Drawing.Size(139, 99);
            this.anagramsbtn.TabIndex = 3;
            this.anagramsbtn.Text = "Anagrams";
            this.anagramsbtn.UseVisualStyleBackColor = true;
            // 
            // quizlistlbl
            // 
            this.quizlistlbl.AutoSize = true;
            this.quizlistlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.quizlistlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizlistlbl.Location = new System.Drawing.Point(112, 43);
            this.quizlistlbl.Name = "quizlistlbl";
            this.quizlistlbl.Size = new System.Drawing.Size(122, 33);
            this.quizlistlbl.TabIndex = 5;
            this.quizlistlbl.Text = "Quiz List";
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(271, 13);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnendprogram
            // 
            this.btnendprogram.Location = new System.Drawing.Point(13, 13);
            this.btnendprogram.Name = "btnendprogram";
            this.btnendprogram.Size = new System.Drawing.Size(75, 23);
            this.btnendprogram.TabIndex = 7;
            this.btnendprogram.Text = "Exit";
            this.btnendprogram.UseVisualStyleBackColor = true;
            this.btnendprogram.Click += new System.EventHandler(this.btnendprogram_Click);
            // 
            // quizlists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 370);
            this.Controls.Add(this.btnendprogram);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.quizlistlbl);
            this.Controls.Add(this.anagramsbtn);
            this.Controls.Add(this.Moviesbtn);
            this.Controls.Add(this.sportscelebritiesbtn);
            this.Controls.Add(this.Landmarksbtn);
            this.Name = "quizlists";
            this.Text = "quizlists";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Landmarksbtn;
        private System.Windows.Forms.Button sportscelebritiesbtn;
        private System.Windows.Forms.Button Moviesbtn;
        private System.Windows.Forms.Button anagramsbtn;
        private System.Windows.Forms.Label quizlistlbl;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnendprogram;
    }
}