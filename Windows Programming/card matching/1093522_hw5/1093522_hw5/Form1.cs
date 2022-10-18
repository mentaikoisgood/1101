using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace _1093522_hw5
{
    public partial class Form1 : Form
    {
        int time = 0;

        Bitmap[] myBitmap = new Bitmap[8];
        int[] card = new int[16];
        Random rd = new Random();

        int First_Second = 1;
        int FirstCardNo;
        Panel FirstCardPanel;

        int Good = 0; //猜對次數

        public Form1()
        {
            InitializeComponent();
            myBitmap[0] = Properties.Resources.Apple;
            myBitmap[1] = Properties.Resources.Banana;
            myBitmap[2] = Properties.Resources.Cherry;
            myBitmap[3] = Properties.Resources.Grape;
            myBitmap[4] = Properties.Resources.Orange;
            myBitmap[5] = Properties.Resources.PineApple;
            myBitmap[6] = Properties.Resources.Tomato;
            myBitmap[7] = Properties.Resources.Watermelon;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label1.Text = "" + time +" Seconds"; 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int temp, t1, t2;


            //排好16張牌的圖形編號
            for (int i=0;  i<16; i++)
            {
                card[i] = i % 8;
            }

            //兩兩打亂
            for (int i=0;  i<100; i++)
            {
                t1 = rd.Next(16);
                t2 = rd.Next(16);
                temp = card[t1];
                card[t1] = card[t2];
                card[t2] = temp;
            }

            timer1.Start();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            time = 0;
            int temp, t1, t2;
            Good = 0;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Panel)
                {
                    ((Panel)ctrl).BackgroundImage = Properties.Resources.Cover;
                    ((Panel)ctrl).Enabled = true;
                }
            }

            //排好16張牌的圖形編號
            for (int i = 0; i < 16; i++)
            {
                card[i] = i % 8;
            }

            //兩兩打亂
            for (int i = 0; i < 100; i++)
            {
                t1 = rd.Next(16);
                t2 = rd.Next(16);
                temp = card[t1];
                card[t1] = card[t2];
                card[t2] = temp;
            }

            timer1.Start();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel0.ClientRectangle,
            Color.Black, 2, ButtonBorderStyle.Solid,  //左
            Color.Black, 2, ButtonBorderStyle.Solid,  //上
            Color.Black, 2, ButtonBorderStyle.Solid,  //右
            Color.Black, 2, ButtonBorderStyle.Solid); //下
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //Panel 0-15
            //CardNo 0-15
            Panel PanelX = (Panel)sender;
            int CardNo = Convert.ToInt32(PanelX.Tag); //第幾張牌 0-15

            PanelX.BackgroundImage = myBitmap[card[CardNo]]; //第幾張牌的圖形
            PanelX.Enabled = false;  //不能再翻
            PanelX.Refresh();

            if (First_Second == 1) //按第一次
            {
                FirstCardNo = card[CardNo]; //紀錄第一次翻牌的圖形編號
                FirstCardPanel = PanelX;

                First_Second = 2;
            }

            else //是按第二次
            {
                if (card[CardNo] == FirstCardNo )   //第一次翻牌和第二次翻牌的圖形編號是一樣的
                {
                    PanelX.Enabled = false; //設定不能再翻牌
                    FirstCardPanel.Enabled = false;
                    Good++; // 猜對次數加一

                    if (Good == 8)
                    {
                        timer1.Stop(); //猜對8次就結束
                    }
                }

                else //2次翻牌不一致
                {

                    Thread.Sleep(1000);  //停1秒

                    //回復第一二次Panel封面
                    FirstCardPanel.BackgroundImage = Properties.Resources.Cover;
                    PanelX.BackgroundImage = Properties.Resources.Cover;

                    FirstCardPanel.Enabled = true;
                    PanelX.Enabled = true;
                }

                First_Second = 1;
            }
        }
    }
}
