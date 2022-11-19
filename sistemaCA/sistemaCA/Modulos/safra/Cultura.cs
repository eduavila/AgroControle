using System.Windows.Forms;

namespace sistemaCA.views.safra
{

    class Cultura : ClasseBase
    {

        public Cultura() : base(new DataClasses1DataContext())
        {

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
