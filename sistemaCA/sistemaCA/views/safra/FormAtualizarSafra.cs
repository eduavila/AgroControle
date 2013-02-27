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
    public partial class FormAtualizarSafra : Form
    {
        public FormAtualizarSafra()
        {
            InitializeComponent();
        }

        public FormAtualizarSafra(int id_safra)
        {
            InitializeComponent();


            Safra safra = new Safra();
            safra.VisualizarSafra(id_safra);


            tb_idsafra.Text = safra.IdSafra.ToString() ;
            tb_descricao.Text = safra.Descricao;
            tb_status.Text = safra.status;
            dt_datainicio.Value =DateTime.Parse(safra.DataInicio.ToString());

           
            
            tb_obs.Text = safra.Obs;



            tb_idsafra.Enabled = false;
            tb_descricao.Enabled = false;
            tb_status.Enabled = false;
            dt_datainicio.Enabled = false;
            dt_datainicio.Enabled = false;
            tb_obs.Enabled = false;


        
        
        }

        private void FormAtualizarSafra_Load(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

            tb_idsafra.Enabled = true;
            tb_descricao.Enabled = true;
            tb_status.Enabled = true;
            dt_datainicio.Enabled = true;
            dt_datainicio.Enabled = true;
            tb_obs.Enabled = true;

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Safra safra = new Safra();


                safra.IdSafra = int.Parse(tb_idsafra.Text);
                safra.Descricao = tb_descricao.Text;
                safra.status = tb_status.Text;
                safra.DataInicio = dt_datainicio.Value;
                safra.DataFechamento = dt_datainicio.Value;
                safra.Obs = tb_obs.Text;

                safra.AtualizarSafra();
                MessageBox.Show("Alterado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                
            }

        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Tem certeza que deseja deletar o registo? ", "Deletar registro",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {

                Safra safra = new Safra();
                safra.DeletarSafra(int.Parse(tb_idsafra.Text));

                MessageBox.Show("Registro excluido com sucesso!");

            }
            else
            {
                Close();
                    
            }

        }

        private void btn_fsafra_Click(object sender, EventArgs e)
        {
          
        }
    }
}
