using BancoDados;
using Objetos;
using System;
namespace Negocio.Cliente
{
    public static class Gravar
    {
        static BancoClienteDataContext bancoClienteDataContext;
        static BancoDados.Cliente cliente;
        public static bool Cadastro(ObjCliente objCliente)
        {
            bancoClienteDataContext = new BancoClienteDataContext();
            cliente = new BancoDados.Cliente();
            try
            {
                cliente.Nome = objCliente.Nome;
                bancoClienteDataContext.Clientes.InsertOnSubmit(cliente);
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
