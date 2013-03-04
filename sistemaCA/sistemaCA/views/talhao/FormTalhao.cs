using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sistemaCA.views.talhao
{
    public partial class FormTalhao : Form
    {
        public FormTalhao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCadastroTalhao Cadastrotalhao = new FormCadastroTalhao();
            Cadastrotalhao.ShowDialog();

            Talhao talhao =new  Talhao();
            talhao.ListarTalhao(dgw_talhao);
        }

        private void FormTalhao_Load(object sender, EventArgs e)
        {
            Talhao talhao = new Talhao();
            talhao.ListarTalhao(dgw_talhao);

            dgw_talhao.Columns["id_talhao"].HeaderText = "ID";
            dgw_talhao.Columns["descricao"].HeaderText = "Descrição";
            dgw_talhao.Columns["obs"].HeaderText = "Observação";
            dgw_talhao.Columns["localizacao"].HeaderText = "Localização";
            dgw_talhao.Columns["tamanho"].HeaderText = "Área em Hectáres";
            dgw_talhao.Columns["sistemacutivo"].HeaderText = "Tipo Plantio";




            btn_cadastrar.Focus();
            
        }

        private void tb_pesquisar_TextChanged(object sender, EventArgs e)
        {
            Talhao talhao = new Talhao();
            if (tb_pesquisar.Text == " ")
            {
                
                talhao.ListarTalhao(dgw_talhao);

            }
            else {
                talhao.Pesquisar(tb_pesquisar.Text, dgw_talhao);        
            }
        }

        private void btn_Visalizar_Click(object sender, EventArgs e)
        {
            if (dgw_talhao.CurrentCell != null)
            {
                // Pegando o valor do id 
                int selecionado = dgw_talhao.CurrentCell.RowIndex;

                int idtalhao;

                idtalhao = int.Parse(dgw_talhao.Rows[selecionado].Cells["id_talhao"].Value.ToString());


                FormAtualizarTalhao formAtualizar = new FormAtualizarTalhao(idtalhao);
                formAtualizar.ShowDialog();


                // atualizando Data Grid
                Talhao talhao = new Talhao();

                talhao.ListarTalhao(dgw_talhao);

            }
        }


        
    }
}
