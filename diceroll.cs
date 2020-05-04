using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace sl
{
    class diceroll
    {

        public static int rolldice(PictureBox p)
        {

            int roll = 0;
            Random r = new Random();
            roll = r.Next(1, 7);
            p.Image = Image.FromFile(@"c:\users\user\documents\visual studio 2015\Projects\sl\sl\Resources\" + roll + ".png");

            p.SizeMode = PictureBoxSizeMode.StretchImage;

            return roll;

        }
        public static int move(ref int x, ref int y, int rolldice, ref int p, PictureBox px, Label l)

        {
            if (rolldice + p > 100)
            {
                l.Text = "Can not proceed further";


            }
            else
            {
                for (int i = 0; i < rolldice; i++)
                {
                    //.............................TRAVERSE....................//
                    if (p == 10)
                    {
                        x = 14;
                        y = 371;
                        p++;
                    }
                    else if (p == 20)
                    {
                        x = 14;
                        y = 323;
                        p++;

                    }
                    else if (p == 30)
                    {
                        x = 14;
                        y = 283;
                        p++;
                    }
                    else if (p == 40)
                    {
                        x = 14;
                        y = 235;
                        p++;
                    }
                    else if (p == 50)
                    {
                        x = 14;
                        y = 192;
                        p++;
                    }
                    else if (p == 60)
                    {
                        x = 14;
                        y = 149;
                        p++;
                    }
                    else if (p == 70)
                    {
                        x = 14;
                        y = 100;
                        p++;
                    }
                    else if (p == 80)
                    {
                        x = 14;
                        y = 63;
                        p++;
                    }
                    else if (p == 90)
                    {
                        x = 14;
                        y = 16;
                        p++;
                    }
                  
                    else
                    {
                        x += 56;
                    }
                    l.Text = p.ToString();
                    px.Location = new Point(x, y);
                    p++;
                    
                }
            }

            return p;
        }



        public static int snakeeat(ref int x,ref int y, int p, PictureBox pi)
        {
            if (p == 34)
            {
                x = 14;
                y = 413;
                p = 1;
              
            }
            else if (p == 25)
            {
                x = 241;
                y = 413;
                p = 5;
             
            }
           

          else if (p == 47)
            {
                x = 463;
                y = 413;
                p = 9;
              }
            else if (p == 91)
            {
                x = 19; 
                y = 149;
                p = 61;
              }
            else if (p == 65)
            {
                x = 79; 
                y = 190;
                p = 52;
              }
            else if (p == 87)
            {
                x = 359;
                y = 191;
                p = 57;
              }
            else if (p ==99)
            {
                x = 468; 
                y = 148;
                p = 69;
              }
            pi.Location = new Point(x, y);

            return p;
        }
        public static int goladder(ref int x, ref int y, int p, PictureBox pi)
        {
             if (p == 3)
            {
                x = 14;
                y = 192;
                p = 51;

            }
            else if (p == 6)
            {
                x = 357;
                y = 323;
                p = 27;
            }
            else if (p == 36)
            {
                x = 253;
                y = 192;
                p = 55;
            }
            else if (p == 20)
            {
                x = 521;
                y = 149;
                p = 70;
            }
            else if (p == 63)
            {
                x = 246;
                y = 16;
                p = 95;
            }
            else if (p == 68)
            {
                x = 408;
                y = 16;
                p = 98;
            }
            pi.Location = new Point(x, y);

            return p;
        }

    }
}