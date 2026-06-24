using ProductsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProductsPresentation
{
    public partial class frmSearch : Form
    {
        public Action<int> ProductSelected;
       

        public frmSearch()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            var products = await clsGlobal.Client.GetFromJsonAsync<List<ProductDTO>>($"Search?name={name}");
            dataGridView1.DataSource = products;
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                return;
            }
            int productID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            ProductSelected?.Invoke(productID);
            this.Close();
        }
    }
}
