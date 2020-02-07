using BancoDados;
using System;
using System.Linq;
namespace Negocio.Cliente
{
    public static class Listar
    {
        static BancoClienteDataContext bancoClienteDataContext;

        public static Object Cadastro()
        {
            bancoClienteDataContext = new BancoClienteDataContext();
            try
            {
                var varLista = (from lista in bancoClienteDataContext.Clientes.AsEnumerable()
                                select new
                                {
                                    lista.Id,
                                    lista.Nome
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
