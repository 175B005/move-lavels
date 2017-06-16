using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace move_lavels
{
    public partial class Form1 : Form
    {
        int vx = -20, vy = -20;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Point cpos;
            cpos = PointToClient(MousePosition);
            //formに変換、VRとかで触ったりもこれ（２ｄなので、座標同士引いているだけ）

            //formの左上↓
            label2.Text = "" + cpos.X + "," + cpos.Y;
            //window(スクリーン)の左上↓（絶対の座標）
            label3.Text = "" + MousePosition.X + "," + MousePosition.Y;


            //ennsyuu10
            label4.Left = cpos.X - label4.Width/2;
            label4.Top = cpos.Y - label4.Height/2;



            label1.Left += vx;
            label1.Top += vy;
            //Math絶対値を取る
            if (label1.Left <= 0)
                vx = Math.Abs(vx);
            if (label1.Top <= 0)
                vy = Math.Abs(vy);
            if (label1.Left >= ClientSize.Width - label1.Width)
                vx = -Math.Abs(vx);
            if (label1.Top >= ClientSize.Height - label1.Height)
                vy = -Math.Abs(vy);
        }

        private void label1_Click(object sender, EventArgs e)
        {

       }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


    }
}
