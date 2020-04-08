using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_R_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы смогли нажать на кнопку!");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Point p = this.PointToClient(Cursor.Position);

            int x = e.X;
            int y = e.Y;
            int d1 = 1;//смещение кнопки
            int dd1 = 20;//диапазон для попадания курсора от границы кнопки
            int d2 = 1;
            int dd2 = 25;

            //textBox2.Text = x.ToString();
            //textBox3.Text = y.ToString();
            //textBox1.Text += "===\r\n" + btn_R.Left.ToString() + ", ";
            //textBox1.Text += btn_R.Right.ToString() + ", ";
            //textBox1.Text += Height.ToString() + ", ";
            //textBox1.Text += Width.ToString() + "\r\n";

            if (x >= btn_R.Left - dd1 && x <= btn_R.Right + dd1 && y >= btn_R.Top - dd1 && y <= btn_R.Bottom + dd1) {
                ChangeCoord(x,y, dd1, d1);
            }
            else if (x >= btn_R.Left - dd2 && x <= btn_R.Right + dd2 && y >= btn_R.Top - dd2 && y <= btn_R.Bottom + dd2){
                ChangeCoord(x,y, dd2, d2);
            }
        }

        public void ChangeCoord(int x, int y, int dd, int d) {
            //int x = e.X;
            //int y = e.Y;

            //Поправки для границ формы
            int dx = 18;
            int dy = 40;

            //Границы формы
            int Width = this.Width - dx;
            int Height = this.Height - dy;

            if (x >= btn_R.Left - dd && x <= btn_R.Right + dd && btn_R.Right <= Width && btn_R.Left >= 0)
            {
                if (x >= btn_R.Left - dd && (x <= btn_R.Left/* + btn_R.Width / 2*/))
                {
                    btn_R.Left = btn_R.Left + d;
                }
                if (btn_R.Right >= Width)
                {
                    btn_R.Left = 1;
                }
                if (x <= btn_R.Right + dd && (x >= btn_R.Right /*+ btn_R.Width / 2*/))
                {
                    btn_R.Left = btn_R.Left - d;
                }
                if (btn_R.Left <= 0)
                {
                    btn_R.Left = Width - btn_R.Width - 1;
                }
            }
            if (y >= btn_R.Top - dd && y <= btn_R.Bottom + dd && btn_R.Top >= 0 && btn_R.Bottom <= Height)
            {
                if (y <= btn_R.Bottom + dd && (y >= btn_R.Bottom /*- btn_R.Height / 2*/))
                {
                    btn_R.Top = btn_R.Top - d;
                }
                if (btn_R.Top <= 0)
                {
                    btn_R.Top = Height - btn_R.Height - 2;
                }
                if (y >= btn_R.Top - dd && (y <= btn_R.Top /*+ btn_R.Height / 2*/))
                {
                    btn_R.Top = btn_R.Top + d;
                }
                if (btn_R.Bottom >= Height)
                {
                    btn_R.Top = 2;
                }
            }
        }

        private void btn_R_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
