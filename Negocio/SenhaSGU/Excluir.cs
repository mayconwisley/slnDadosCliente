using BancoDados;
using Objetos;
using System;
using System.Linq;

namespace Negocio.SenhaSGU
{
    public static class Excluir
    {
        static BancoClienteDataContext bancoClienteDataContext;
        static BancoDados.SenhaSGU senhaSGU;

        public static bool Cadastro(ObjSenhaSGU objSenhaSGU)
        {
            bancoClienteDataContext = new BancoClienteDataContext();

            try
            {
                senhaSGU = bancoClienteDataContext.SenhaSGUs.First(ssgu => ssgu.Id == objSenhaSGU.Id);
                bancoClienteDataContext.SenhaSGUs.DeleteOnSubmit(senhaSGU);
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
