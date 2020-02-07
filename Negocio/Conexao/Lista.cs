using BancoDados;
using System;
using System.Linq;

namespace Negocio.Conexao
{
    public static class Lista
    {
        static BancoClienteDataContext bancoClienteDataContext;
        public static Object Consulta(int idCliente)
        {
            bancoClienteDataContext = new BancoClienteDataContext();
            try
            {
                var varLista = (from listCon in bancoClienteDataContext.Conexaos.AsEnumerable()
                                join listCli in bancoClienteDataContext.Clientes.AsEnumerable()
                                on listCon.Id_Cliente equals listCli.Id
                                join listTCon in bancoClienteDataContext.TipoConexaos.AsEnumerable()
                                on listCon.Id_TipoConexao equals listTCon.Id
                                where listCon.Id_Cliente == idCliente
                                select new
                                {
                                    listCon.Ip,
                                    listCon.Porta,
                                    listCon.Senha,
                                    listCon.Dominio
                                }).ToList();
                return varLista;
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
