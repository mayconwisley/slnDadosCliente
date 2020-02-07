using BancoDados;
using System;
using System.Linq;
namespace Negocio.Modulo
{
    public static class Listar
    {
        static BancoClienteDataContext bancoClienteDataContext;

        public static Object Cadastro()
        {
            bancoClienteDataContext = new BancoClienteDataContext();

            try
            {
                var varLista = (from lista in bancoClienteDataContext.Modulos.AsEnumerable()
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
