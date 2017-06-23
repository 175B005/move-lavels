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
        private static Random rand = new Random();
        //ランダムを作成

        int[] vx = new int[3];//0~2の3個
        int[] vy = new int[3];

        double iTime = 60;

        Point cpos;

        public Form1()
        {
            InitializeComponent();
            int idx;
            for (idx = 0; idx < 3; idx++)
            {
                vx[idx] += rand.Next(10, 30);
                vy[idx] -= rand.Next(10, 30);
            }
            /*vx[0] += rand.Next(10, 30);
            vy[0] -= rand.Next(10, 30);
            vx[1] += rand.Next(10, 30);
            vy[1]-= rand.Next(10, 30);
            vx[2] += rand.Next(10, 30);
            vy[2] -= rand.Next(10, 30);*/

            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);

            label6.Left = rand.Next(ClientSize.Width - label6.Width);
            label6.Top = rand.Next(ClientSize.Height - label6.Height);

            label7.Left = rand.Next(ClientSize.Width - label7.Width);
            label7.Top = rand.Next(ClientSize.Height - label7.Height);

        }

        //↓元のprog
        void copy0()
        {

            if (label1.Left <= cpos.X && cpos.X <= label1.Right)
                if (label1.Top <= cpos.Y && cpos.Y <= label1.Bottom)
                {
                    label1.Visible = false;
                    // timer1.Enabled = false;
                    label1.Text = "__(~o~)__";
                    // MessageBox.Show("gameover!!!!\n");
                }

            label1.Left += vx[0];
            label1.Top += vy[0];
            //Math絶対値を取る
            if (label1.Left <= 0)
                vx[0] = Math.Abs(vx[0]);
            if (label1.Top <= 0)
                vy[0] = Math.Abs(vy[0]);
            if (label1.Left >= ClientSize.Width - label1.Width)
                vx[0] = -Math.Abs(vx[0]);
            if (label1.Top >= ClientSize.Height - label1.Height)
                vy[0] = -Math.Abs(vy[0]);
        }
        void copy1()
        {

            if (label6.Left <= cpos.X && cpos.X <= label6.Right)
                if (label6.Top <= cpos.Y && cpos.Y <= label6.Bottom)
                {
                   // timer1.Enabled = false;
                    label6.Visible = false;
                    
                  //  MessageBox.Show("gameover!!!!\n");
                }
            label6.Left += vx[1];
            label6.Top += vy[1];
            if (label6.Left <= 0)
                vx[1] = Math.Abs(vx[1]);
            if (label6.Top <= 0)
                vy[1] = Math.Abs(vx[1]);
            if (label6.Left >= ClientSize.Width - label6.Width)
                vx[1] = -Math.Abs(vx[1]);
            if (label6.Top >= ClientSize.Height - label6.Height)
                vy[1] = -Math.Abs(vx[1]);

        }
        void copy2()
        {

            if (label7.Left <= cpos.X && cpos.X <= label7.Right)
                if (label7.Top <= cpos.Y && cpos.Y <= label7.Bottom)
                {
                   // timer1.Enabled = false;
                    label7.Visible = false;
                
                    //MessageBox.Show("gameover!!!!\n");
                }
            label7.Left += vx[2];
            label7.Top += vy[2];
            //Math絶対値を取る
            if (label7.Left <= 0)
                vx[2] = Math.Abs(vx[2]);
            if (label7.Top <= 0)
                vy[2] = Math.Abs(vy[2]);
            if (label7.Left >= ClientSize.Width - label1.Width)
                vx[2] = -Math.Abs(vx[2]);
            if (label7.Top >= ClientSize.Height - label1.Height)
                vy[2] = -Math.Abs(vy[2]);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            iTime -= 0.5;
            label5.Text = "" + (int)iTime;
            if (iTime <= 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("timeover!!!!\n");
            }
            cpos = PointToClient(MousePosition);
            //formに変換、VRとかで触ったりもこれ（２ｄなので、座標同士引いているだけ）

            //formの左上↓
            label2.Text = "" + cpos.X + "," + cpos.Y;
            //window(スクリーン)の左上↓（絶対の座標）
            label3.Text = "" + MousePosition.X + "," + MousePosition.Y;


            //演習10
            label4.Left = cpos.X - label4.Width/2;
            label4.Top = cpos.Y - label4.Height/2;
            //(オフセット移動値、ピボット原点(pivot))

            //if練習その２


            copy1();
            copy2();
            copy0();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Text = "" + rand.Next();
            //さいころex↓
           // Text += "," + ((rand.Next() % 6) + 1);
            
            //０以上指定の値未満の乱数
            //Text += "/" + rand.Next(6);
           // Text += "/" + rand.Next(1,7);//1~7まで
            
            //doubleで小数を求めた上で、最大最小を考える
            //０．９９９＊６でも最大は６未満になるから↓
            Text = "/" + (int)(rand.NextDouble() * 6 +1);


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


    }
}
