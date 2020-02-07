namespace Objetos
{
    public class ObjSenhaSGU
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public ObjCliente ObjCliente { get; set; }
        public ObjModulo ObjModulo { get; set; }
    }
}
