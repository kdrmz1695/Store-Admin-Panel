using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KocTasMall
{
    public partial class Form1 : Form
    {
        KocTasDbContext context = new KocTasDbContext();
        public Form1()
        {
            InitializeComponent();
            listCategory();
            
        }

        private void listCategory()
        {
            var query = from c in context.PCategories
                        where c.IsDeleted == false
                        select new
                        {
                            c.Id,
                            c.CategoryName
                        };
            this.comboBoxCategoryList.ValueMember = "Id";
            this.comboBoxCategoryList.DisplayMember = "CategoryName";
            this.comboBoxCategoryList.DataSource = query.ToList();
        }

        private void buttonPAdd_Click(object sender, EventArgs e)
        {
            string pname = textBoxPName.Text;
            int price = 0;
            if (string.IsNullOrEmpty(textBoxPPrice.Text))
            {
                MessageBox.Show(" The Price Can not be empty");
                return;
            }
            if (!int.TryParse(textBoxPPrice.Text, out price))
            {
                MessageBox.Show("price geçerli değil");
                return;
            }
            if (price == 0)
            {
                MessageBox.Show("Price can not be 0");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxPName.Text))
            {
                MessageBox.Show("Please enter a valid name");
                return;
            }
            PCategory pCategory = new PCategory()
            {

                CategoryName = textBoxPCat.Text,
                IsDeleted = false,
                products = new HashSet<Product>() { new Product() { ProductName = pname, Price = price, IsDeleted = false } }

            };
            context.Add(pCategory);
            context.SaveChanges();
            getList();
            MessageBox.Show("Item Added");
        }
        private void buttonListP_Click(object sender, EventArgs e)
        {
            getList();
        }
        private void getList()
        {

            var query = from p in context.Products
                        join c in context.PCategories
                        on p.PCategoryId equals c.Id
                        where c.IsDeleted == false && p.IsDeleted == false
                        select new
                        {
                            p.Id,
                            p.ProductName,
                            p.Price,
                            c.CategoryName,
                        };
            dataGridViewScreen.DataSource = query.ToList();
        }

        private void buttonPUp_Click(object sender, EventArgs e) //item id ve kategori id'sini girip update ediyoruz.
        {
            int id = Convert.ToInt32(textBoxPID.Text);
            var update = context.Products.Find(id);
            var cat = context.PCategories.Find(id);
            update.ProductName = textBoxPName.Text;
            update.Price = Convert.ToInt32(textBoxPPrice.Text);
            update.IsDeleted = false;
            cat.CategoryName = textBoxPCat.Text;
            context.SaveChanges();
            getList();
            MessageBox.Show("Item Updated");
        }

        private void buttonPDel_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxPID.Text);
            var delete = context.Products.Find(id);
            delete.IsDeleted = true;
            context.SaveChanges();
            getList();
            MessageBox.Show("Item has been deleted!");
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = ((System.Windows.Forms.DataGridView)sender).CurrentRow;
            if (selectedRow != null)
            {
                textBoxPID.Text = selectedRow.Cells?[0].Value.ToString();
                textBoxPName.Text = selectedRow?.Cells?[1].Value.ToString();
                textBoxPPrice.Text = selectedRow.Cells?[2].Value.ToString();
                // textBoxPCat.Text = selectedRow.Cells?[3].Value.ToString();
            }

        }

        private void textBoxPPrice_TextChanged(object sender, EventArgs e)
        {
            textBoxPPrice.MaxLength = 5;
        }

        private void textBoxPPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Onlynumbers(sender, e);

        }

        private void Onlynumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBoxPID_TextChanged(object sender, EventArgs e)
        {
            textBoxPID.Enabled = false;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchproduct = textBoxSearch.Text;
            var searchquery = from p in context.Products
                              join c in context.PCategories
                              on p.PCategoryId equals c.Id
                              where p.ProductName.Contains(searchproduct) && p.IsDeleted == false && c.IsDeleted == false

                              select new
                              {
                                  p.Id,
                                  p.ProductName,
                                  p.Price,
                                  c.CategoryName

                              };
            dataGridViewScreen.DataSource = searchquery.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kocTasDbDataSet.PCategories' table. You can move, or remove it, as needed.
            this.pCategoriesTableAdapter.Fill(this.kocTasDbDataSet.PCategories);

        }

        private void comboBoxShortby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxShortby.Text == "A to Z")
            {
                var querry = from p in context.Products
                             join c in context.PCategories
                             on p.PCategoryId equals c.Id
                             where p.IsDeleted == false && c.IsDeleted == false
                             orderby p.ProductName
                             select new
                             {
                                 p.Id,
                                 p.ProductName,
                                 p.Price,
                                 c.CategoryName
                             };
                dataGridViewScreen.DataSource = querry.ToList();
                return;

            }
            if (comboBoxShortby.Text == "Z to A")
            {
                var listAZ = from p in context.Products
                             join c in context.PCategories
                             on p.PCategoryId equals c.Id
                             where p.IsDeleted == false && c.IsDeleted == false
                             orderby p.ProductName descending
                             select new
                             {
                                 p.Id,
                                 p.ProductName,
                                 p.Price,
                                 c.CategoryName
                             };
                dataGridViewScreen.DataSource = listAZ.ToList();
                return;
            }
            if (comboBoxShortby.Text == "Lowest Price")
            {

                var listAZ = from p in context.Products
                             join c in context.PCategories
                             on p.PCategoryId equals c.Id
                             orderby p.Price
                             where p.IsDeleted == false && c.IsDeleted == false
                             select new
                             {
                                 p.Id,
                                 p.ProductName,
                                 p.Price,
                                 c.CategoryName
                             };
                dataGridViewScreen.DataSource = listAZ.ToList();
                return;
            }
            if (comboBoxShortby.Text == "Highest Price")
            {
                var listAZ = from p in context.Products
                             join c in context.PCategories
                             on p.PCategoryId equals c.Id
                             orderby p.Price descending
                             where p.IsDeleted == false && c.IsDeleted == false
                             select new
                             {
                                 p.Id,
                                 p.ProductName,
                                 p.Price,
                                 c.CategoryName
                             };
                dataGridViewScreen.DataSource = listAZ.ToList();
                return;
            }
        }

        private void comboBoxCategoryList_SelectedValueChanged(object sender, System.EventArgs e)
        {
            int selectedIndex = ((ComboBox)sender).SelectedIndex;
            if (selectedIndex < 1)
            {
                return;
            }
            var query = from p in context.Products
                        join c in context.PCategories
                        on p.PCategoryId equals c.Id
                        where c.Id == (int)(((ComboBox)sender).SelectedValue) && p.IsDeleted == false && c.IsDeleted == false
                        select new
                        {
                            p.Id,
                            p.ProductName,
                            p.Price,
                            c.CategoryName
                        };
            listCategory();
            dataGridViewScreen.DataSource = query.ToList();
            return;
        }
    }
}
