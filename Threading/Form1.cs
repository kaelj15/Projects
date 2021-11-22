using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Threading
{
    public partial class Form1 : Form
    {
        Thread t1;
        Thread t2;
        Thread t3;

        delegate void CTBMethod(int val);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                int red = int.Parse(tbxRed.Text);
                int green = int.Parse(tbxGreen.Text);
                int blue = int.Parse(tbxBlue.Text);

                t1 = new Thread(new ParameterizedThreadStart(LoopRed));
                t2 = new Thread(new ParameterizedThreadStart(LoopGreen));
                t3 = new Thread(new ParameterizedThreadStart(LoopBlue));

                if (red > 430 && green > 430 && blue > 430)
                {
                    red = 400;
                    green = 400;
                    blue = 400;
                }

                t1.Start(red);
                t2.Start(green);
                t3.Start(blue);


            }
            catch (Exception)
            {
                MessageBox.Show("Not Valid Number", "Error");
            }

        }


        public void LoopRed(object obs)
        {
            int x = (int)obs;

            CTBMethod methodRed = new CTBMethod(UpdateRed);

            for (int i = 0; i < x; i++)
            {
                this.Invoke(methodRed, i);
                Thread.Sleep(2);
            }
        }

        public void LoopGreen(object obs)
        {
            int x = (int)obs;

            CTBMethod methodGreen = new CTBMethod(UpdateGreen);

            for (int i = 0; i < x; i++)
            {
                this.Invoke(methodGreen, i);
                Thread.Sleep(2);
            }
        }

        public void LoopBlue(object obs)
        {
            int x = (int)obs;

            CTBMethod methodBlue = new CTBMethod(UpdateBlue);

            for (int i = 0; i < x; i++)
            {
                this.Invoke(methodBlue, i);
                Thread.Sleep(2);
            }
        }

        public void UpdateRed(int val)
        {
            pbxRed.Height = val;
            pbxRed.Top--;
            pbxRed.Refresh();
        }

        public void UpdateGreen(int val)
        {
            pbxGreen.Height = val;
            pbxGreen.Top--;
            pbxGreen.Refresh();
        }

        public void UpdateBlue(int val)
        {
            pbxBlue.Height = val;
            pbxBlue.Top--;
            pbxBlue.Refresh();
        }

    }
}
