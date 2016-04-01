namespace quizv4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btncreateaccount = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.timtimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btncreateaccount
            // 
            this.btncreateaccount.Location = new System.Drawing.Point(36, 99);
            this.btncreateaccount.Name = "btncreateaccount";
            this.btncreateaccount.Size = new System.Drawing.Size(82, 66);
            this.btncreateaccount.TabIndex = 0;
            this.btncreateaccount.Text = "Create Account";
            this.btncreateaccount.UseVisualStyleBackColor = true;
            this.btncreateaccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(167, 99);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 66);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "~Login~";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // timtimer
            // 
            this.timtimer.Interval = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btncreateaccount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncreateaccount;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Timer timtimer;
    }
}

