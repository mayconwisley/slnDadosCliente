using BancoDados;
using Objetos;
using System;
using System.Linq;

namespace Negocio.ModCli
{
    public static class Alterar
    {
        static BancoClienteDataContext bancoClienteDataContext;
        static BancoDados.ModCli modCli;

        public static bool Cadastrar(ObjModCli objModCli)
        {
            bancoClienteDataContext = new BancoClienteDataContext();
            try
            {
                modCli = bancoClienteDataContext.ModClis.First(mcl => mcl.Id == objModCli.Id);
                modCli.Id_Cliente = objModCli.ObjCliente.Id;
                modCli.Id_Modulo = objModCli.ObjModulo.Id;
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
