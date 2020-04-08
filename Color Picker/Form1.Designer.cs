namespace Color_Picker
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
            this.trackBar_Red = new System.Windows.Forms.TrackBar();
            this.trackBar_Green = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar_Blue = new System.Windows.Forms.TrackBar();
            this.label_Red = new System.Windows.Forms.Label();
            this.label_Green = new System.Windows.Forms.Label();
            this.label_Blue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_ValueRed = new System.Windows.Forms.Label();
            this.label_ValueGreen = new System.Windows.Forms.Label();
            this.label_ValueBlue = new System.Windows.Forms.Label();
            this.label_RedMinValue = new System.Windows.Forms.Label();
            this.label_RedMaxValue = new System.Windows.Forms.Label();
            this.label_GreenMinValue = new System.Windows.Forms.Label();
            this.label_BlueMinValue = new System.Windows.Forms.Label();
            this.label_GreenMaxValue = new System.Windows.Forms.Label();
            this.label_BlueMaxValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Blue)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar_Red
            // 
            this.trackBar_Red.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.trackBar_Red, 2);
            this.trackBar_Red.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_Red.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_Red.Location = new System.Drawing.Point(229, 28);
            this.trackBar_Red.Maximum = 255;
            this.trackBar_Red.Name = "trackBar_Red";
            this.trackBar_Red.Size = new System.Drawing.Size(222, 29);
            this.trackBar_Red.TabIndex = 0;
            this.trackBar_Red.Tag = "";
            this.trackBar_Red.TickFrequency = 15;
            this.trackBar_Red.Value = 125;
            this.trackBar_Red.Scroll += new System.EventHandler(this.trackBar_Red_Scroll);
            // 
            // trackBar_Green
            // 
            this.trackBar_Green.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.trackBar_Green, 2);
            this.trackBar_Green.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_Green.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_Green.Location = new System.Drawing.Point(229, 113);
            this.trackBar_Green.Maximum = 255;
            this.trackBar_Green.Name = "trackBar_Green";
            this.trackBar_Green.Size = new System.Drawing.Size(222, 29);
            this.trackBar_Green.TabIndex = 2;
            this.trackBar_Green.Tag = "";
            this.trackBar_Green.TickFrequency = 15;
            this.trackBar_Green.Value = 125;
            this.trackBar_Green.Scroll += new System.EventHandler(this.trackBar_Green_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 9);
            this.pictureBox1.Size = new System.Drawing.Size(175, 255);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // trackBar_Blue
            // 
            this.trackBar_Blue.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.trackBar_Blue, 2);
            this.trackBar_Blue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_Blue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_Blue.Location = new System.Drawing.Point(229, 198);
            this.trackBar_Blue.Maximum = 255;
            this.trackBar_Blue.Name = "trackBar_Blue";
            this.trackBar_Blue.Size = new System.Drawing.Size(222, 29);
            this.trackBar_Blue.TabIndex = 3;
            this.trackBar_Blue.Tag = "";
            this.trackBar_Blue.TickFrequency = 15;
            this.trackBar_Blue.Value = 125;
            this.trackBar_Blue.Scroll += new System.EventHandler(this.trackBar_Blue_Scroll);
            // 
            // label_Red
            // 
            this.label_Red.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Red.AutoSize = true;
            this.label_Red.Location = new System.Drawing.Point(190, 36);
            this.label_Red.Name = "label_Red";
            this.label_Red.Size = new System.Drawing.Size(27, 13);
            this.label_Red.TabIndex = 5;
            this.label_Red.Text = "Red";
            // 
            // label_Green
            // 
            this.label_Green.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Green.AutoSize = true;
            this.label_Green.Location = new System.Drawing.Point(185, 121);
            this.label_Green.Name = "label_Green";
            this.label_Green.Size = new System.Drawing.Size(36, 13);
            this.label_Green.TabIndex = 7;
            this.label_Green.Text = "Green";
            // 
            // label_Blue
            // 
            this.label_Blue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Blue.AutoSize = true;
            this.label_Blue.Location = new System.Drawing.Point(189, 206);
            this.label_Blue.Name = "label_Blue";
            this.label_Blue.Size = new System.Drawing.Size(28, 13);
            this.label_Blue.TabIndex = 8;
            this.label_Blue.Text = "Blue";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.trackBar_Red, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Blue, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.trackBar_Green, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_Green, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_Red, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.trackBar_Blue, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label_ValueRed, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_ValueGreen, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_ValueBlue, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label_RedMinValue, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_RedMaxValue, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_GreenMinValue, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label_BlueMinValue, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label_GreenMaxValue, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label_BlueMaxValue, 3, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.951028F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.43128F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.951028F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.951028F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.43128F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.951028F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.951028F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.43128F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.951028F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 261);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label_ValueRed
            // 
            this.label_ValueRed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ValueRed.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_ValueRed, 2);
            this.label_ValueRed.Location = new System.Drawing.Point(327, 6);
            this.label_ValueRed.Name = "label_ValueRed";
            this.label_ValueRed.Size = new System.Drawing.Size(25, 13);
            this.label_ValueRed.TabIndex = 9;
            this.label_ValueRed.Text = "125";
            // 
            // label_ValueGreen
            // 
            this.label_ValueGreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ValueGreen.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_ValueGreen, 2);
            this.label_ValueGreen.Location = new System.Drawing.Point(327, 91);
            this.label_ValueGreen.Name = "label_ValueGreen";
            this.label_ValueGreen.Size = new System.Drawing.Size(25, 13);
            this.label_ValueGreen.TabIndex = 10;
            this.label_ValueGreen.Text = "125";
            // 
            // label_ValueBlue
            // 
            this.label_ValueBlue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ValueBlue.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_ValueBlue, 2);
            this.label_ValueBlue.Location = new System.Drawing.Point(327, 176);
            this.label_ValueBlue.Name = "label_ValueBlue";
            this.label_ValueBlue.Size = new System.Drawing.Size(25, 13);
            this.label_ValueBlue.TabIndex = 11;
            this.label_ValueBlue.Text = "125";
            // 
            // label_RedMinValue
            // 
            this.label_RedMinValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_RedMinValue.AutoSize = true;
            this.label_RedMinValue.Location = new System.Drawing.Point(229, 66);
            this.label_RedMinValue.Name = "label_RedMinValue";
            this.label_RedMinValue.Size = new System.Drawing.Size(13, 13);
            this.label_RedMinValue.TabIndex = 12;
            this.label_RedMinValue.Text = "0";
            // 
            // label_RedMaxValue
            // 
            this.label_RedMaxValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_RedMaxValue.AutoSize = true;
            this.label_RedMaxValue.Location = new System.Drawing.Point(426, 66);
            this.label_RedMaxValue.Name = "label_RedMaxValue";
            this.label_RedMaxValue.Size = new System.Drawing.Size(25, 13);
            this.label_RedMaxValue.TabIndex = 13;
            this.label_RedMaxValue.Text = "255";
            // 
            // label_GreenMinValue
            // 
            this.label_GreenMinValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_GreenMinValue.AutoSize = true;
            this.label_GreenMinValue.Location = new System.Drawing.Point(229, 151);
            this.label_GreenMinValue.Name = "label_GreenMinValue";
            this.label_GreenMinValue.Size = new System.Drawing.Size(13, 13);
            this.label_GreenMinValue.TabIndex = 14;
            this.label_GreenMinValue.Text = "0";
            // 
            // label_BlueMinValue
            // 
            this.label_BlueMinValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_BlueMinValue.AutoSize = true;
            this.label_BlueMinValue.Location = new System.Drawing.Point(229, 239);
            this.label_BlueMinValue.Name = "label_BlueMinValue";
            this.label_BlueMinValue.Size = new System.Drawing.Size(13, 13);
            this.label_BlueMinValue.TabIndex = 15;
            this.label_BlueMinValue.Text = "0";
            // 
            // label_GreenMaxValue
            // 
            this.label_GreenMaxValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_GreenMaxValue.AutoSize = true;
            this.label_GreenMaxValue.Location = new System.Drawing.Point(426, 151);
            this.label_GreenMaxValue.Name = "label_GreenMaxValue";
            this.label_GreenMaxValue.Size = new System.Drawing.Size(25, 13);
            this.label_GreenMaxValue.TabIndex = 16;
            this.label_GreenMaxValue.Text = "255";
            // 
            // label_BlueMaxValue
            // 
            this.label_BlueMaxValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_BlueMaxValue.AutoSize = true;
            this.label_BlueMaxValue.Location = new System.Drawing.Point(426, 239);
            this.label_BlueMaxValue.Name = "label_BlueMaxValue";
            this.label_BlueMaxValue.Size = new System.Drawing.Size(25, 13);
            this.label_BlueMaxValue.TabIndex = 17;
            this.label_BlueMaxValue.Text = "255";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(470, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Blue)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBar_Red;
        private System.Windows.Forms.TrackBar trackBar_Green;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar_Blue;
        private System.Windows.Forms.Label label_Red;
        private System.Windows.Forms.Label label_Blue;
        private System.Windows.Forms.Label label_Green;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_ValueRed;
        private System.Windows.Forms.Label label_ValueGreen;
        private System.Windows.Forms.Label label_ValueBlue;
        private System.Windows.Forms.Label label_RedMinValue;
        private System.Windows.Forms.Label label_RedMaxValue;
        private System.Windows.Forms.Label label_GreenMinValue;
        private System.Windows.Forms.Label label_BlueMinValue;
        private System.Windows.Forms.Label label_GreenMaxValue;
        private System.Windows.Forms.Label label_BlueMaxValue;
    }
}

