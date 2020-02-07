namespace Objetos
{
    public class ObjConexao
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public string Porta { get; set; }
        public string Senha { get; set; }
        public string Dominio { get; set; }
        public ObjCliente ObjCliente { get; set; }
        public ObjTipoConexao ObjTipoConexao { get; set; }
    }
}
