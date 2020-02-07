using BancoDados;
using Objetos;
using System;
namespace Negocio.Conexao
{
    public static class Gravar
    {
        static BancoClienteDataContext bancoClienteDataContext;
        static BancoDados.Conexao conexao;

        public static bool Cadastro(ObjConexao objConexao)
        {
            bancoClienteDataContext = new BancoClienteDataContext();
            conexao = new BancoDados.Conexao();
            try
            {
                conexao.Ip = objConexao.Ip;
                conexao.Porta = objConexao.Porta;
                conexao.Senha = objConexao.Senha;
                conexao.Dominio = objConexao.Dominio;
                conexao.Id_Cliente = objConexao.ObjCliente.Id;
                conexao.Id_TipoConexao = objConexao.ObjTipoConexao.Id;

                bancoClienteDataContext.Conexaos.InsertOnSubmit(conexao);
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
