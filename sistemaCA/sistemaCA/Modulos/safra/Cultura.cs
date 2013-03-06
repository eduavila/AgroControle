using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace sistemaCA.views.safra
{
   



    class Cultura
    {

        public DataClasses1DataContext Banco { get; set; }

        public Cultura()
        {
            Banco = new DataClasses1DataContext();
        }


        public void ListarCultura(DataGridView dgw)
        {
            dgw.DataSource = Banco.spListarTipoCultura();
        
        }

        public void Pesquisar(string pesquisa, DataGridView dgw)
        {
            dgw.DataSource = Banco.spPesqiosaTipoCultura(pesquisa);
        
        }
    }
}
