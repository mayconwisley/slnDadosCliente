using BancoDados;
using Objetos;
using System;
namespace Negocio.ModCli
{
    public static class Gravar
    {
        static BancoClienteDataContext bancoClienteDataContext;
        static BancoDados.ModCli modCli;

        public static bool Cadastrar(ObjModCli objModCli)
        {
            bancoClienteDataContext = new BancoClienteDataContext();
            modCli = new BancoDados.ModCli();
            try
            {
                modCli.Id_Cliente = objModCli.ObjCliente.Id;
                modCli.Id_Modulo = objModCli.ObjModulo.Id;
                bancoClienteDataContext.ModClis.InsertOnSubmit(modCli);
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
