using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
    public partial class Form1 : Form
    {
        int carSideSpeed = 3;
        int carForwardSpeed = 5;
        int gameSpeed = 0;
        Random rand = new Random();
        int collectedCoins = 0;
        
        public Form1()
        {
            InitializeComponent();
            initializeGame();
        }

        public void initializeGame()
        {
            lblGameOver.Visible = false;
            lblScore.Text = collectedCoins.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveLine(gameSpeed);
            enemy(gameSpeed);
            GameOver();
            showCoins(gameSpeed);
            coinCollision();
        }

        void enemy(int speed)
        {
            if(enemyCar1.Top >= this.Height - enemyCar1.Height)
            {
                enemyCar1.Top = -enemyCar1.Height;
                enemyCar1.Left = rand.Next(2, (int)this.Width/3*2);
            }                
            else
                enemyCar1.Top += (int)(speed/2) - 1;                       

            if (enemyCar2.Top >= this.Height - enemyCar2.Height)
            {
                enemyCar2.Top = -enemyCar2.Height;
                enemyCar2.Left = rand.Next(2, this.Width - enemyCar2.Width - 5);
            } 
            else
                enemyCar2.Top += (int)(speed / 2) - 3;

            if (enemyCar3.Top >= this.Height - enemyCar3.Height)
            {
                enemyCar3.Top = -enemyCar3.Height;
                enemyCar3.Left = rand.Next((int)this.Width/3, this.Width - enemyCar3.Width - 5);
            }               
            else
                enemyCar3.Top += (int)(speed / 1.5) - 2;
        }

        void moveLine(int speed)
        {
            if (picBoxLine1.Top >= this.Height - picBoxLine1.Height)
                picBoxLine1.Top = -picBoxLine1.Height;
            else
                picBoxLine1.Top += speed;

            if (picBoxLine2.Top >= this.Height - picBoxLine2.Height)
                picBoxLine2.Top = -picBoxLine2.Height;
            else
                picBoxLine2.Top += speed;

            if (picBoxLine3.Top >= this.Height - picBoxLine3.Height)
                picBoxLine3.Top = -picBoxLine3.Height;
            else
                picBoxLine3.Top += speed;

            if (picBoxLine4.Top >= this.Height - picBoxLine4.Height)
                picBoxLine4.Top = -picBoxLine4.Height;
            else
                picBoxLine4.Top += speed;

            if (picBoxLine5.Top >= this.Height - picBoxLine5.Height)
                picBoxLine5.Top = -picBoxLine5.Height;
            else
                picBoxLine5.Top += speed;

            if (picBoxLine6.Top >= this.Height - picBoxLine6.Height)
                picBoxLine6.Top = -picBoxLine6.Height;
            else
                picBoxLine6.Top += speed;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (picBoxCar.Left > 0)
                    picBoxCar.Left += -carSideSpeed;
            }

            if (e.KeyCode == Keys.Right)
            {
                if (picBoxCar.Left < this.Width - picBoxCar.Width - 12)
                    picBoxCar.Left += carSideSpeed;
            }

            /*
            if (e.KeyCode == Keys.Up)
            {
                if (picBoxCar.Top > 10)
                    picBoxCar.Top += -carForwardSpeed;
            }

            if (e.KeyCode == Keys.Down)
            {
                if (picBoxCar.Top < this.Height - picBoxCar.Height - 50)
                    picBoxCar.Top += carForwardSpeed;
            } */

            if (e.KeyCode == Keys.Up)
                if (gameSpeed < 21)
                    gameSpeed++;

            if (e.KeyCode == Keys.Down)
                if (gameSpeed > 0)
                    gameSpeed--;
        }

        void GameOver()
        {
            if (picBoxCar.Bounds.IntersectsWith(enemyCar1.Bounds) ||
                picBoxCar.Bounds.IntersectsWith(enemyCar2.Bounds) ||
                picBoxCar.Bounds.IntersectsWith(enemyCar3.Bounds))
            {
                timer1.Stop();
                lblGameOver.Visible = true;
                carSideSpeed = 0;
            }
        }

        void coinCollision()
        {
            if (picBoxCar.Bounds.IntersectsWith(coin1.Bounds))
            {
                coin1.Visible = false;
                collectedCoins++;
                lblScore.Text = collectedCoins.ToString();
            }
            if (picBoxCar.Bounds.IntersectsWith(coin2.Bounds))
            {
                coin2.Visible = false;
                collectedCoins++;
                lblScore.Text = collectedCoins.ToString();
            }
            if (picBoxCar.Bounds.IntersectsWith(coin3.Bounds))
            {
                coin3.Visible = false;
                collectedCoins++;
                lblScore.Text = collectedCoins.ToString();
            }
            if (picBoxCar.Bounds.IntersectsWith(coin4.Bounds))
            {
                coin4.Visible = false;
                collectedCoins++;
                lblScore.Text = collectedCoins.ToString();
            }
        }

        public void showCoins(int speed)
        {
            if (coin1.Top >= this.Height - coin1.Height || coin1.Visible == false)
            {
                coin1.Top = -coin1.Height;
                coin1.Left = rand.Next(2, this.Width - coin1.Width);
                coin1.Visible = true;
            }
            else
               coin1.Top += speed;

            if (coin2.Top >= this.Height - coin1.Height || coin2.Visible == false)
            {
                coin2.Top = -coin1.Height;
                coin2.Left = rand.Next(2, this.Width - coin2.Width);
                coin2.Visible = true;
            }
            else
                coin2.Top += speed;

            if (coin3.Top >= this.Height - coin3.Height || coin3.Visible == false)
            {
                coin3.Top = -coin3.Height;
                coin3.Left = rand.Next(2, this.Width - coin3.Width);
                coin3.Visible = true;
            }
            else
                coin3.Top += speed;

            if (coin4.Top >= this.Height - coin4.Height || coin4.Visible == false)
            {
                coin4.Top = -coin4.Height;
                coin4.Left = rand.Next(2, this.Width - coin4.Width);
                coin4.Visible = true;
            }
            else
                coin4.Top += speed;
        }
    }
}
