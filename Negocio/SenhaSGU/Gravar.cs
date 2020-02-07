using BancoDados;
using Objetos;
using System;

namespace Negocio.SenhaSGU
{
    public static class Gravar
    {
        static BancoClienteDataContext bancoClienteDataContext;
        static BancoDados.SenhaSGU senhaSGU;

        public static bool Cadastro(ObjSenhaSGU objSenhaSGU)
        {
            bancoClienteDataContext = new BancoClienteDataContext();
            senhaSGU = new BancoDados.SenhaSGU();
            try
            {
                senhaSGU.Usuario = objSenhaSGU.Usuario;
                senhaSGU.Senha = objSenhaSGU.Senha;
                senhaSGU.Id_Cliente = objSenhaSGU.ObjCliente.Id;
                senhaSGU.Id_Modulo = objSenhaSGU.ObjModulo.Id;
                bancoClienteDataContext.SenhaSGUs.InsertOnSubmit(senhaSGU);
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
