﻿using System;
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
    public partial class Formbens : Form
    {
        public Formbens()
        {
            InitializeComponent();
        }

        private void Formbens_Load(object sender, EventArgs e)
        {
            Bens ben = new Bens();
            ben.VisualizarBens(dgw_bens);


            dgw_bens.Columns["id_ben"].HeaderText = "ID";
            dgw_bens.Columns["descricao"].HeaderText = "Descrição";
            dgw_bens.Columns["tipoben"].HeaderText = "Tipo";
            dgw_bens.Columns["codigoControle"].HeaderText = "Código Controle";
            dgw_bens.Columns["data_aquisicao"].HeaderText = "Data Aquisição";
            dgw_bens.Columns["preco_aquisicao"].HeaderText = "Preço Aquisição";
            dgw_bens.Columns["horimetro_inicial"].HeaderText = "Horimetro(KM)";
            dgw_bens.Columns["Hodometro_inicial"].HeaderText = "Horimetro(Horas)";
            dgw_bens.Columns["placa"].HeaderText = "Placa";




            // barra de rodape
            toolStripStatusLabel1.Text = dgw_bens.RowCount + " Máquinas Cadastrada.";
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            FormCadastraBen formben = new FormCadastraBen();
            formben.ShowDialog();

           
            // atualiza data grid depois que cadastra
            Bens ben = new Bens();
            ben.VisualizarBens(dgw_bens);


        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            if (dgw_bens.CurrentCell != null)
            {
                int selecionado = dgw_bens.CurrentCell.RowIndex;

                int idbens;

                idbens = int.Parse(dgw_bens.Rows[selecionado].Cells["id_ben"].Value.ToString());


                // instanciando formulario alterar
                FormAlterarBens formaltera = new FormAlterarBens(idbens);
                formaltera.ShowDialog();

                // atualizando data grid 
                Bens ben = new Bens();
                ben.VisualizarBens(dgw_bens);
            }
        }
    }
}
