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
    public partial class LoginUser : Form
    {
        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();
        public LoginUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                //s_bl.Client.IsExist(int.Parse(id.Text));
                Order o = new Order(int.Parse(id.Text));
                o.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
    }
}
