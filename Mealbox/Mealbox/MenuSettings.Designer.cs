
namespace Mealbox
{
    partial class MenuSettings
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
            this.textBox_menutype = new System.Windows.Forms.TextBox();
            this.textBox_menuno = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_menuyeEkle = new System.Windows.Forms.Button();
            this.btn_menudenCikar = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_addcontent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_menutype
            // 
            this.textBox_menutype.Location = new System.Drawing.Point(179, 63);
            this.textBox_menutype.Name = "textBox_menutype";
            this.textBox_menutype.Size = new System.Drawing.Size(100, 23);
            this.textBox_menutype.TabIndex = 0;
            // 
            // textBox_menuno
            // 
            this.textBox_menuno.Location = new System.Drawing.Point(179, 92);
            this.textBox_menuno.Name = "textBox_menuno";
            this.textBox_menuno.Size = new System.Drawing.Size(100, 23);
            this.textBox_menuno.TabIndex = 1;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(179, 152);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 23);
            this.textBox_price.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(701, 166);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menü Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Menü No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Products";
            this.label4.Visible = false;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(508, 66);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(89, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Addieren";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(508, 110);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(89, 23);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Aktualisieren";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(508, 152);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(89, 23);
            this.btn_remove.TabIndex = 11;
            this.btn_remove.Text = "Löschen";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Zurück";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(72, 289);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 109);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 13;
            this.listBox1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Menu Content";
            this.label5.Visible = false;
            // 
            // btn_menuyeEkle
            // 
            this.btn_menuyeEkle.Location = new System.Drawing.Point(198, 311);
            this.btn_menuyeEkle.Name = "btn_menuyeEkle";
            this.btn_menuyeEkle.Size = new System.Drawing.Size(62, 23);
            this.btn_menuyeEkle.TabIndex = 16;
            this.btn_menuyeEkle.Text = ">>";
            this.btn_menuyeEkle.UseVisualStyleBackColor = true;
            this.btn_menuyeEkle.Visible = false;
            this.btn_menuyeEkle.Click += new System.EventHandler(this.btn_menuyeEkle_Click);
            // 
            // btn_menudenCikar
            // 
            this.btn_menudenCikar.Location = new System.Drawing.Point(198, 350);
            this.btn_menudenCikar.Name = "btn_menudenCikar";
            this.btn_menudenCikar.Size = new System.Drawing.Size(62, 23);
            this.btn_menudenCikar.TabIndex = 17;
            this.btn_menudenCikar.Text = "<<";
            this.btn_menudenCikar.UseVisualStyleBackColor = true;
            this.btn_menudenCikar.Visible = false;
            this.btn_menudenCikar.Click += new System.EventHandler(this.btn_menudenCikar_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(179, 181);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 23);
            this.btn_clear.TabIndex = 18;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Bezeichnung";
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(179, 121);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(100, 23);
            this.textBox_description.TabIndex = 20;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(266, 289);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 109);
            this.listBox3.TabIndex = 21;
            this.listBox3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_addcontent
            // 
            this.btn_addcontent.Location = new System.Drawing.Point(612, 63);
            this.btn_addcontent.Name = "btn_addcontent";
            this.btn_addcontent.Size = new System.Drawing.Size(132, 112);
            this.btn_addcontent.TabIndex = 23;
            this.btn_addcontent.Text = "Inhaltsseite";
            this.btn_addcontent.UseVisualStyleBackColor = true;
            this.btn_addcontent.Click += new System.EventHandler(this.btn_addcontent_Click);
            // 
            // MenuSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_addcontent);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_menudenCikar);
            this.Controls.Add(this.btn_menuyeEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_menuno);
            this.Controls.Add(this.textBox_menutype);
            this.Name = "MenuSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuSettings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuSettings_FormClosed);
            this.Load += new System.EventHandler(this.MenuSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_menutype;
        private System.Windows.Forms.TextBox textBox_menuno;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_menuyeEkle;
        private System.Windows.Forms.Button btn_menudenCikar;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_addcontent;
    }
}