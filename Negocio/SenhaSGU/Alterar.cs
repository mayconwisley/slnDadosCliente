using BancoDados;
using Objetos;
using System;
using System.Linq;

namespace Negocio.SenhaSGU
{
    public static class Alterar
    {
        static BancoClienteDataContext bancoClienteDataContext;
        static BancoDados.SenhaSGU senhaSGU;

        public static bool Cadastro(ObjSenhaSGU objSenhaSGU)
        {
            bancoClienteDataContext = new BancoClienteDataContext();

            try
            {
                senhaSGU = bancoClienteDataContext.SenhaSGUs.First(ssgu => ssgu.Id == objSenhaSGU.Id);
                senhaSGU.Usuario = objSenhaSGU.Usuario;
                senhaSGU.Senha = objSenhaSGU.Senha;
                senhaSGU.Id_Cliente = objSenhaSGU.ObjCliente.Id;
                senhaSGU.Id_Modulo = objSenhaSGU.ObjModulo.Id;
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
