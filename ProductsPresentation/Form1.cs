using ProductsModels;
using System.ComponentModel;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProductsPresentation
{
    public partial class Form1 : Form
    {
        ProductDTO product = new ProductDTO();
        enum enMode
        {
            AddNew,Update
        }
        enMode Mode = enMode.AddNew;
        public Form1()
        {
            InitializeComponent();
        }
        private async Task _LoadData()
        {
            try
            {
                var Data = await clsGlobal.Client.GetFromJsonAsync<List<ProductDTO>>("All");

                dataGridView1.DataSource = Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            await _LoadData();
        }
        private async void _AddNew()
        {

            var responce = await clsGlobal.Client.PostAsJsonAsync<ProductDTO>("AddNew", product);
            if (responce.IsSuccessStatusCode)
            {
                var productInfo = await responce.Content.ReadFromJsonAsync<ProductDTO>();
                if (productInfo == null)
                {
                    MessageBox.Show("Saving Data Failed");
                    return;
                }
                product.Id = productInfo.Id;
                lblID.Text = product.Id.ToString();
                Mode = enMode.Update;
            }
            await _LoadData();
        }
        private async void _Update()
        {
            var responce = await clsGlobal.Client.PutAsJsonAsync<ProductDTO>("Update", product);
            if (responce.IsSuccessStatusCode)
            {
                var productInfo = await responce.Content.ReadFromJsonAsync<ProductDTO>();
                if (productInfo == null)
                {
                    MessageBox.Show("Saving Data Failed");
                    return;
                }
              
            }
            await _LoadData();
        }
        private void Save()
        {
            product.Price = Convert.ToDecimal(txtPrice.Text);
            product.Tax = Convert.ToDecimal(txtTax.Text);
            product.ProductName = txtName.Text;
            product.Quantity = Convert.ToInt32(txtQuantity.Text);
            product.CreatedAt = DateTime.Now;
            if (Mode == enMode.AddNew)
                _AddNew();
            else
                _Update();
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {

           
        }

        private void CalculateTotalPrice()
        {
            if (!string.IsNullOrWhiteSpace(txtTax.Text) && !string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                lblTotal.Text = (
                    Convert.ToDecimal(txtPrice.Text)
                    +
                    (
                    Convert.ToDecimal(txtPrice.Text) * Convert.ToDecimal(txtTax.Text)
                    )
                    ).ToString();
            }
            else
            {
                lblTotal.Text = "[????]";
            }
        }
        private void txtTax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTax_TextChanged_1(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void txtPrice_TextChanged_1(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await _LoadData();
        }
        private async void OnProductSelected(int id)
        {
             product = await clsGlobal.Client.GetFromJsonAsync<ProductDTO>($"{id}");

            FillProductInfo();

            
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch search = new frmSearch();
            search.ProductSelected += OnProductSelected;
            search.ShowDialog();
        }
        private void FillProductInfo()
        {
            if (product != null)
            {
                lblID.Text = product.Id.ToString();
                lblCreatedAt.Text = product.CreatedAt.ToString("yyyy/MM/dd");
                lblTotal.Text = product.Total.ToString();
                txtName.Text = product.ProductName;
                txtPrice.Text = product.Price.ToString();
                txtQuantity.Text = product.Quantity.ToString();
                txtTax.Text = product.Tax.ToString();
            }
        }
        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int productID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            product = await clsGlobal.Client.GetFromJsonAsync<ProductDTO>($"{productID}");

            FillProductInfo();
            
        }
    }
}
