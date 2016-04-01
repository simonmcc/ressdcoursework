namespace quizv4
{
    partial class landmarksquizQ4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(landmarksquizQ4));
            this.picbxstatueoflibert = new System.Windows.Forms.PictureBox();
            this.tbarq4 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblvaluetrbar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbxstatueoflibert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarq4)).BeginInit();
            this.SuspendLayout();
            // 
            // picbxstatueoflibert
            // 
            this.picbxstatueoflibert.Image = ((System.Drawing.Image)(resources.GetObject("picbxstatueoflibert.Image")));
            this.picbxstatueoflibert.Location = new System.Drawing.Point(127, 32);
            this.picbxstatueoflibert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picbxstatueoflibert.Name = "picbxstatueoflibert";
            this.picbxstatueoflibert.Size = new System.Drawing.Size(316, 244);
            this.picbxstatueoflibert.TabIndex = 0;
            this.picbxstatueoflibert.TabStop = false;
            // 
            // tbarq4
            // 
            this.tbarq4.LargeChange = 100;
            this.tbarq4.Location = new System.Drawing.Point(127, 346);
            this.tbarq4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbarq4.Maximum = 5;
            this.tbarq4.Minimum = 1;
            this.tbarq4.Name = "tbarq4";
            this.tbarq4.Size = new System.Drawing.Size(316, 56);
            this.tbarq4.TabIndex = 1;
            this.tbarq4.Value = 2;
            this.tbarq4.Scroll += new System.EventHandler(this.tbarq4_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(28, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "What century did construction start on this statue";
            // 
            // lblvaluetrbar
            // 
            this.lblvaluetrbar.AutoSize = true;
            this.lblvaluetrbar.Location = new System.Drawing.Point(261, 414);
            this.lblvaluetrbar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvaluetrbar.Name = "lblvaluetrbar";
            this.lblvaluetrbar.Size = new System.Drawing.Size(0, 17);
            this.lblvaluetrbar.TabIndex = 4;
            // 
            // landmarksquizQ4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 527);
            this.Controls.Add(this.lblvaluetrbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbarq4);
            this.Controls.Add(this.picbxstatueoflibert);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "landmarksquizQ4";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.picbxstatueoflibert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarq4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxstatueoflibert;
        private System.Windows.Forms.TrackBar tbarq4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblvaluetrbar;
    }
}