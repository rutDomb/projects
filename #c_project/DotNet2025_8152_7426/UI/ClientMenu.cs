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
    public partial class ClientMenu : Form
    {
        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();
        public ClientMenu()
        {
            InitializeComponent();
            List<Client> list = s_bl.Client.ReadAll();
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
                Client c = new Client(int.Parse(textId.Text), textName.Text, textAddess.Text, int.Parse(textPhone.Text));
                s_bl.Client.Create(c);
                MessageBox.Show("הלקוח נוסף בהצלחה.");
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
                Client c = new Client(int.Parse(idEdit.Text), nameEdit.Text, addressEdit.Text, int.Parse(phoneEdit.Text));
                s_bl.Client.Update(c);
                MessageBox.Show("הלקוח עודכן בהצלחה.");
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
                s_bl.Client.Delete(int.Parse(idToDelete.Text));
                MessageBox.Show("הלקוח נמחק בהצלחה.");
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
                List<Client> list = s_bl.Client.ReadAll();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Client c = s_bl.Client.Read(int.Parse(search.Text));
                listBox1.Items.Clear();
                listBox1.Items.Add(c.ToStringProperty());
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
                List<Client> list = s_bl.Client.ReadAll(c => c.UserName.Length < 15);
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

    }
}
