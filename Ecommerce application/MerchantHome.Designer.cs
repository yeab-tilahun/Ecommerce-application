﻿
namespace Ecommerce_application
{
    partial class MerchantHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelHome = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.label8);
            this.panelHome.Controls.Add(this.label9);
            this.panelHome.Controls.Add(this.label10);
            this.panelHome.Controls.Add(this.label11);
            this.panelHome.Controls.Add(this.label12);
            this.panelHome.Controls.Add(this.label13);
            this.panelHome.Location = new System.Drawing.Point(0, 1);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(812, 545);
            this.panelHome.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(149, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(496, 42);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cart store the things you selected to buy in Buy section and there\r\nyou can compl" +
    "ete the transaction \r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(149, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(482, 42);
            this.label9.TabIndex = 10;
            this.label9.Text = "If you want to buy products click Buy button and there you can \r\nbuy everything y" +
    "ou want.\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(149, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(479, 42);
            this.label10.TabIndex = 9;
            this.label10.Text = "If you want to sell your product go to Sell then you can add the \r\nproducts you h" +
    "ave.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(94, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(248, 26);
            this.label11.TabIndex = 8;
            this.label11.Text = "Welcome to Ecommerce application ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 18);
            this.label12.TabIndex = 7;
            this.label12.Text = "Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 37);
            this.label13.TabIndex = 6;
            this.label13.Text = "Time";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MerchantHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 545);
            this.Controls.Add(this.panelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MerchantHome";
            this.Text = "MerchantHomecs";
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timer1;
    }
}