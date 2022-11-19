namespace sistemaCA
{
    public abstract class ClasseBase
    {
        public ClasseBase(DataClasses1DataContext banco)
        {
            Banco = banco;
        }

        public DataClasses1DataContext Banco { get; set; }
    }
}
