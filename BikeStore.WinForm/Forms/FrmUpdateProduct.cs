using BikeStore.WinForm.Models.StoredProcedures;
using BikeStore.WinForm.Repositories.Concrete;
using System;
using System.Windows.Forms;

namespace BikeStore.WinForm.Forms
{
    public partial class FrmUpdateProduct : Form
    {
        private int _product_id;

        public FrmUpdateProduct(int product_id)
        {
            InitializeComponent();
            _product_id = product_id;
        }

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            GetBrands();
            GetCategories();
            GetById();
        }

        private void GetBrands()
        {
            using (BrandRepository brandRepository = new BrandRepository())
            {
                comboBox_brand.ValueMember = "brand_id";
                comboBox_brand.DisplayMember = "brand_name";
                comboBox_brand.DataSource = brandRepository.GetAllData();
            }
        }

        private void GetCategories()
        {
            using (CategoryRepository categoryRepository = new CategoryRepository())
            {
                comboBox_category.ValueMember = "category_id";
                comboBox_category.DisplayMember = "category_name";
                comboBox_category.DataSource = categoryRepository.GetAllData();
            }
        }

        private void GetById()
        {
            using (ProductRepository productRepository = new ProductRepository())
            {
                var dataItem = productRepository.GetDataById(_product_id);
                textBox_product_name.Text = dataItem.product_name;
                textBox_product_price.Text = dataItem.list_price.ToString();
                textBox_product_year.Text = dataItem.model_year.ToString();
                comboBox_brand.SelectedValue = dataItem.brand_id;
                comboBox_category.SelectedValue = dataItem.category_id;
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            using (ProductRepository productRepository = new ProductRepository())
            {
                UpdateProductSp updateProductSp = new UpdateProductSp
                {
                    brand_id = Convert.ToInt32(comboBox_brand.SelectedValue),
                    category_id = Convert.ToInt32(comboBox_category.SelectedValue),
                    list_price = Convert.ToDecimal(textBox_product_price.Text),
                    model_year = Convert.ToInt32(textBox_product_year.Text),
                    product_name = textBox_product_name.Text,
                    product_id = _product_id
                };
                int resultProduct = productRepository.UpdateData(updateProductSp);
                if (resultProduct == 1)
                {
                    MessageBox.Show("Ürün Güncellendi", "Bilgi");
                    this.Close();
                }
                else
                    MessageBox.Show("Ürün Güncellenemedi", "Bilgi");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            using (ProductRepository productRepository = new ProductRepository())
            {
                UpdateProductSp deleteProductSp = new UpdateProductSp
                {
                    product_id = _product_id
                };
                int resultProduct = productRepository.DeleteData(deleteProductSp);
                if (resultProduct == 1)
                {
                    MessageBox.Show("Ürün Silindi", "Bilgi");
                    this.Close();
                }
                else
                    MessageBox.Show("Ürün Silinemedi", "Bilgi");
            }
        }
    }
}
