﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaCA.Modulos.aplicacao;
using sistemaCA.views;
using sistemaCA.views.Pesquisa;

namespace sistemaCA.views.aplicacao
{
    public partial class FormCadastraAplicacao : Form
    {
        public FormCadastraAplicacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPesquisa pesq = new FormPesquisa();
            pesq.ShowDialog();
            tb_idFunc.Text = pesq.ID.ToString();
              
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormPesquisaIDtalhao pesqui = new FormPesquisaIDtalhao();
            pesqui.ShowDialog();
            tb_talhao.Text = pesqui.ID.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPesquisaMaquinas pesqui = new FormPesquisaMaquinas();
            pesqui.ShowDialog();
            tb_maquinas.Text = pesqui.ID.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPesquisaSafra pesqui = new FormPesquisaSafra();
            pesqui.ShowDialog();
            tb_safra.Text = pesqui.ID.ToString();
        }

        private void FormCadastraAplicacao_Load(object sender, EventArgs e)
        {
            tb_status.Enabled = false;
            tb_status.Text = "Aberto";


            // listando descricao produto no comobox 

            ProdutoAplicado produto = new ProdutoAplicado();


            produto.ListandoProduto(dgw_produto);

            dgw_produto.Columns["Produto"].DisplayIndex = 0;
            dgw_produto.Columns["quantidade"].DisplayIndex = 1;
            dgw_produto.Columns["valor"].DisplayIndex = 2;
          

            

            

            
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
           
               // cadastrando aplicaçao
            Aplicacao aplicacao = new Aplicacao();

            aplicacao.Status = tb_status.Text;
            aplicacao.Descricao = tb_descricao.Text;
            aplicacao.DataAplicacao = dtp_aplicacao.Value;
            aplicacao.DataCadastro = DateTime.Today.Date;
            if (tb_areaplicada.Text == " ")
            {
                aplicacao.AreaAplicada = float.Parse(tb_areaplicada.Text);
            }
            aplicacao.ID_Ben =int.Parse(tb_maquinas.Text);
            aplicacao.ID_Funcionario = int.Parse(tb_idFunc.Text);
            aplicacao.ID_talhao = int.Parse(tb_talhao.Text);
            aplicacao.ID_Safra = int.Parse(tb_safra.Text);
            aplicacao.Obs = tb_obs.Text;
            aplicacao.TipoAplicao = cb_tipoaplicacao.Text;


            // cadastra aplicacao
            aplicacao.CadastraAplicacao();
           
            // fim cadastro aplicaçao
            ProdutoAplicado produto = new ProdutoAplicado();

            produto.CadastraProdutoAplicado(dgw_produto);

            MessageBox.Show("Registro Cadastrado com Sucesso!");

            Close();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgw_produto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtp_aplicacao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgw_produto_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
