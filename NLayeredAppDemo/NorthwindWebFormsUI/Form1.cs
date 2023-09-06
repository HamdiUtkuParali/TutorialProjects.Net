using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindWebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            
            cbxCategorySearch.DataSource = _categoryService.GetAll();
            cbxCategorySearch.DisplayMember = "CategoryName";
            cbxCategorySearch.ValueMember = "CategoryId";

            cbxCategoryAdd.DataSource = _categoryService.GetAll();
            cbxCategoryAdd.DisplayMember = "CategoryName";
            cbxCategoryAdd.ValueMember = "CategoryId";

            cbxCategoryUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryUpdate.DisplayMember = "CategoryName";
            cbxCategoryUpdate.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategorySearch.SelectedValue));
            }

            catch 
            {
                
            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tbxProductNameSearch.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductNameSearch.Text);
            }

            else
            {
                LoadProducts();
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product 
            {
                CategoryId = Convert.ToInt32(cbxCategoryAdd.SelectedValue),
                ProductName = tbxProductNameAdd.Text,
                QuantityPerUnit = tbxQuantityPerUnitAdd.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceAdd.Text),
                UnitsInStock = Convert.ToInt16(tbxUnitsInStockAdd.Text)
            });

            MessageBox.Show("Ürün Eklendi");
            LoadProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxProductNameUpdate.Text,
                CategoryId = Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
                UnitsInStock = Convert.ToInt16(tbxUnitsInStockUpdate.Text),
                QuantityPerUnit = tbxQuantityPerUnitUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text)
            });
            MessageBox.Show("Ürün güncellendi");
            LoadProducts();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxProductNameUpdate.Text = row.Cells[1].Value.ToString();
            cbxCategoryUpdate.SelectedValue = row.Cells[2].Value;
            tbxUnitPriceUpdate.Text = row.Cells[3].Value.ToString();
            tbxQuantityPerUnitUpdate.Text = row.Cells[4].Value.ToString();
            tbxUnitsInStockUpdate.Text = row.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün silindi");
                    LoadProducts();
                }
                catch(Exception exeption) 
                { 
                    MessageBox.Show(exeption.Message);
                }
            }
            
        }
    }
}
