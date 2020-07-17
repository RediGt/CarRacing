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
            if (picBoxLine1.Top >= 450)
                picBoxLine1.Top = 0;
            else
                picBoxLine1.Top += speed;

            if (picBoxLine2.Top >= 450)
                picBoxLine2.Top = 0;
            else
                picBoxLine2.Top += speed;

            if (picBoxLine3.Top >= 450)
                picBoxLine3.Top = 0;
            else
                picBoxLine3.Top += speed;

            if (picBoxLine4.Top >= 450)
                picBoxLine4.Top = 0;
            else
                picBoxLine4.Top += speed;

            if (picBoxLine5.Top >= 450)
                picBoxLine5.Top = 0;
            else
                picBoxLine5.Top += speed;

            if (picBoxLine6.Top >= 450)
                picBoxLine6.Top = 0;
            else
                picBoxLine6.Top += speed;
        }
    }
}
