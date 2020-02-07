using BancoDados;
using Objetos;
using System;
using System.Linq;

namespace Negocio.Modulo
{
    public static class Excluir
    {
        static BancoClienteDataContext bancoClienteDataContext;
        static BancoDados.Modulo modulo;

        public static bool Cadastro(ObjModulo objModulo)
        {
            bancoClienteDataContext = new BancoClienteDataContext();

            try
            {
                modulo = bancoClienteDataContext.Modulos.First(mod => mod.Id == objModulo.Id);
                modulo.Descricao = objModulo.Descricao;
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
