using BikeStore.WinForm.Repositories.Concrete;
using System.Windows.Forms;

namespace BikeStore.WinForm.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            GetAllProduct();
        }

        public void GetAllProduct()
        {
            using (ProductRepository repository = new ProductRepository())
            {
                dataGridView_product.DataSource = repository.GetAll();
            }
        }

        private void button_new_record_Click(object sender, System.EventArgs e)
        {
            var frmAddProduct = new FrmAddProduct();
            frmAddProduct.ShowDialog(this);
        }

        private void dataGridView_product_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int product_id = (int)dataGridView_product.SelectedRows[0].Cells[0].Value;
            var frmAddProduct = new FrmUpdateProduct(product_id);
            frmAddProduct.ShowDialog(this);
        }

        private void button_refresh_Click(object sender, System.EventArgs e)
        {
            GetAllProduct();
        }
    }
}
