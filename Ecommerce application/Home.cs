﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce_application
{
    public partial class Home : Form
    {
        //private SqlCommand cmd;
       /* private SqlDataReader dr;
        PictureBox pic = new PictureBox();
        Label price = new Label();
        Label descripton = new Label();*/

        public Home()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            InitializeComponent();

            //Loading data
            string str = string.Empty;
            for (int i = 0; i < 1000; i++)
            {
                str = str + i.ToString();
            }

            t.Abort();
        }

        void Splash()
        {
           //SplashScreen.SplashForm form = new SplashScreen.SplashForm();
            //form.AppName = "";
            //Application.Run(form);
            //Application.Run(Home);
        }

        
        private void Home_Load(object sender, EventArgs e)
        {
            // LoadItems();
            //ShowPic();
            //ShowPrice();
            //ShowDescription();
            PopulateItem();
        }

        /*public void populateItems()
        {
            getDataFromSql();
            int n = 1;
            LoadItems items;
            for (int i = 0; i < n; i++)
            {
                items = new LoadItems();
                items.Price = "a";
                items.Description = "b";
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(items);
                }

            }

        }*/

        private void PopulateItem()
        {
            string constr = "Server = LAPTOP-RS59N8IM;   Database = Ecommerce; integrated security=true";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("spLoad_data", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblProduct");
                    DataTable dt = ds.Tables["tblProduct"];
                    LoadItems[] a = new LoadItems[dt.Rows.Count];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        a[i] = new LoadItems();
                        /*SqlDataAdapter da1 = new SqlDataAdapter("spLoad_data", con);
                        da1.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da1.SelectCommand.Parameters.AddWithValue("@productid", dt.Rows[i]["productid"]);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1, "tblproduct");
                        DataTable dt1 = ds1.Tables["tblproduct"];*/
                        a[i].Pic = (byte[])dt.Rows[i]["photo"];
                        a[i].Name = dt.Rows[i]["name"].ToString();
                        a[i].Description = dt.Rows[i]["description"].ToString();
                        a[i].Price = string.Format("${0}.00", dt.Rows[i]["price"].ToString());

                        if (flowLayoutPanel1.Controls.Count < 0)
                            flowLayoutPanel1.Controls.Clear();
                        else
                            flowLayoutPanel1.Controls.Add(a[i]);
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        /* try
         {
             SqlConnection con = new SqlConnection("Server = LAPTOP-RS59N8IM; Database = Ecommerce; integrated security = true;");
             SqlCommand cmd = new SqlCommand("Select price, photo, description from product");
             con.Open(); cmd.Connection = con;
             SqlDataReader rd = cmd.ExecuteReader();
             LoadItems items = new LoadItems();
             while (rd.Read())
             {
                 *//*long len = dr.GetBytes(0, 0, null, 0, 0);
                 byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                 dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                 PictureBox pic = new PictureBox();
                 pic.Width = 100;
                 pic.Height = 100;
                 pic.BackgroundImageLayout = ImageLayout.Stretch;*//*
                 MemoryStream ms = new MemoryStream(items);
                 Bitmap bit = new Bitmap(ms);
                 pic.BackgroundImage = bit;
                 flowLayoutPanel1.Controls.Add(pic);

             }
         }
         catch(SqlException ex)
         {
             MessageBox.Show(ex.Message);
         }*/

        //Displays the pictures to the floLayout from product table
        /* public void ShowPic()
         {
             SqlConnection msc = new SqlConnection("Server = LAPTOP-RS59N8IM;   database = Ecommerce; integrated security=true;");
             SqlCommand cmd = new SqlCommand("select photo, price, description from product");
             msc.Open();
             cmd.Connection = msc;
             SqlDataReader dr = cmd.ExecuteReader();

             while (dr.Read())
             {
                 long len = dr.GetBytes(0, 0, null, 0, 0);
                 byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                 dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                 PictureBox pic = new PictureBox();
                 pic.Width = 100;
                 pic.Height = 100;
                 pic.BackgroundImageLayout = ImageLayout.Stretch;
                 MemoryStream ms = new MemoryStream(array);
                 Bitmap bit = new Bitmap(ms);
                 pic.BackgroundImage = bit;
                 flowLayoutPanel1.Controls.Add(pic);

                 Label description = new Label();
                 description.Text = dr["description"].ToString();
                 description.BackColor = Color.FromArgb(0, 26, 102);
                 description.Dock = DockStyle.Top;
                 description.Width = 100;
                 description.Height = 100;
                 description.BackgroundImageLayout = ImageLayout.Stretch;
                 pic.Controls.Add(descripton);
                 flowLayoutPanel1.Controls.Add(description);

                 Label price = new Label();
                 price.Text = dr["price"].ToString();
                 price.BackColor = Color.FromArgb(0, 26, 102);
                 price.Dock = DockStyle.Top;
                 price.Width = 100;
                 price.Height = 100;
                 price.BackgroundImageLayout = ImageLayout.Stretch;
                 pic.Controls.Add(price);
                 flowLayoutPanel1.Controls.Add(price);
             }
             dr.Close();
             msc.Close();

         }*/

        /*public void ShowPrice()
        {
            SqlConnection msc = new SqlConnection("Server = LAPTOP-RS59N8IM;   database = Ecommerce; integrated security=true;");
            SqlCommand cmd = new SqlCommand("select price from product");
            msc.Open();
            cmd.Connection = msc;
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Label price = new Label();
                price.Text = dr["price"].ToString();
                price.BackColor = Color.FromArgb(0, 26, 102);
                price.Dock = DockStyle.Top;
                price.Width = 100;
                price.Height = 100;
                price.BackgroundImageLayout = ImageLayout.Stretch;
                pic.Controls.Add(price);
                flowLayoutPanel1.Controls.Add(price);
            }
            dr.Close();
            msc.Close();

        }*/
        /*public void ShowDescription()
        {
            SqlConnection msc = new SqlConnection("Server = LAPTOP-RS59N8IM;   database = Ecommerce; integrated security=true;");
            SqlCommand cmd = new SqlCommand("select description from product");
            msc.Open();
            cmd.Connection = msc;
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Label description = new Label();
                description.Text = dr["description"].ToString();
                description.BackColor = Color.FromArgb(0, 26, 102);
                description.Dock = DockStyle.Top;
                description.Width = 100;
                description.Height = 100;
                description.BackgroundImageLayout = ImageLayout.Stretch;
                pic.Controls.Add(descripton);
                flowLayoutPanel1.Controls.Add(description);
            }
            dr.Close();
            msc.Close();

        }*/
        private void button4_Click(object sender, EventArgs e)
        {
            Newcart nc = new Newcart();
            flowLayoutPanel1.Controls.Clear();
            nc.Dock = DockStyle.Fill;
            flowLayoutPanel1.Controls.Add(nc.panel1);
            flowLayoutPanel1.Show();
            flowLayoutPanel1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            flowLayoutPanel1.Controls.Clear();
            l.Dock = DockStyle.Fill;
            flowLayoutPanel1.Controls.Add(l.panel1);
            flowLayoutPanel1.Show();
            flowLayoutPanel1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewSignUp newsu = new NewSignUp();
            flowLayoutPanel1.Controls.Clear();
            newsu.Dock = DockStyle.Fill;
            flowLayoutPanel1.Controls.Add(newsu.panel1);
            flowLayoutPanel1.Show();
            flowLayoutPanel1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            flowLayoutPanel1.Controls.Clear();
            h.Dock = DockStyle.Fill;
            flowLayoutPanel1.Controls.Add(h.flowLayoutPanel1);
            flowLayoutPanel1.Show();
            flowLayoutPanel1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(comboBox1.Text == "All")
            {

            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
