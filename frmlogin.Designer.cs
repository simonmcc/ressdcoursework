namespace quizv4
{
    partial class frmlogin
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.paswordlbl = new System.Windows.Forms.Label();
            this.notbot_checklbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.proofofhumantxt = new System.Windows.Forms.TextBox();
            this.help_frmloginbtn = new System.Windows.Forms.Button();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.lblXathuman = new System.Windows.Forms.Label();
            this.lblxusername = new System.Windows.Forms.Label();
            this.lblxpassword = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(74, 45);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(73, 92);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 1;
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Location = new System.Drawing.Point(12, 48);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(56, 13);
            this.usernamelbl.TabIndex = 2;
            this.usernamelbl.Text = "username ";
            // 
            // paswordlbl
            // 
            this.paswordlbl.AutoSize = true;
            this.paswordlbl.Location = new System.Drawing.Point(12, 99);
            this.paswordlbl.Name = "paswordlbl";
            this.paswordlbl.Size = new System.Drawing.Size(53, 13);
            this.paswordlbl.TabIndex = 3;
            this.paswordlbl.Text = "Password";
            // 
            // notbot_checklbl
            // 
            this.notbot_checklbl.AutoSize = true;
            this.notbot_checklbl.Font = new System.Drawing.Font("Jokerman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notbot_checklbl.Location = new System.Drawing.Point(75, 164);
            this.notbot_checklbl.Name = "notbot_checklbl";
            this.notbot_checklbl.Size = new System.Drawing.Size(83, 31);
            this.notbot_checklbl.TabIndex = 4;
            this.notbot_checklbl.Text = "7pyr4";
            this.notbot_checklbl.TextChanged += new System.EventHandler(this.notbot_checklbl_TextChanged);
            this.notbot_checklbl.Click += new System.EventHandler(this.notbot_checklbl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prove you are human";
            // 
            // proofofhumantxt
            // 
            this.proofofhumantxt.Location = new System.Drawing.Point(36, 201);
            this.proofofhumantxt.Name = "proofofhumantxt";
            this.proofofhumantxt.Size = new System.Drawing.Size(176, 20);
            this.proofofhumantxt.TabIndex = 6;
            this.proofofhumantxt.Text = "please enter the characters above";
            this.proofofhumantxt.Click += new System.EventHandler(this.proofofhumantxt_Click);
            this.proofofhumantxt.DoubleClick += new System.EventHandler(this.proofofhumantxt_DoubleClick);
            // 
            // help_frmloginbtn
            // 
            this.help_frmloginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.help_frmloginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.help_frmloginbtn.Location = new System.Drawing.Point(215, 1);
            this.help_frmloginbtn.Name = "help_frmloginbtn";
            this.help_frmloginbtn.Size = new System.Drawing.Size(75, 23);
            this.help_frmloginbtn.TabIndex = 7;
            this.help_frmloginbtn.Text = "?";
            this.help_frmloginbtn.UseVisualStyleBackColor = false;
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(73, 238);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(106, 23);
            this.Loginbtn.TabIndex = 8;
            this.Loginbtn.Text = "LOGIN";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // lblXathuman
            // 
            this.lblXathuman.AutoSize = true;
            this.lblXathuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXathuman.ForeColor = System.Drawing.Color.Red;
            this.lblXathuman.Location = new System.Drawing.Point(230, 201);
            this.lblXathuman.Name = "lblXathuman";
            this.lblXathuman.Size = new System.Drawing.Size(19, 18);
            this.lblXathuman.TabIndex = 9;
            this.lblXathuman.Text = "X";
            this.lblXathuman.Visible = false;
            // 
            // lblxusername
            // 
            this.lblxusername.AutoSize = true;
            this.lblxusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxusername.ForeColor = System.Drawing.Color.Red;
            this.lblxusername.Location = new System.Drawing.Point(193, 48);
            this.lblxusername.Name = "lblxusername";
            this.lblxusername.Size = new System.Drawing.Size(19, 18);
            this.lblxusername.TabIndex = 10;
            this.lblxusername.Text = "X";
            this.lblxusername.Visible = false;
            // 
            // lblxpassword
            // 
            this.lblxpassword.AutoSize = true;
            this.lblxpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxpassword.ForeColor = System.Drawing.Color.Red;
            this.lblxpassword.Location = new System.Drawing.Point(193, 92);
            this.lblxpassword.Name = "lblxpassword";
            this.lblxpassword.Size = new System.Drawing.Size(19, 18);
            this.lblxpassword.TabIndex = 11;
            this.lblxpassword.Text = "X";
            this.lblxpassword.Visible = false;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnback.Location = new System.Drawing.Point(12, 1);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 38);
            this.btnback.TabIndex = 12;
            this.btnback.Text = "Create\r\naccount";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblxpassword);
            this.Controls.Add(this.lblxusername);
            this.Controls.Add(this.lblXathuman);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.help_frmloginbtn);
            this.Controls.Add(this.proofofhumantxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notbot_checklbl);
            this.Controls.Add(this.paswordlbl);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Name = "frmlogin";
            this.Text = "frmlogin";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label paswordlbl;
        private System.Windows.Forms.Label notbot_checklbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox proofofhumantxt;
        private System.Windows.Forms.Button help_frmloginbtn;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label lblXathuman;
        private System.Windows.Forms.Label lblxusername;
        private System.Windows.Forms.Label lblxpassword;
        private System.Windows.Forms.Button btnback;
    }
}