using BancoDados;
using System;
using System.Linq;
namespace Negocio.TipoConexao
{
    public static class Listar
    {
        static BancoClienteDataContext bancoClienteDataContext;
        public static Object Cadastro()
        {
            try
            {
                var varLista = (from lista in bancoClienteDataContext.TipoConexaos.AsEnumerable()
                                select new
                                {
                                    lista.Id,
                                    lista.Descricao
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
