namespace BikeStore.WinForm.Forms
{
    partial class FrmAddProduct
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
            this.comboBox_brand = new System.Windows.Forms.ComboBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.textBox_product_name = new System.Windows.Forms.TextBox();
            this.textBox_product_year = new System.Windows.Forms.TextBox();
            this.textBox_product_price = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_brand
            // 
            this.comboBox_brand.FormattingEnabled = true;
            this.comboBox_brand.Location = new System.Drawing.Point(82, 32);
            this.comboBox_brand.Name = "comboBox_brand";
            this.comboBox_brand.Size = new System.Drawing.Size(259, 21);
            this.comboBox_brand.TabIndex = 0;
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(82, 59);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(259, 21);
            this.comboBox_category.TabIndex = 0;
            // 
            // textBox_product_name
            // 
            this.textBox_product_name.Location = new System.Drawing.Point(82, 86);
            this.textBox_product_name.Name = "textBox_product_name";
            this.textBox_product_name.Size = new System.Drawing.Size(259, 20);
            this.textBox_product_name.TabIndex = 1;
            // 
            // textBox_product_year
            // 
            this.textBox_product_year.Location = new System.Drawing.Point(82, 112);
            this.textBox_product_year.Name = "textBox_product_year";
            this.textBox_product_year.Size = new System.Drawing.Size(259, 20);
            this.textBox_product_year.TabIndex = 1;
            // 
            // textBox_product_price
            // 
            this.textBox_product_price.Location = new System.Drawing.Point(82, 138);
            this.textBox_product_price.Name = "textBox_product_price";
            this.textBox_product_price.Size = new System.Drawing.Size(259, 20);
            this.textBox_product_price.TabIndex = 1;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(82, 164);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(84, 32);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Güncelle";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(257, 164);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(84, 32);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "Sil";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Yılı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fiyat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_brand);
            this.groupBox1.Controls.Add(this.comboBox_category);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_product_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_product_year);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_product_price);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_update);
            this.groupBox1.Controls.Add(this.button_delete);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 208);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            // 
            // FrmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 208);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekle";
            this.Load += new System.EventHandler(this.FrmAddProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_brand;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.TextBox textBox_product_name;
        private System.Windows.Forms.TextBox textBox_product_year;
        private System.Windows.Forms.TextBox textBox_product_price;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}