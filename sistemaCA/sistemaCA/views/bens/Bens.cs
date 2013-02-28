using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace sistemaCA.views.bens
{
    class Bens
    {
        public DataClasses1DataContext Banco { get; set; }
        //public tblben Bens { get; set; }
        //propriedade do bens

        public int ID_Bens { get; set;}
        public string Descricao { get; set; }
        public string TipoBens { get; set; }
        public string Cod_Controle { get; set; }
        public DateTime Data_Aquisicao { get; set; }
        public Double Preco_Aquisicao { get; set; }
        public int Horimetro_incial { get; set; }
        public int Hodometro_incial { get; set; }


        public Bens()
        {
            Banco = new DataClasses1DataContext();
            
        
        }

        public void VisualizarBens(DataGridView dgw)
        {
            try
            {

                var pesqui = from Ben in Banco.tblbens select Ben;

                dgw.DataSource = pesqui;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


    }
}
