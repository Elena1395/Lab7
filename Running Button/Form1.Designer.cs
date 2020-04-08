namespace Lab7
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
            this.btn_R = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_R
            // 
            this.btn_R.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_R.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_R.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_R.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_R.Location = new System.Drawing.Point(208, 179);
            this.btn_R.Name = "btn_R";
            this.btn_R.Size = new System.Drawing.Size(58, 23);
            this.btn_R.TabIndex = 0;
            this.btn_R.Text = "Push me";
            this.btn_R.UseVisualStyleBackColor = false;
            this.btn_R.Click += new System.EventHandler(this.btn_R_Click);
            this.btn_R.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_R_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 381);
            this.Controls.Add(this.btn_R);
            this.MinimumSize = new System.Drawing.Size(490, 420);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Running Button";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_R;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

