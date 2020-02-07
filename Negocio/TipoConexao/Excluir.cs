using BancoDados;
using Objetos;
using System;
using System.Linq;

namespace Negocio.TipoConexao
{
    public static class Excluir
    {
        static BancoClienteDataContext bancoClienteDataContext;
        static BancoDados.TipoConexao tipoConexao;

        public static bool Cadastro(ObjTipoConexao objTipoConexao)
        {
            bancoClienteDataContext = new BancoClienteDataContext();

            try
            {
                tipoConexao = bancoClienteDataContext.TipoConexaos.First(tpc => tpc.Id == objTipoConexao.Id);
                bancoClienteDataContext.TipoConexaos.DeleteOnSubmit(tipoConexao);
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
