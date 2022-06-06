namespace BikeStore.WinForm.Forms
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_product = new System.Windows.Forms.DataGridView();
            this.button_new_record = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_new_record);
            this.groupBox1.Controls.Add(this.dataGridView_product);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 503);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünler";
            // 
            // dataGridView_product
            // 
            this.dataGridView_product.AllowUserToAddRows = false;
            this.dataGridView_product.AllowUserToDeleteRows = false;
            this.dataGridView_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_product.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_product.Location = new System.Drawing.Point(3, 52);
            this.dataGridView_product.Name = "dataGridView_product";
            this.dataGridView_product.ReadOnly = true;
            this.dataGridView_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_product.Size = new System.Drawing.Size(911, 448);
            this.dataGridView_product.TabIndex = 0;
            this.dataGridView_product.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_product_CellDoubleClick);
            // 
            // button_new_record
            // 
            this.button_new_record.Location = new System.Drawing.Point(6, 19);
            this.button_new_record.Name = "button_new_record";
            this.button_new_record.Size = new System.Drawing.Size(81, 27);
            this.button_new_record.TabIndex = 1;
            this.button_new_record.Text = "Ekle";
            this.button_new_record.UseVisualStyleBackColor = true;
            this.button_new_record.Click += new System.EventHandler(this.button_new_record_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 503);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_product;
        private System.Windows.Forms.Button button_new_record;
    }
}