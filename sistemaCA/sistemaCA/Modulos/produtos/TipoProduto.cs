using System.Windows.Forms;

namespace sistemaCA.views.produtos
{
    class TipoProduto : ClasseBase
    {
        public int Id_tipoproduto { get; set; }
        public string Descricao { get; set; }
        // inciando DataContext na varivel banco
        public TipoProduto() : base(new DataClasses1DataContext())
        { }

        // metodo de pesquisa do tipo de produto 
        public void Pesquisa(string pesquisa, DataGridView dgw)
        {
            dgw.DataSource = this.Banco.spPesquisaTipoproduto(pesquisa);

        }

        public void ListarTipoProduto(DataGridView dgw)
        {
            // listando todos tipo de produtos no grid view 
            dgw.DataSource = this.Banco.spListatipoProduto();

        }




    }
}
