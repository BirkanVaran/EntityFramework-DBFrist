using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkDBFrist_BLL.ViewModels;
using EntityFrameworkDBFrist_BLL;

namespace EntityFrameworkDBFirst_WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // GLOBAL ALAN
        ProductManager myProductManager = new ProductManager();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklenirken Grid'e product bilgileri gelsin.
            GrideProtuctlariGetir();
        }

        private void GrideProtuctlariGetir()
        {
            dataGridView1.DataSource = myProductManager.TumUrunleriGetir();
            dataGridView1.Columns["SupplierID"].Visible = false;
            dataGridView1.Columns["CategoryID"].Visible = false;

        }
    }
}
