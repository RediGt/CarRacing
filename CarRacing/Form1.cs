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
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveLine(5);
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
    }
}
