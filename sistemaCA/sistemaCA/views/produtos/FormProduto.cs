using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.views.produtos
{
    public partial class formProduto : Form
    {
        public formProduto()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var pro = from produto in db.tblprodutos select produto;

            dgw_produto.DataSource = pro;

            dgw_produto.Columns["id_produto"].HeaderText = "ID";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
