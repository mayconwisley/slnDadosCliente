using BancoDados;
using System;
using System.Linq;
namespace Negocio.SenhaSGU
{
    public static class Listar
    {
        static BancoClienteDataContext bancoClienteDataContext;
        public static Object Cadastro()
        {
            bancoClienteDataContext = new BancoClienteDataContext();
            try
            {
                var varLista = (from listSenha in bancoClienteDataContext.SenhaSGUs.AsEnumerable()
                                join listaCli in bancoClienteDataContext.Clientes.AsEnumerable() on listSenha.Id_Cliente equals listaCli.Id
                                select new
                                {
                                    listSenha.Id,
                                    listSenha.Usuario,
                                    listSenha.Senha
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
