using BancoDados;
using Objetos;
using System;
using System.Linq;

namespace Negocio.Conexao
{
    public static class Excluir
    {
        static BancoClienteDataContext bancoClienteDataContext;
        static BancoDados.Conexao conexao;

        public static bool Cadastro(ObjConexao objConexao)
        {
            bancoClienteDataContext = new BancoClienteDataContext();
            conexao = new BancoDados.Conexao();
            try
            {
                conexao = bancoClienteDataContext.Conexaos.First(con => con.Id == objConexao.Id);
                bancoClienteDataContext.Conexaos.DeleteOnSubmit(conexao);
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
