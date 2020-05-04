using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace sl
{
    public partial class Form1 : Form
    {
        
       // WMPLib.WindowsMediaPlayer wmp = new WMPLib.WindowsMediaPlayer();
        bool red = false;
        bool blue = false;
        int x = 14, y = 413, dice, p = 0;
        int turn= 0;                  //..........turn red.......//
        int bx=14,by=413,q=0;
        //Form1 f1 = new Form1();
        //Form2 f22 = new Form2();
        public Form1()
        {
            InitializeComponent();
           // wmp.URL = "Action.mp3";
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.Visible = false;
            //f22.ShowDialog();
            //wmp.controls.play();
          
            hidelabels();
            if (turn == 0)
            {
                button2.Enabled = false;
            }
             pictureBox3.Image = Image.FromFile(@"c:\users\user\documents\visual studio 2015\Projects\sl\sl\Resources\images.png");
            pictureBox4.Visible =false;
            pictureBox5.Visible = false;

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dice = diceroll.rolldice(pictureBox3);
            label2.Text = dice.ToString();


            if (blue == true)
            {
                q=diceroll.move(ref bx, ref by, dice, ref q, pictureBox5, label10);
                

                label10.Text = q.ToString();

            }

            if (label2.Text == "6" && blue == false)
            {
                pictureBox2.Visible = false;
                pictureBox5.Visible = true;
                blue = true;
                pictureBox5.Location = new Point(bx, by);
                
                label5.Text = bx.ToString();
                label6.Text = by.ToString();
                label10.Text = q.ToString();
                q++;


            }
            if (q == 100)
            {
                
                MessageBox.Show(" BLUE HAS WON!");
                
                button2.Enabled = false;
            }
            q = diceroll.snakeeat(ref bx, ref by, q, pictureBox5);
            q = diceroll.goladder(ref bx, ref by, q, pictureBox5);
            label10.Text =q.ToString();
            if (dice == 6)
            {
                turn = 1;

            }
            else
            {
                turn = 0;//........................red turn..............//
                button1.Enabled = true;
                button2.Enabled = false;

            }





        }//..................blue play..................//

        private void button1_Click(object sender, EventArgs e)
        {
           dice = diceroll.rolldice(pictureBox3);
            label2.Text=dice.ToString();



            if (red == true)
            {
                p=diceroll.move(ref x, ref y, dice, ref p, pictureBox4, label8);
       
 

                label8.Text = p.ToString();

            }

            if (label2.Text == "6" && red==false)
            {
                pictureBox1.Visible = false;
                red = true;
                pictureBox4.Location = new Point(x, y);
                pictureBox4.Visible = true;
                label5.Text = x.ToString();
                label6.Text = y.ToString();
                label8.Text = p.ToString();
                p++;
               

            }
            if (p == 100)
            {

                MessageBox.Show(" RED HAS  WON!");
                button1.Enabled = false;
            }


            p = diceroll.snakeeat(ref x, ref y, p, pictureBox4);
            p = diceroll.goladder(ref x, ref y, p, pictureBox4);
            label8.Text = p.ToString();


            if (dice==6 )
            {
                turn = 0;

            }
            else
            {
                turn = 1;//........................blue turn..............//
                button2.Enabled = true;
                button1.Enabled = false;
               

            }
        }
        
        //...................red play.................//

            private void hidelabels()
        {
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();


        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

       

    }
}
