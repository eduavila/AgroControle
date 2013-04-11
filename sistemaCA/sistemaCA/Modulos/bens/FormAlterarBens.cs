using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCA.views.bens
{
    public partial class FormAlterarBens : Form
    {
        public FormAlterarBens()
        {
            InitializeComponent();
        }

        public FormAlterarBens(int Id_bens)
        {

             InitializeComponent();
                
            
            
            // criando no bens;
                Bens Ben = new Bens();

                Ben.CaregarBen(Id_bens);
                // carregando inten no componetes
                tb_id.Text = Ben.ID_Bens.ToString();
                mtb_codigoControle.Text = Ben.Cod_Controle;
                tb_descricao.Text = Ben.Descricao;
                cb_tipo.Text = Ben.TipoBens;
                dtp_dataaquisicao.Value = Ben.Data_Aquisicao;
                tb_precoaquisicao.Text = Ben.Preco_Aquisicao.ToString();
                mtb_placa.Text = Ben.Placa;
                mtb_hododmetro.Text = Ben.Hodometro_incial.ToString();
                mtb_horimetro.Text = Ben.Horimetro_incial.ToString();


                tb_id.Enabled = false;
                mtb_codigoControle.Enabled = false;
                tb_descricao.Enabled = false;
                cb_tipo.Enabled = false;
                dtp_dataaquisicao.Enabled = false;
                tb_precoaquisicao.Enabled = false;
                mtb_placa.Enabled = false;
                mtb_hododmetro.Enabled = false;
                mtb_horimetro.Enabled = false;

                
        
        
        }

        private void FormAlterarBens_Load(object sender, EventArgs e)
        {

           
           

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            Bens ben = new Bens();

           
            // carregando inten no componetes
            ben.ID_Bens = int.Parse(tb_id.Text);
            ben.Cod_Controle = mtb_codigoControle.Text;
            ben.Descricao = tb_descricao.Text;
            ben.TipoBens = cb_tipo.Text;
            ben.Data_Aquisicao = dtp_dataaquisicao.Value;
            ben.Preco_Aquisicao= float.Parse(tb_precoaquisicao.Text);
            ben.Placa = mtb_placa.Text;
            ben.Hodometro_incial = int.Parse(mtb_hododmetro.Text);
            ben.Horimetro_incial= int.Parse(mtb_horimetro.Text);

            // alterando bens.
            ben.AlterarBen(int.Parse(tb_id.Text));

            Close();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

            // abilitando alteraçoes no componete .
            mtb_codigoControle.Enabled = true;
            tb_descricao.Enabled = true;
            cb_tipo.Enabled = true;
            dtp_dataaquisicao.Enabled = true;
            tb_precoaquisicao.Enabled = true;
            mtb_placa.Enabled = true;
            mtb_hododmetro.Enabled = true;
            mtb_horimetro.Enabled = true;

            btn_salvar.Visible = true;
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {


            var resultado = MessageBox.Show("Tem Certeza de quer excluir o Registro Selecionado ?", "Excluir Registro", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {

                Bens ben = new Bens();
                ben.DeletarBen(int.Parse(tb_id.Text));
                Close();

            }
            
        }
    }
}
