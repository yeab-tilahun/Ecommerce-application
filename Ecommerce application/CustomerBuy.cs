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
    public partial class CustomerBuy : Form
    {
        public CustomerBuy()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panelCustomerBuy_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            CustomerPage c = new CustomerPage();
            panelCustomerBuy.Controls.Clear();
            c.Dock = DockStyle.Fill;
            panelCustomerBuy.Controls.Add(c.panelAdd);
            panelCustomerBuy.Show();
            panelCustomerBuy.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CustomerCart c = new CustomerCart();
            panelCustomerBuy.Controls.Clear();
            c.Dock = DockStyle.Fill;
            panelCustomerBuy.Controls.Add(c.panelCustomerCart);
            panelCustomerBuy.Show();
            panelCustomerBuy.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            CustomerCart c = new CustomerCart();
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           /* if(textBox1.Text != "\0")
            {
                textBox1.Text = "";
            }*/
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            //if (textBox1.Text != "\0")
             //   textBox1.Text = "";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
           // textBox1.Text = "Search the items here!";
        }

        private void picBoxSearch_Click(object sender, EventArgs e)
        {

        }

        private void picBoxSearch_MouseEnter(object sender, EventArgs e)
        {
            //picBoxSearch.BackColor = Color.DarkSeaGreen;
        }

        private void picBoxSearch_MouseLeave(object sender, EventArgs e)
        {
            //picBoxSearch.BackColor = Color.Transparent;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Teal;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Teal;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
