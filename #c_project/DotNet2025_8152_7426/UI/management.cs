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
    public partial class management : Form
    {
        public management()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductMenu productMenu = new ProductMenu();
            productMenu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaleMenu saleMenu = new SaleMenu();
            saleMenu.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClientMenu clientMenu = new ClientMenu();
            clientMenu.ShowDialog();
        }
    }
}
