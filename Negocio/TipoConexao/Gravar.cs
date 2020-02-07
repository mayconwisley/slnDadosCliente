using BancoDados;
using Objetos;
using System;

namespace Negocio.TipoConexao
{
    public static class Gravar
    {
        static BancoClienteDataContext bancoClienteDataContext;
        static BancoDados.TipoConexao tipoConexao;

        public static bool Cadastro(ObjTipoConexao objTipoConexao)
        {
            bancoClienteDataContext = new BancoClienteDataContext();
            tipoConexao = new BancoDados.TipoConexao();
            try
            {
                tipoConexao.Descricao = objTipoConexao.Descricao;
                bancoClienteDataContext.TipoConexaos.InsertOnSubmit(tipoConexao);
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
