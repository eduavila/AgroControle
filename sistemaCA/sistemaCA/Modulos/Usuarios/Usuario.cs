namespace sistemaCA.Modulos.Usuarios
{
    public class Usuario
    {
        public DataClasses1DataContext Banco { get; set; }
        public tblusuario Tblusuario { get; set; }

        public int IDAcesso { get; set; }
        public int IDUsuario { get; set; }
        public int ModAplicacao { get; set; }
        public int ModRevisao { get; set; }
        public int MdAdmin { get; set; }
    }
}
