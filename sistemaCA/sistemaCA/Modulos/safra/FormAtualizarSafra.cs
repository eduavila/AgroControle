﻿using System;
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
            dtp_final.Visible = false;
            lb_datafin.Visible = false;

            Safra safra = new Safra();
            safra.VisualizarSafra(id_safra);
            

            tb_idsafra.Text = safra.IdSafra.ToString() ;
            tb_descricao.Text = safra.Descricao;
            tb_status.Text = safra.status;
            if (safra.status == "Fechada")
            {
                dtp_final.Visible = true;
                lb_datafin.Visible = true;
                dtp_final.Value = safra.DataFechamento;
                
            }

            tb_tipocultura.Text = safra.IdCultura.ToString();
            dt_datainicio.Value =DateTime.Parse(safra.DataInicio.ToString());

           
            
            tb_obs.Text = safra.Obs;

            
            btn_salvar.Visible = false;
            tb_idsafra.Enabled = false;
            tb_descricao.Enabled = false;
            tb_status.Enabled = false;
            dt_datainicio.Enabled = false;
            dtp_final.Enabled = false;
            tb_obs.Enabled = false;
            tb_tipocultura.Enabled = false;
            btn_pesquisar.Enabled = false;
        
        
        }

        private void FormAtualizarSafra_Load(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            // abilitando componete para alteraçoes do dados .
            btn_salvar.Visible = true;
            tb_descricao.Enabled = true;
            tb_status.Enabled = true;
            dt_datainicio.Enabled = true;
            
            tb_obs.Enabled = true;
           
            btn_pesquisar.Enabled = true;

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            // salvando alterações de safra
            try
            {
                Safra safra = new Safra();


                safra.IdSafra = int.Parse(tb_idsafra.Text);
                safra.Descricao = tb_descricao.Text;
                safra.IdCultura =int.Parse(tb_tipocultura.Text);
                safra.status = tb_status.Text;
                safra.DataInicio = dt_datainicio.Value;
               
                safra.Obs = tb_obs.Text;

                // somente vai salvar valor data picke se o componete 
                if (dtp_final.Visible == true)
                {
                    safra.DataFechamento = dtp_final.Value;
                }
                if (dtp_final.Visible == false)
                {
                    safra.DataFechamento =DateTime.Parse("0000-00-00");
                }
                safra.AtualizarSafra();
                MessageBox.Show("Alterado com sucesso!");

                Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                
            }

        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            // deletando safra refente ao id clicado.
            var msg = MessageBox.Show("Tem certeza que deseja deletar o registo? ", "Deletar registro",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {

                Safra safra = new Safra();
                safra.DeletarSafra(int.Parse(tb_idsafra.Text));

                MessageBox.Show("Registro excluido com sucesso!");
                Close();

            }
            else
            {
                Close();
                    
            }

        }

        private void btn_fsafra_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTipoCultura FormTipo = new FormTipoCultura();
            FormTipo.ShowDialog();
            tb_tipocultura.Text = FormTipo.Id_cultura.ToString();
        }

        private void tb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tb_status.Text == "Fechada")
            {
                lb_datafin.Visible = true;
                dtp_final.Visible = true;
                dtp_final.Enabled = true;
            }
            if (tb_status.Text == "Aberta")
            {
                lb_datafin.Visible = false;
                dtp_final.Visible = false;
                dtp_final.Enabled = false;
            }
        }
    }
}
