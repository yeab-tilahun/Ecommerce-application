﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce_application
{
    public partial class The_Wait_Form : Form
    {
        //int move = 0;
        public The_Wait_Form()
        {
            InitializeComponent();
        }

        private void The_Wait_Form_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int StartPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           // StartPoint = StartPoint + 1;
           // MyProgress.Value = 100;
            if(MyProgress.Value < 100)
            {
                MyProgress.Value += 1;
                label1.Text = MyProgress.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                Merchant m = new Merchant("Yeabsira");
                this.Hide();
                m.Show();
            }
                /*MyProgress.Value = 0;
                timer1.Stop();
                Merchant home = new Merchant();
                this.Close();
                home.Show();*/
           /* panelSlide.Left += 2;
            if(panelSlide.Left > 350)
            {
                panelSlide.Left = 0;
            }
            if(panelSlide.Left < 0)
            {
                move = 2;
            }*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
