﻿
namespace Ecommerce_application
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.pblTopNav = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblNav = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.AccountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMaximized = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.CloseM = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.pnlSideNav = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnLogo = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnAdmins = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnMerchants = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.pblTopNav.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlSideNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pblTopNav
            // 
            this.pblTopNav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pblTopNav.BackColor = System.Drawing.Color.Transparent;
            this.pblTopNav.Controls.Add(this.btnSetting);
            this.pblTopNav.Controls.Add(this.btnProfile);
            this.pblTopNav.Controls.Add(this.panel3);
            this.pblTopNav.Controls.Add(this.btnMaximized);
            this.pblTopNav.Controls.Add(this.btnMinimize);
            this.pblTopNav.Controls.Add(this.CloseM);
            this.pblTopNav.Controls.Add(this.lblNav);
            this.pblTopNav.Controls.Add(this.btnRestore);
            this.pblTopNav.Location = new System.Drawing.Point(160, 0);
            this.pblTopNav.Name = "pblTopNav";
            this.pblTopNav.Size = new System.Drawing.Size(940, 35);
            this.pblTopNav.TabIndex = 2;
            this.pblTopNav.Paint += new System.Windows.Forms.PaintEventHandler(this.pblTopNav_Paint);
            this.pblTopNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pblTopNav_MouseDown);
            this.pblTopNav.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pblTopNav_MouseMove);
            this.pblTopNav.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pblTopNav_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(536, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(38, 34);
            this.panel3.TabIndex = 35;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(38, 32);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // lblNav
            // 
            this.lblNav.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNav.Location = new System.Drawing.Point(6, 6);
            this.lblNav.Name = "lblNav";
            this.lblNav.Size = new System.Drawing.Size(197, 22);
            this.lblNav.TabIndex = 0;
            this.lblNav.Text = "Ecommerce Application";
            this.lblNav.Click += new System.EventHandler(this.lblNav_Click);
            // 
            // pnlCard
            // 
            this.pnlCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCard.AutoSize = true;
            this.pnlCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlCard.Location = new System.Drawing.Point(160, 35);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(940, 642);
            this.pnlCard.TabIndex = 3;
            this.pnlCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // 
            // btnSetting
            // 
            this.btnSetting.BackgroundImage = global::Ecommerce_application.Properties.Resources.Asset_49;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSetting.Location = new System.Drawing.Point(685, 7);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(111, 23);
            this.btnSetting.TabIndex = 37;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.BackgroundImage = global::Ecommerce_application.Properties.Resources.Asset_49;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProfile.Location = new System.Drawing.Point(580, 7);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(99, 23);
            this.btnProfile.TabIndex = 36;
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // AccountMenuItem
            // 
            this.AccountMenuItem.AutoSize = false;
            this.AccountMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AccountMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.AccountMenuItem.Image = global::Ecommerce_application.Properties.Resources.Group_3421;
            this.AccountMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AccountMenuItem.Name = "AccountMenuItem";
            this.AccountMenuItem.Size = new System.Drawing.Size(30, 30);
            this.AccountMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.AccountMenuItem.Click += new System.EventHandler(this.AccountMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.profileToolStripMenuItem.Text = "Your Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMaximized.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximized.FlatAppearance.BorderSize = 0;
            this.btnMaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximized.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximized.Image = global::Ecommerce_application.Properties.Resources.Maximize_20px;
            this.btnMaximized.Location = new System.Drawing.Point(875, 5);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(30, 25);
            this.btnMaximized.TabIndex = 31;
            this.btnMaximized.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaximized.UseVisualStyleBackColor = false;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Image = global::Ecommerce_application.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(840, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 25);
            this.btnMinimize.TabIndex = 29;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // CloseM
            // 
            this.CloseM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CloseM.AutoSize = true;
            this.CloseM.BackColor = System.Drawing.Color.Transparent;
            this.CloseM.BackgroundImage = global::Ecommerce_application.Properties.Resources.close_tab3;
            this.CloseM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseM.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.CloseM.FlatAppearance.BorderSize = 0;
            this.CloseM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseM.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseM.Location = new System.Drawing.Point(910, 5);
            this.CloseM.Margin = new System.Windows.Forms.Padding(2);
            this.CloseM.Name = "CloseM";
            this.CloseM.Size = new System.Drawing.Size(30, 25);
            this.CloseM.TabIndex = 17;
            this.CloseM.UseVisualStyleBackColor = false;
            this.CloseM.Click += new System.EventHandler(this.CloseM_Click);
            this.CloseM.MouseLeave += new System.EventHandler(this.CloseM_MouseLeave);
            this.CloseM.MouseHover += new System.EventHandler(this.CloseM_MouseHover);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Image = global::Ecommerce_application.Properties.Resources.Restore;
            this.btnRestore.Location = new System.Drawing.Point(875, 5);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(30, 25);
            this.btnRestore.TabIndex = 30;
            this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // pnlSideNav
            // 
            this.pnlSideNav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSideNav.BackColor = System.Drawing.Color.Transparent;
            this.pnlSideNav.BackgroundImage = global::Ecommerce_application.Properties.Resources.Asset_133;
            this.pnlSideNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSideNav.Controls.Add(this.txtSearch);
            this.pnlSideNav.Controls.Add(this.btnLogo);
            this.pnlSideNav.Controls.Add(this.btnCustomers);
            this.pnlSideNav.Controls.Add(this.btnAdmins);
            this.pnlSideNav.Controls.Add(this.btnRegister);
            this.pnlSideNav.Controls.Add(this.btnTransactions);
            this.pnlSideNav.Controls.Add(this.btnMerchants);
            this.pnlSideNav.Controls.Add(this.btnProducts);
            this.pnlSideNav.Location = new System.Drawing.Point(-1, -1);
            this.pnlSideNav.Name = "pnlSideNav";
            this.pnlSideNav.Size = new System.Drawing.Size(161, 679);
            this.pnlSideNav.TabIndex = 1;
            this.pnlSideNav.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSideNav_Paint);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.txtSearch.Location = new System.Drawing.Point(6, 220);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 25);
            this.txtSearch.TabIndex = 29;
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.BackgroundImage = global::Ecommerce_application.Properties.Resources.Asset_19;
            this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Location = new System.Drawing.Point(13, 13);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(136, 145);
            this.btnLogo.TabIndex = 7;
            this.btnLogo.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomers.BackgroundImage")));
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(6, 313);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(150, 25);
            this.btnCustomers.TabIndex = 6;
            this.btnCustomers.Text = "   Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnAdmins
            // 
            this.btnAdmins.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmins.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdmins.BackgroundImage")));
            this.btnAdmins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmins.FlatAppearance.BorderSize = 0;
            this.btnAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmins.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmins.Image")));
            this.btnAdmins.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmins.Location = new System.Drawing.Point(6, 377);
            this.btnAdmins.Name = "btnAdmins";
            this.btnAdmins.Size = new System.Drawing.Size(150, 25);
            this.btnAdmins.TabIndex = 5;
            this.btnAdmins.Text = "   Admins";
            this.btnAdmins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmins.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmins.UseVisualStyleBackColor = false;
            this.btnAdmins.Click += new System.EventHandler(this.btnAdmins_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(6, 408);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(150, 25);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "   Register Admins";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.Transparent;
            this.btnTransactions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransactions.BackgroundImage")));
            this.btnTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.Image = ((System.Drawing.Image)(resources.GetObject("btnTransactions.Image")));
            this.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.Location = new System.Drawing.Point(6, 344);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(150, 25);
            this.btnTransactions.TabIndex = 3;
            this.btnTransactions.Text = "   Transactions";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnMerchants
            // 
            this.btnMerchants.BackColor = System.Drawing.Color.Transparent;
            this.btnMerchants.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMerchants.BackgroundImage")));
            this.btnMerchants.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMerchants.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMerchants.FlatAppearance.BorderSize = 0;
            this.btnMerchants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMerchants.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerchants.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMerchants.Image = ((System.Drawing.Image)(resources.GetObject("btnMerchants.Image")));
            this.btnMerchants.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMerchants.Location = new System.Drawing.Point(6, 282);
            this.btnMerchants.Name = "btnMerchants";
            this.btnMerchants.Size = new System.Drawing.Size(150, 25);
            this.btnMerchants.TabIndex = 1;
            this.btnMerchants.Text = "   Merchants";
            this.btnMerchants.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMerchants.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMerchants.UseVisualStyleBackColor = false;
            this.btnMerchants.Click += new System.EventHandler(this.btnMerchants_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnProducts.BackgroundImage = global::Ecommerce_application.Properties.Resources.Asset_112;
            this.btnProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Image = global::Ecommerce_application.Properties.Resources.Asset_162;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(6, 251);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(150, 25);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "   Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1100, 677);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.pblTopNav);
            this.Controls.Add(this.pnlSideNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.pblTopNav.ResumeLayout(false);
            this.pblTopNav.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlSideNav.ResumeLayout(false);
            this.pnlSideNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideNav;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnAdmins;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnMerchants;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel pblTopNav;
        private System.Windows.Forms.Label lblNav;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Button CloseM;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AccountMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximized;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.TextBox txtSearch;
    }
}