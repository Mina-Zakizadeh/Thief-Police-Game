using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{ 
    
    public partial class Form1 : Form
    {
        SolidBrush s=new SolidBrush(Color.Yellow);
        SolidBrush s1 = new SolidBrush(Color.Yellow);
        SolidBrush s2 = new SolidBrush(Color.Yellow);
        SolidBrush s3 = new SolidBrush(Color.Yellow);
        SolidBrush s4 = new SolidBrush(Color.Yellow);
        enum positon
        {
            Left, Right, Up, Down
        }
        bool p = false;
        Random r = new Random();
        int count;
        bool coin1 = true;
        bool coin2 = true;
        bool coin3 = true;
        bool coin4 = true;
        bool coin5 = true;
       int xk=620,yk=0;                     
        bool coin = false;
        Timer t = new Timer();
        int x = 0, y = 360;
        int coin1x, coin1y, coin2x, coin2y, coin3x, coin3y, coin4x, coin4y, coin5x, coin5y;
        int police2x, police2y,police3x, police3y;
        int police1x, police1y;
        private positon police1position;
        private positon police3position;
        private positon police2position;
        Image timage = Image.FromFile("d13c3d307e0ef0df80cbea4e9708a8e5.jpg");
        Image pimage = Image.FromFile("images (3).jpg");
        
        public Form1()
        {
            police1x = r.Next(0, 360);
            police1y = r.Next(0, 360);
            coin1x = r.Next(0, 620);
            coin1y = r.Next(0, 360);
            coin2x = r.Next(0, 620);
            coin2y = r.Next(0, 360);
            coin3x = r.Next(0, 620);
            coin3y = r.Next(0, 360);
            coin4x = r.Next(0, 620);
            coin4y = r.Next(0, 360);
            coin5x = r.Next(0, 620);
            coin5y = r.Next(0, 360);
            police2x = r.Next(0, 620);
            police2y = r.Next(0, 360);
            police3x = r.Next(0, 620);
            police3y = r.Next(0, 360);

            
           


                InitializeComponent();

            police3position = positon.Right;
            police1position = positon.Right;
            police2position = positon.Right;
            police1x = r.Next(0, 620);
            police1y = r.Next(0, 360);
            coin1x = r.Next(0, 620);
            coin1y = r.Next(0, 360);
            coin2x = r.Next(0, 620);
            coin2y = r.Next(0, 360);
            coin3x = r.Next(0, 620);
            coin3y = r.Next(0, 360);
            coin4x = r.Next(0, 620);
            coin4y = r.Next(0, 360);
            coin5x = r.Next(0, 620);
            coin5y = r.Next(0, 360);
            police2x = r.Next(0, 620);
            police2y = r.Next(0, 360);
            police3x = r.Next(0, 620);
            police3y = r.Next(0, 360);
           
}
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(timage, x, y,100,100);
 
            e.Graphics.DrawImage(pimage, police1x, police1y, 100, 100);
            e.Graphics.DrawImage(pimage, police2x, police2y, 100, 100);
            e.Graphics.DrawImage(pimage, police3x, police3y, 100, 100);
            e.Graphics.FillEllipse((s), coin1x, coin1y, 40, 40);
            e.Graphics.FillEllipse((s1), coin2x, coin2y, 40, 40);
            e.Graphics.FillEllipse((s2), coin3x, coin3y, 40, 40);
            e.Graphics.FillEllipse((s3), coin4x, coin4y, 40, 40);
            e.Graphics.FillEllipse((s4), coin5x, coin5y, 40, 40);

          
            
           
           
            
            
            if (coin1)
            {
                if ( x == coin1x||(x>coin1x&&x<(coin1x+45))||(x<coin1x&&x>(coin1x-45)))
                {
                    if (y == coin1y||(y>coin1y&&y<(coin1y+45))||(y<coin1y&&y>(coin1y-45)))
                    {
                       
                       
                      
                       s =new  SolidBrush(Color.Empty);
                        count++;
                        coin1 = false;
                        coin = true;
                    }
                }
            }
            if (coin2)
            {
                if (x == coin2x || (x > coin2x && x < (coin2x + 45)) || (x < coin2x && x > (coin2x - 45)))
                {
                    if (y == coin2y || (y > coin2y && y < (coin2y + 45)) || (y < coin2y && y > (coin2y - 45)))
                    {



                        s1 = new SolidBrush(Color.Empty);
                        count++;
                        coin2 = false;
                        coin = true;
                    }
                }
            }
            if (coin3)
            {
                if (x == coin3x || (x > coin3x && x < (coin3x + 45)) || (x < coin3x && x > (coin3x - 45)))
                {
                    if (y == coin3y || (y > coin3y && y < (coin3y + 45)) || (y < coin3y && y > (coin3y - 45)))
                    {



                        s2 = new SolidBrush(Color.Empty);
                        count++;
                        coin3 = false;
                        coin = true;
                    }
                }
            }
            if (coin4)
            {
                if (x == coin4x || (x > coin4x && x < (coin4x + 45)) || (x < coin4x && x > (coin4x - 45)))
                {
                    if (y == coin4y || (y > coin4y && y < (coin4y + 45)) || (y < coin4y && y > (coin4y - 45)))
                    {



                        s3 = new SolidBrush(Color.Empty);
                        count++;
                        coin4 = false;
                        coin = true;
                    }
                }
            }
            if (coin5)
            {
                if (x == coin5x || (x > coin5x && x < (coin5x + 45)) || (x < coin5x && x > (coin5x - 45)))
                {
                    if (y == coin5y || (y > coin5y && y < (coin5y + 45)) || (y < coin5y && y > (coin5y - 45)))
                    {



                        s4 = new SolidBrush(Color.Empty);
                        count++;
                        coin5 = false;
                        coin = true;
                    }
                }
            }

            if (count==5)
            {
                e.Graphics.FillRectangle((Brushes.Green), xk, yk, 100, 100);
            }
            
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right)
            {
                x += 5;
                if (x >= 720 - 100)
                {
                    x = 720 - 100;
                }
            }
            if (e.KeyData == Keys.Left)
            {
                x -= 5;
                if (x <= 0)
                {
                    x = 0;
                }
            }
            if (e.KeyData == Keys.Up)
            {
                y -= 5;
                if (y <= 0)
                {
                    y = 0;
                }

            }
            if (e.KeyData == Keys.Down)
            {
                y += 5;
                if (y >= 480 - 30 - 100)
                {
                    y = 491 - 30 - 100;
                }
            }
            if (count == 5)
            {
                if (x==xk&&y==yk)
                {
                    police1tiner.Stop();
                    MessageBox.Show("شما برنده شدید!!!");
                    Close();
                    p = true;
                }
               
                    
                
                
                
            }
            
            

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
           
            


           

        }

        private void police1tiner_Tick(object sender, EventArgs e)
        {
            
            


                if (coin)
                {
                    if (police1position == positon.Right)
                    {
                        if (police1x < x)
                        {
                            police1x += 1;

                        }
                        else
                        {
                            police1position = positon.Left;
                        }



                    }
                    if (police1position == positon.Left)
                    {
                        if (police1x > x)
                        {
                            police1x -= 1;

                        }
                        else
                        {
                            police1position = positon.Up;
                        }



                    }


                    if (police1position == positon.Up)
                    {
                        if (police1y > y)
                        {
                            police1y -= 1;
                        }
                        else
                        {
                            police1position = positon.Down;
                        }



                    }
                    if (police1position == positon.Down)
                    {

                        if (police1y < y)
                        {
                            police1y += 1;

                        }
                        else
                        {
                            police1position = positon.Right;
                        }


                    }



                    if (police2position == positon.Right)
                    {
                        if (police2x < x)
                        {
                            police2x += 1;

                        }
                        else
                        {
                            police2position = positon.Left;
                        }



                    }
                    if (police2position == positon.Left)
                    {
                        if (police2x > x)
                        {
                            police2x -= 1;

                        }
                        else
                        {
                            police2position = positon.Up;
                        }



                    }


                    if (police2position == positon.Up)
                    {
                        if (police2y > y)
                        {
                            police2y -= 1;
                        }
                        else
                        {
                            police2position = positon.Down;
                        }



                    }
                    if (police2position == positon.Down)
                    {

                        if (police2y < y)
                        {
                            police2y += 1;

                        }
                        else
                        {
                            police2position = positon.Right;
                        }


                    }
                    if (police3position == positon.Right)
                    {
                        if (police3x < x)
                        {
                            police3x += 1;

                        }
                        else
                        {
                            police3position = positon.Left;
                        }



                    }
                    if (police3position == positon.Left)
                    {
                        if (police3x > x)
                        {
                            police3x -= 1;

                        }
                        else
                        {
                            police3position = positon.Up;
                        }



                    }


                    if (police3position == positon.Up)
                    {
                        if (police3y > y)
                        {
                            police3y -= 1;
                        }
                        else
                        {
                            police3position = positon.Down;
                        }



                    }
                    if (police3position == positon.Down)
                    {

                        if (police3y < y)
                        {
                            police3y += 1;

                        }
                        else
                        {
                            police3position = positon.Right;
                        }


                    }



                    Invalidate();

                }

                if ((police1x == x && police1y == y) || (police2x == x && police2y == y) || (police3x == x && police3y == y))
                {


                    Close();
                }


            }
        


        private void police2timer_Tick(object sender, EventArgs e)
        {
            
            if (coin)
            {
               



            }

            
            

        }

        private void movetimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
            Refresh();
        }


    }
}
