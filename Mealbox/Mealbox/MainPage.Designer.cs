﻿
namespace Mealbox
{
    partial class MainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "angemeldet als :";
            // 
            // btn_customer
            // 
            this.btn_customer.Location = new System.Drawing.Point(205, 71);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(416, 83);
            this.btn_customer.TabIndex = 2;
            this.btn_customer.Text = "Kundeneinstellungen";
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_product
            // 
            this.btn_product.Location = new System.Drawing.Point(205, 160);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(416, 83);
            this.btn_product.TabIndex = 3;
            this.btn_product.Text = "Produkteinstellungen";
            this.btn_product.UseVisualStyleBackColor = true;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(205, 249);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(416, 83);
            this.btn_menu.TabIndex = 4;
            this.btn_menu.Text = "Menüteinstellungen";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(546, 372);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Ausloggen";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_product);
            this.Controls.Add(this.btn_customer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_logout;
    }
}