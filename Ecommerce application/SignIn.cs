﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce_application
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Application.Run(new SignUp());
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            
            if (textPassword.PasswordChar == '*')
            {
                hidePassword.BringToFront();
                textPassword.PasswordChar = '\0';
            }


        }

        private void hidePassword_Click(object sender, EventArgs e)
        {

            if (textPassword.PasswordChar == '\0')
            {
                showPassword.BringToFront();
                textPassword.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Merchant m = new Merchant();
            m.Show();
        }
    }
}
