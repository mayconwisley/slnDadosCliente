using BancoDados;
using Objetos;
using System;
using System.Linq;

namespace Negocio.ModCli
{
    public static class Excluir
    {
        static BancoClienteDataContext bancoClienteDataContext;
        static BancoDados.ModCli modCli;

        public static bool Cadastrar(ObjModCli objModCli)
        {
            bancoClienteDataContext = new BancoClienteDataContext();
            try
            {
                modCli = bancoClienteDataContext.ModClis.First(mcl => mcl.Id == objModCli.Id);
                bancoClienteDataContext.ModClis.DeleteOnSubmit(modCli);
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
