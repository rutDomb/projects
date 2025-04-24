using BO;


namespace UI
{
    public partial class ProductMenu : Form
    {
        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();
        public ProductMenu()
        {
            InitializeComponent();
            List<Product> list = s_bl.Product.ReadAll();
            list=list.OrderBy(p => p.Code).ToList();
            foreach (var item in list)
            {
                listBox1.Items.Add(item.ToStringProperty());
                search.Items.Add(item.Code);
            }

        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product(0, name.Text, (Category)Enum.Parse(typeof(Category), category.SelectedItem.ToString()), int.Parse(price.Text), int.Parse(QuantityInStock.Text), "");
                s_bl.Product.Create(p);
                MessageBox.Show("המוצר נוסף בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                s_bl.Product.Delete(int.Parse(code.Text));
                MessageBox.Show("המוצר נמחק בהצלחה.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product(int.Parse(codeEdit.Text), nameEdit.Text, (Category)Enum.Parse(typeof(Category), catregoryEdit.SelectedItem.ToString()), int.Parse(priceEdit.Text), int.Parse(QuantityInStockEdit.Text), "");
                s_bl.Product.Update(p);
                MessageBox.Show("המוצר עודכן בהצלחה.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Product p = s_bl.Product.Read(int.Parse(search.Text));
                listBox1.Items.Clear();
                listBox1.Items.Add(p.ToStringProperty());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void readAll_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                List<Product> list = s_bl.Product.ReadAll();
                list = list.OrderBy(p => p.Code).ToList();
                foreach (var item in list)
                {
                    listBox1.Items.Add(item.ToStringProperty());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filter_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                List<Product> list = s_bl.Product.ReadAll(p => p.Price < 200);
                list = list.OrderBy(p => p.Code).ToList();
                foreach (var item in list)
                {
                    listBox1.Items.Add(item.ToStringProperty());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductMenu_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
