using BikeStore.WinForm.Models.StoredProcedures;
using BikeStore.WinForm.Repositories.Concrete;
using System;
using System.Windows.Forms;

namespace BikeStore.WinForm.Forms
{
    public partial class FrmAddProduct : Form
    {
        public FrmAddProduct()
        {
            InitializeComponent();
        }

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            GetBrands();
            GetCategories();
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

        private void button_add_Click(object sender, EventArgs e)
        {
            using (ProductRepository productRepository = new ProductRepository())
            {
                UpdateProductSp updateProductSp = new UpdateProductSp
                {
                    brand_id = Convert.ToInt32(comboBox_brand.SelectedValue),
                    category_id = Convert.ToInt32(comboBox_category.SelectedValue),
                    product_name = textBox_product_name.Text,
                    list_price = Convert.ToDecimal(textBox_product_price.Text),
                    model_year = Convert.ToInt32(textBox_product_year.Text)
                };
                var resultProduct = productRepository.InsertData(updateProductSp);
                if (resultProduct > 0)
                {
                    MessageBox.Show("Ürün eklendi", "Bilgi");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ürün eklenemedi", "Bilgi");
                }
            }
        }
    }
}
