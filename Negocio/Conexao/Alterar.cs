using BancoDados;
using Objetos;
using System;
using System.Linq;

namespace Negocio.Conexao
{
    public static class Alterar
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
                conexao.Ip = objConexao.Ip;
                conexao.Porta = objConexao.Porta;
                conexao.Senha = objConexao.Senha;
                conexao.Dominio = objConexao.Dominio;
                conexao.Id_Cliente = objConexao.ObjCliente.Id;
                conexao.Id_TipoConexao = objConexao.ObjTipoConexao.Id;
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
