using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Picker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ChangeColor();
        }



        private void trackBar_Red_Scroll(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void trackBar_Green_Scroll(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void trackBar_Blue_Scroll(object sender, EventArgs e)
        {
            ChangeColor();
        }
        public void ChangeColor() {
           // Color с = Color.FromArgb(trackBar_Red.Value, trackBar_Green.Value, trackBar_Blue.Value);
            pictureBox1.BackColor = Color.FromArgb(trackBar_Red.Value, trackBar_Green.Value, trackBar_Blue.Value);
            label_ValueRed.Text = trackBar_Red.Value.ToString();
            label_ValueGreen.Text = trackBar_Green.Value.ToString();
            label_ValueBlue.Text = trackBar_Blue.Value.ToString();

            string Text = "#"+trackBar_Red.Value.ToString("X") + trackBar_Green.Value.ToString("X") + trackBar_Blue.Value.ToString("X");
            Clipboard.Clear();
            Clipboard.SetText(Text);

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox1, Clipboard.GetText());
        }
    }
}
