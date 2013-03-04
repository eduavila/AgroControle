using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.views.safra
{
    public partial class FormSafra : Form
    {
        public FormSafra()
        {
            InitializeComponent();



        }

        private void FormSafra_Load(object sender, EventArgs e)
        {
            Safra safra = new Safra();
            safra.ListarSafra(dgw_safra);

            dgw_safra.Columns["id_safra"].HeaderText = "ID";
            dgw_safra.Columns["descricao"].HeaderText = "Descrição";
            dgw_safra.Columns["obs"].HeaderText = "Observação";
            dgw_safra.Columns["status"].HeaderText = "Status";
            dgw_safra.Columns["dataincio"].HeaderText = "Data Inicio";
            dgw_safra.Columns["datafechamento"].HeaderText = "Data Fechamento";
            dgw_safra.Columns["id_cultura"].HeaderText = "ID Cultura";
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroSafra formCada = new FormCadastroSafra();
            formCada.ShowDialog();


            Safra safra = new Safra();
            safra.ListarSafra(dgw_safra);

        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
           // pega id da cell selecionada
            if (dgw_safra.CurrentCell != null)
            {
                int selecionado = dgw_safra.CurrentCell.RowIndex;
                int idsafra;

                idsafra = int.Parse(dgw_safra.Rows[selecionado].Cells["id_safra"].Value.ToString());

                FormAtualizarSafra fromAtualizar = new FormAtualizarSafra(idsafra);
                fromAtualizar.ShowDialog();


                // atualiza grid safra
                Safra safra2 = new Safra();

                safra2.ListarSafra(dgw_safra);
            }
        }
    }
}
