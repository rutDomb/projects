using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class SaleMenu : Form
    {
        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();
        public SaleMenu()
        {
            InitializeComponent();
            List<Sale> list = s_bl.Sale.ReadAll();
            list = list.OrderBy(s => s.Id).ToList();
            foreach (var item in list)
            {
                listBox1.Items.Add(item.ToStringProperty());
                search.Items.Add(item.Id);
            }
        }


        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                Sale s = new Sale(0, int.Parse(code.Text), int.Parse(amountForSale.Text), int.Parse(priceForSale.Text), isForEveryone.Checked, dateStart.Value, dateFinifh.Value);
                s_bl.Sale.Create(s);
                MessageBox.Show("המבצע נוסף בהצלחה");
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
                Product? p = s_bl.Product.Read(int.Parse(codeProductEdit.Text));
                if (p != null)
                {
                    Sale s = new Sale(int.Parse(codeSale.Text), int.Parse(codeProductEdit.Text), int.Parse(AmountForSaleEdit.Text), double.Parse(PriceForSaleEdit.Text), IsForEveryoneEdit.Checked, DateStartEdit.Value, DateFinifhEdit.Value);
                    s_bl.Sale.Update(s);
                    MessageBox.Show("המבצע עודכן בהצלחה");
                }
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
                s_bl.Sale.Delete(int.Parse(codeToDelete.Text));
                MessageBox.Show("המצבע נמחק בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void tabPage1_Click(object sender, EventArgs e)
        //{

        //}

        //private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        //{

        //}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Sale s = s_bl.Sale.Read(int.Parse(search.Text));
                listBox1.Items.Clear();
                listBox1.Items.Add(s.ToStringProperty());
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
                List<Sale> list = s_bl.Sale.ReadAll();
                list = list.OrderBy(s => s.Id).ToList();
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
                List<Sale> list = s_bl.Sale.ReadAll(s => s.IsForEveryone == true);
                list=list.OrderBy(s => s.Id).ToList();
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

        private void SaleMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
