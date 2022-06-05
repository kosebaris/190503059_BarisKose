
namespace Mealbox
{
    partial class CustomerSettings
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_mobile = new System.Windows.Forms.TextBox();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_kart = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 231);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(686, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(226, 187);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 25;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(657, 92);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(90, 23);
            this.button_update.TabIndex = 24;
            this.button_update.Text = "Aktualisieren";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(657, 132);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(90, 23);
            this.button_remove.TabIndex = 23;
            this.button_remove.Text = "Löschen";
            this.button_remove.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(657, 49);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(90, 23);
            this.button_add.TabIndex = 22;
            this.button_add.Text = "Addieren";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mobil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(136, 129);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(165, 23);
            this.textBox_email.TabIndex = 17;
            // 
            // textBox_mobile
            // 
            this.textBox_mobile.Location = new System.Drawing.Point(136, 100);
            this.textBox_mobile.Name = "textBox_mobile";
            this.textBox_mobile.Size = new System.Drawing.Size(165, 23);
            this.textBox_mobile.TabIndex = 16;
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Location = new System.Drawing.Point(136, 71);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(165, 23);
            this.textBox_lastname.TabIndex = 15;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(136, 42);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(165, 23);
            this.textBox_name.TabIndex = 14;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(672, 387);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 26;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 30);
            this.label5.TabIndex = 27;
            this.label5.Text = "Kreditkarte\r\nnummer";
            // 
            // textBox_kart
            // 
            this.textBox_kart.Location = new System.Drawing.Point(136, 158);
            this.textBox_kart.Name = "textBox_kart";
            this.textBox_kart.Size = new System.Drawing.Size(165, 23);
            this.textBox_kart.TabIndex = 28;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(396, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(149, 139);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 29;
            // 
            // CustomerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox_kart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_mobile);
            this.Controls.Add(this.textBox_lastname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerSettings_FormClosing);
            this.Load += new System.EventHandler(this.CustomerSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_mobile;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_kart;
        private System.Windows.Forms.ListBox listBox1;
    }
}