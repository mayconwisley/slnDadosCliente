using BancoDados;
using Objetos;
using System;
namespace Negocio.Modulo
{
    public static class Gravar
    {
        static BancoClienteDataContext bancoClienteDataContext;
        static BancoDados.Modulo modulo;

        public static bool Cadastro(ObjModulo objModulo)
        {
            bancoClienteDataContext = new BancoClienteDataContext();
            modulo = new BancoDados.Modulo();
            try
            {
                modulo.Descricao = objModulo.Descricao;
                bancoClienteDataContext.Modulos.InsertOnSubmit(modulo);
                bancoClienteDataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                bancoClienteDataContext.Dispose();
            }
        }
    }
}
