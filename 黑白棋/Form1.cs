using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 黑白棋
{
    public partial class Form1 : Form
    {
        public int[,] blackwhite = new int[8, 8];
        public int counter_black = 0;
        public int counter_write = 0;
        public int flag_next = 1;

        public void counter_class()
        {
            counter_black = 0;
            counter_write = 0;
            for(int i=0;i<8;i++)
            {
                for(int j=0;j<8;j++)
                {
                    if (blackwhite[i,j] == 1)
                        counter_black++;
                    if (blackwhite[i,j] == 2)
                        counter_write++;
                }
            }
            label4.Text = counter_black.ToString();
            label5.Text = counter_write.ToString();

        }
        public void draw_circle()
        {
            for(int i =0;i<8;i++)
            {
                for(int j =0 ;j < 8;j++)
                {
                    if(blackwhite[i,j] == 1)
                        draw_circle_black(i,j);
                    else if(blackwhite[i,j] == 2)
                        draw_circle_white(i,j);

                }
            }
        }

        public void draw_circle_black(int i,int j)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black); 
            Graphics gr = this.CreateGraphics();
            gr.FillEllipse(myBrush, 40* (i+1), 40*(j+1), 40, 40);
        }

        public void draw_circle_white(int i, int j)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White); 
            Graphics gr = this.CreateGraphics();
            gr.FillEllipse(myBrush, 40 * (i+1), 40 * (j+1), 40, 40);
        }
        public void draw_start()
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            Graphics gr2 = this.CreateGraphics();
            gr2.Clear(this.BackColor);
            for (int i = 1; i < 10;i++ )
            {
                gr2.DrawLine(myPen, 40, 40*i, 360, 40*i);
            }
            for (int i = 1; i < 10; i++)
            {
                gr2.DrawLine(myPen, 40*i, 40 ,40*i, 360);
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    blackwhite[i, j] = 0;
                }
            }
            blackwhite[3, 3] = 1;
            blackwhite[3, 4] = 2;
            blackwhite[4, 3] = 2;
            blackwhite[4, 4] = 1;
            draw_circle_black(3, 3);
            draw_circle_black(4, 4);
            draw_circle_white(3, 4);
            draw_circle_white(4, 3);
        }

        public void black_scan(int cnt1,int cnt2)
        {
            if (blackwhite[cnt1, cnt2] == 0)
            {
                if (cnt1 >= 0 && cnt1 < 7 && blackwhite[cnt1 + 1, cnt2] == 2)
                {
                    for (int i = cnt1 + 1; i < 8; i++)
                    {
                        if (blackwhite[i, cnt2] == 0)
                            break;
                        else if (blackwhite[i, cnt2] == 1)
                        {
                            for (int j = i; j >= cnt1; j--)
                                blackwhite[j, cnt2] = 1;
                            flag_next = 2;
                            break;
                        }
                    }
                }
                if (cnt1 <= 7 && cnt1 > 0 && blackwhite[cnt1 - 1, cnt2] == 2)
                {
                    for (int i = cnt1 - 1; i >= 0; i--)
                    {
                        if (blackwhite[i, cnt2] == 0)
                            break;
                        if (blackwhite[i, cnt2] == 1)
                        {
                            for (int j = i; j <= cnt1; j++)
                                blackwhite[j, cnt2] = 1;
                            flag_next = 2;
                            break;
                        }
                    }
                }
                if (cnt2 >= 0 && cnt2 < 7 && blackwhite[cnt1, cnt2 + 1] == 2)
                {
                    for (int i = cnt2 + 1; i < 8; i++)
                    {
                        if (blackwhite[cnt1, i] == 0)
                            break;
                        else if (blackwhite[cnt1, i] == 1)
                        {
                            for (int j = i; j >= cnt2; j--)
                                blackwhite[cnt1, j] = 1;
                            flag_next = 2;
                            break;
                        }
                    }
                }
                if (cnt2 <= 7 && cnt2 > 0 && blackwhite[cnt1, cnt2 - 1] == 2)
                {
                    for (int i = cnt2 - 1; i >= 0; i--)
                    {
                        if (blackwhite[cnt1, i] == 0)
                            break;
                        if (blackwhite[cnt1, i] == 1)
                        {
                            for (int j = i; j <= cnt2; j++)
                                blackwhite[cnt1, j] = 1;
                            flag_next = 2;
                            break;
                        }
                    }
                }
                if ((cnt1 >= 0 && cnt2 >= 0) && cnt1 < 7 && cnt2 < 7 && blackwhite[cnt1 + 1, cnt2 + 1] == 2)
                {
                    int i = cnt1 + 1, j = cnt2 + 1;
                    for (; (i < 8 && j < 8); j++, i++)
                    {
                        if (blackwhite[i, j] == 0)
                            break;
                        if (blackwhite[i, j] == 1)
                        {
                            flag_next = 2;
                            for (; (i >= cnt1 && j >= cnt2); i--, j--)
                            {
                                blackwhite[i, j] = 1;
                            }
                            
                            break;
                        }
                    }
                }
                if ((cnt1 <= 7 && cnt2 <= 7) && cnt1 > 0 && cnt2 > 0 && blackwhite[cnt1 - 1, cnt2 - 1] == 2)
                {
                    int i = cnt1 - 1, j = cnt2 - 1;
                    for (; (i >= 0 && j >= 0); j--, i--)
                    {
                        if (blackwhite[i, j] == 0)
                            break;
                        if (blackwhite[i, j] == 1)
                        {
                            flag_next = 2;
                            for (; (i <= cnt1 && j <= cnt2); i++, j++)
                            {
                                blackwhite[i, j] = 1;
                            }
                            
                            break;
                        }
                    }
                }
                if (cnt1 <= 7 && cnt2 >= 0 && cnt1 > 0 && cnt2 < 7 && blackwhite[cnt1 - 1, cnt2 + 1] == 2)
                {
                    int i = cnt1 - 1, j = cnt2 + 1;
                    for (; (i >= 0 && j < 8); j++, i--)
                    {
                        if (blackwhite[i, j] == 0)
                            break;
                        if (blackwhite[i, j] == 1)
                        {
                            flag_next = 2;
                            for (; (i <= cnt1 && j >= cnt2); i++, j--)
                            {
                                blackwhite[i, j] = 1;
                            }
                            
                            break;
                        }
                    }
                }

                if (cnt1 >= 0 && cnt2 <= 7 && cnt1 < 7 && cnt2 > 0 && blackwhite[cnt1 + 1, cnt2 - 1] == 2)
                {
                    int i = cnt1 + 1, j = cnt2 - 1;
                    for (; (i < 8 && j >= 0); j--, i++)
                    {
                        if (blackwhite[i, j] == 0)
                            break;
                        if (blackwhite[i, j] == 1)
                        {
                            flag_next = 2;
                            for (; (i >= cnt1 && j <= cnt2); i--, j++)
                            {
                                blackwhite[i, j] = 1;
                            }
                            
                            break;
                        }
                    }
                }

            }
        }

        public void white_scan(int cnt1,int cnt2)
        {
            if (blackwhite[cnt1, cnt2] == 0)
            {
                if (cnt1 >= 0 && cnt1 < 7 && blackwhite[cnt1 + 1, cnt2] == 1)
                {
                    for (int i = cnt1 + 1; i < 8; i++)
                    {
                        if (blackwhite[i, cnt2] == 0)
                            break;
                        else if (blackwhite[i, cnt2] == 2)
                        {
                            for (int j = i; j >= cnt1; j--)
                                blackwhite[j, cnt2] = 2;
                            flag_next = 1;
                            break;
                        }
                    }
                }
                if (cnt1 <= 7 && cnt1 > 0 && blackwhite[cnt1 - 1, cnt2] == 1)
                {
                    for (int i = cnt1 - 1; i >= 0; i--)
                    {
                        if (blackwhite[i, cnt2] == 0)
                            break;
                        if (blackwhite[i, cnt2] == 2)
                        {
                            for (int j = i; j <= cnt1; j++)
                                blackwhite[j, cnt2] = 2;
                            flag_next = 1;
                            break;
                        }
                    }
                }
                if (cnt2 >= 0 && cnt2 < 7 && blackwhite[cnt1, cnt2 + 1] == 1)
                {
                    for (int i = cnt2 + 1; i < 8; i++)
                    {
                        if (blackwhite[cnt1, i] == 0)
                            break;
                        else if (blackwhite[cnt1, i] == 2)
                        {
                            for (int j = i; j >= cnt2; j--)
                                blackwhite[cnt1, j] = 2;
                            flag_next = 1;
                            break;
                        }
                    }
                }
                if (cnt2 <= 7 && cnt2 > 0 && blackwhite[cnt1, cnt2 - 1] == 1)
                {
                    for (int i = cnt2 - 1; i >= 0; i--)
                    {
                        if (blackwhite[cnt1, i] == 0)
                            break;
                        if (blackwhite[cnt1, i] == 2)
                        {
                            for (int j = i; j <= cnt2; j++)
                                blackwhite[cnt1, j] = 2;
                            flag_next = 1;
                            break;
                        }
                    }
                }
                if ((cnt1 >= 0 && cnt2 >= 0) && cnt1 < 7 && cnt2 < 7 && blackwhite[cnt1 + 1, cnt2 + 1] == 1)
                {
                    int i = cnt1 + 1, j = cnt2 + 1;
                    for (; (i < 8 && j < 8); j++, i++)
                    {
                        if (blackwhite[i, j] == 0)
                            break;
                        if (blackwhite[i, j] == 2)
                        {
                            for (; (i >= cnt1 && j >= cnt2); i--, j--)
                            {
                                blackwhite[i, j] = 2;
                            }
                            flag_next = 1;
                            break;
                        }
                    }
                }
                if ((cnt1 <= 7 && cnt2 <= 7) && cnt1 > 0 && cnt2 > 0 && blackwhite[cnt1 - 1, cnt2 - 1] == 1)
                {
                    int i = cnt1 - 1, j = cnt2 - 1;
                    for (; (i >= 0 && j >= 0); j--, i--)
                    {
                        if (blackwhite[i, j] == 0)
                            break;
                        if (blackwhite[i, j] == 2)
                        {
                            for (; (i <= cnt1 && j <= cnt2); i++, j++)
                            {
                                blackwhite[i, j] = 2;
                            }
                            flag_next = 1;
                            break;
                        }
                    }
                }
                if (cnt1 <= 7 && cnt2 >= 0 && cnt1 > 0 && cnt2 < 7 && blackwhite[cnt1 - 1, cnt2 + 1] == 1)
                {
                    int i = cnt1 - 1, j = cnt2 + 1;
                    for (; (i >= 0 && j < 8); j++, i--)
                    {
                        if (blackwhite[i, j] == 0)
                            break;
                        if (blackwhite[i, j] == 2)
                        {
                            for (; (i <= cnt1 && j >= cnt2); i++, j--)
                            {
                                blackwhite[i, j] = 2;
                            }
                            flag_next = 1;
                            break;
                        }
                    }
                }

                if (cnt1 >= 0 && cnt2 <= 7 && cnt1 < 7 && cnt2 > 0 && blackwhite[cnt1 + 1, cnt2 - 1] == 1)
                {
                    int i = cnt1 + 1, j = cnt2 - 1;
                    for (; (i < 8 && j >= 0); j--, i++)
                    {
                        if (blackwhite[i, j] == 0)
                            break;
                        if (blackwhite[i, j] == 2)
                        {
                            for (; (i >= cnt1 && j <= cnt2); i--, j++)
                            {
                                blackwhite[i, j] = 2;
                            }
                            flag_next = 1;
                            break;
                        }
                    }
                }
            }
        }

        public int scan_auto()
        {
            if(flag_next == 1)
            {
                for(int cnt1=0;cnt1<8;cnt1++)
                {
                    for(int cnt2=0;cnt2<8;cnt2++)
                    {
                        if (blackwhite[cnt1, cnt2] == 0)
                        {
                            if (cnt1 >= 0 && cnt1 < 7 && blackwhite[cnt1 + 1, cnt2] == 2)
                            {
                                for (int i = cnt1 + 1; i < 8; i++)
                                {
                                    if (blackwhite[i, cnt2] == 0)
                                        break;
                                    else if (blackwhite[i, cnt2] == 1)
                                    {
                                        return 1;
                                    }
                                }
                            }
                            else if (cnt1 <= 7 && cnt1 > 0 && blackwhite[cnt1 - 1, cnt2] == 2)
                            {
                                for (int i = cnt1 - 1; i >= 0; i--)
                                {
                                    if (blackwhite[i, cnt2] == 0)
                                        break;
                                    if (blackwhite[i, cnt2] == 1)
                                    {
                                        return 1;
                                    }
                                }
                            }
                            else if (cnt2 >= 0 && cnt2 < 7 && blackwhite[cnt1, cnt2 + 1] == 2)
                            {
                                for (int i = cnt2 + 1; i < 8; i++)
                                {
                                    if (blackwhite[cnt1, i] == 0)
                                        break;
                                    else if (blackwhite[cnt1, i] == 1)
                                    {
                                        return 1;
                                    }
                                }
                            }
                            else if (cnt2 <= 7 && cnt2 > 0 && blackwhite[cnt1, cnt2 - 1] == 2)
                            {
                                for (int i = cnt2 - 1; i >= 0; i--)
                                {
                                    if (blackwhite[cnt1, i] == 0)
                                        break;
                                    if (blackwhite[cnt1, i] == 1)
                                    {
                                        return 1;
                                    }
                                }
                            }
                            else  if ((cnt1 >= 0 && cnt2 >= 0) && cnt1 < 7 && cnt2 < 7 && blackwhite[cnt1 + 1, cnt2 + 1] == 2)
                            {
                                int i = cnt1 + 1, j = cnt2 + 1;
                                for (; (i < 8 && j < 8); j++, i++)
                                {
                                    if (blackwhite[i, j] == 0)
                                        break;
                                    if (blackwhite[i, j] == 1)
                                    {
                                        return 1;
                                    }
                                }
                            } 
                            else if ((cnt1 <= 7 && cnt2 <= 7) && cnt1 > 0 && cnt2 > 0 && blackwhite[cnt1 - 1, cnt2 - 1] == 2)
                            {
                                int i = cnt1 - 1, j = cnt2 - 1;
                                for (; (i >= 0 && j >= 0); j--, i--)
                                {
                                    if (blackwhite[i, j] == 0)
                                        break;
                                    if (blackwhite[i, j] == 1)
                                    {
                                        return 1;
                                    }
                                }
                            }
                            else if (cnt1 <= 7 && cnt2 >= 0 && cnt1 > 0 && cnt2 < 7 && blackwhite[cnt1 - 1, cnt2 + 1] == 2)
                            {
                                int i = cnt1 - 1, j = cnt2 + 1;
                                for (; (i >= 0 && j < 8); j++, i--)
                                {
                                    if (blackwhite[i, j] == 0)
                                        break;
                                    if (blackwhite[i, j] == 1)
                                    {
                                        return 1;
                                    }
                                }
                            }

                            else if (cnt1 >= 0 && cnt2 <= 7 && cnt1 < 7 && cnt2 > 0 && blackwhite[cnt1 + 1, cnt2 - 1] == 2)
                            {
                                int i = cnt1 + 1, j = cnt2 - 1;
                                for (; (i < 8 && j >= 0); j--, i++)
                                {
                                    if (blackwhite[i, j] == 0)
                                        break;
                                    if (blackwhite[i, j] == 1)
                                    {
                                        return 1;
                                    }
                                }
                            }
                        }
                    }
                }
                return 2;
            }
            else{
                for (int cnt1 = 0; cnt1 < 8; cnt1++)
                {
                    for (int cnt2 = 0; cnt2 < 8; cnt2++)
                    {
                        if (blackwhite[cnt1, cnt2] == 0)
                        {
                            if (blackwhite[cnt1, cnt2] == 0)
                            {
                                if (cnt1 >= 0 && cnt1 < 7 && blackwhite[cnt1 + 1, cnt2] == 1)
                                {
                                    for (int i = cnt1 + 1; i < 8; i++)
                                    {
                                        if (blackwhite[i, cnt2] == 0)
                                            break;
                                        else if (blackwhite[i, cnt2] == 2)
                                        {
                                            return 2;
                                        }
                                    }
                                }
                                else if (cnt1 <= 7 && cnt1 > 0 && blackwhite[cnt1 - 1, cnt2] == 1)
                                {
                                    for (int i = cnt1 - 1; i >= 0; i--)
                                    {
                                        if (blackwhite[i, cnt2] == 0)
                                            break;
                                        if (blackwhite[i, cnt2] == 2)
                                        {
                                            return 2;
                                        }
                                    }
                                }
                                else if (cnt2 >= 0 && cnt2 < 7 && blackwhite[cnt1, cnt2 + 1] == 1)
                                {
                                    for (int i = cnt2 + 1; i < 8; i++)
                                    {
                                        if (blackwhite[cnt1, i] == 0)
                                            break;
                                        else if (blackwhite[cnt1, i] == 2)
                                        {
                                            return 2;
                                        }
                                    }
                                }
                                else if (cnt2 <= 7 && cnt2 > 0 && blackwhite[cnt1, cnt2 - 1] == 1)
                                {
                                    for (int i = cnt2 - 1; i >= 0; i--)
                                    {
                                        if (blackwhite[cnt1, i] == 0)
                                            break;
                                        if (blackwhite[cnt1, i] == 2)
                                        {
                                            return 2;
                                        }
                                    }
                                }
                                else if ((cnt1 >= 0 && cnt2 >= 0) && cnt1 < 7 && cnt2 < 7 && blackwhite[cnt1 + 1, cnt2 + 1] == 1)
                                {
                                    int i = cnt1 + 1, j = cnt2 + 1;
                                    for (; (i < 8 && j < 8); j++, i++)
                                    {
                                        if (blackwhite[i, j] == 0)
                                            break;
                                        if (blackwhite[i, j] == 2)
                                        {
                                            return 2;
                                        }
                                    }
                                }
                                else if ((cnt1 <= 7 && cnt2 <= 7) && cnt1 > 0 && cnt2 > 0 && blackwhite[cnt1 - 1, cnt2 - 1] == 1)
                                {
                                    int i = cnt1 - 1, j = cnt2 - 1;
                                    for (; (i >= 0 && j >= 0); j--, i--)
                                    {
                                        if (blackwhite[i, j] == 0)
                                            break;
                                        if (blackwhite[i, j] == 2)
                                        {
                                            return 2;
                                        }
                                    }
                                }
                                else if (cnt1 <= 7 && cnt2 >= 0 && cnt1 > 0 && cnt2 < 7 && blackwhite[cnt1 - 1, cnt2 + 1] == 1)
                                {
                                    int i = cnt1 - 1, j = cnt2 + 1;
                                    for (; (i >= 0 && j < 8); j++, i--)
                                    {
                                        if (blackwhite[i, j] == 0)
                                            break;
                                        if (blackwhite[i, j] == 2)
                                        {
                                            return 2;
                                        }
                                    }
                                }

                                else if (cnt1 >= 0 && cnt2 <= 7 && cnt1 < 7 && cnt2 > 0 && blackwhite[cnt1 + 1, cnt2 - 1] == 1)
                                {
                                    int i = cnt1 + 1, j = cnt2 - 1;
                                    for (; (i < 8 && j >= 0); j--, i++)
                                    {
                                        if (blackwhite[i, j] == 0)
                                            break;
                                        if (blackwhite[i, j] == 2)
                                        {
                                            return 2;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return 2;
            }
            return 1;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void 新遊戲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            Graphics gr = this.CreateGraphics();
            draw_start();
            System.Drawing.SolidBrush myPen = new System.Drawing.SolidBrush(System.Drawing.Color.Black);//重新布置
            label4.Text = " ";
            label5.Text = " ";
            counter_black = 0;
            counter_write = 0;
            counter_class();
            gr.FillEllipse(myPen, 400, 80, 40, 40);
        }

        private void 重新游戏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            Graphics gr = this.CreateGraphics();
            System.Drawing.SolidBrush myPen = new System.Drawing.SolidBrush(System.Drawing.Color.Black);//重新布置棋局
            draw_start();
            counter_black = 0;
            counter_write = 0;
            label4.Text = " ";
            label5.Text = " ";
            counter_black = 0;
            counter_write = 0;
            counter_class();
            flag_next = 1;
            gr.FillEllipse(myPen, 400, 80, 40, 40);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int cnt1,cnt2;
            cnt1 = e.X / 40-1;
            cnt2 = e.Y / 40-1;
            System.Drawing.SolidBrush brush_white = new System.Drawing.SolidBrush(System.Drawing.Color.White);//下白棋
            System.Drawing.SolidBrush brush_black = new System.Drawing.SolidBrush(System.Drawing.Color.Black);//下黑棋
            Graphics gr = this.CreateGraphics();
            if(cnt1 < 8 && cnt2 <8 && cnt1 >= 0 && cnt2 >= 0)
            {
                if (flag_next == 1)
                {
                    black_scan(cnt1, cnt2);              
                }
                else
                {
                    white_scan(cnt1,cnt2);
                } 
                counter_class();
                draw_circle();
            }
            flag_next = scan_auto();
            if(flag_next == 1)
            {
                gr.FillEllipse(brush_black, 400, 80 , 40, 40);
            }
            else
            {
                gr.FillEllipse(brush_white, 400, 80, 40, 40);
            }

            if (counter_black == 0 && counter_write >0)
                MessageBox.Show("白棋勝利！");
            else if(counter_write == 0 && counter_black >0)
                MessageBox.Show("黑棋勝利！");
           if(counter_black + counter_write >= 64)
           {
               if (counter_black > counter_write)
                   MessageBox.Show("黑棋勝利！");
               else if (counter_write > counter_black)
                   MessageBox.Show("白棋勝利！");
               else
                   MessageBox.Show("和局");
           }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
