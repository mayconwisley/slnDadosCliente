using BancoDados;
using Objetos;
using System;
using System.Linq;

namespace Negocio.Cliente
{
    public static class Alterar
    {
        static BancoClienteDataContext bancoClienteDataContext;
        static BancoDados.Cliente cliente;
        public static bool Cadastro(ObjCliente objCliente)
        {
            bancoClienteDataContext = new BancoClienteDataContext();
            try
            {
                cliente = bancoClienteDataContext.Clientes.First(cli => cli.Id == objCliente.Id);
                cliente.Nome = objCliente.Nome;
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
