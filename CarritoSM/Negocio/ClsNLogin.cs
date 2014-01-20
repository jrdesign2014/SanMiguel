using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocio
{
    public class ClsNLogin
    {

        ClsLogin datosLogin = new ClsLogin();
        public ClsELogin LoginLN(String usuario, String contrasena)
        {
            
            try
            {
                return datosLogin.validarLogueo(usuario, contrasena);
            }

            catch (Exception ex)
            {

                throw (ex);
            }

        }

        public Boolean ActualizarContrasenaLN(string Cidcliente, string usuario, string ContrasenaActual, string ContrasenaNueva)
        {

            try
            {
                return datosLogin.actualizarContrasenaUsuario( Cidcliente,  usuario,  ContrasenaActual, ContrasenaNueva);
            }

            catch (Exception ex)
            {

                throw (ex);
            }

        }
    }
}
