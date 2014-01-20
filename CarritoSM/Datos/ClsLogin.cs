using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class ClsLogin
    {

        public ClsELogin validarLogueo(string usuario, string contrasena)
        {

            SqlCommand command = null;
            ClsELogin login = new ClsELogin();
            try
            {
                command = ConexionBD.GET_CONEXION().CreateCommand();

                command.CommandText = "CP_sp_sel_validarUsuarios_filter";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();

                command.Parameters.Add(new SqlParameter("@Usuario", usuario));
                command.Parameters.Add(new SqlParameter("@Contrasena", contrasena));
                command.Connection.Open();

                SqlDataReader RESULTADO = ((SqlDataReader)command.ExecuteReader());

                if (RESULTADO.Read())
                {
                    login.Ccontacto = Convert.ToString(RESULTADO["Ccontacto"]);
                    login.Cidcliente = Convert.ToString(RESULTADO["Cidcliente"]);
                    login.cdecliente = Convert.ToString(RESULTADO["cdecliente"]);
                    login.Cnumcedula = Convert.ToString(RESULTADO["Cnumcedula"]);
                    login.Ctelefono = Convert.ToString(RESULTADO["Ctelefono"]);
                    login.Ctelefono2 = Convert.ToString(RESULTADO["Ctelefono2"]);
                    login.Cfax = Convert.ToString(RESULTADO["Cfax"]);
                    login.Cemail = Convert.ToString(RESULTADO["Cemail"]);
                    login.Ccontacto = Convert.ToString(RESULTADO["Ccontacto"]);
                    login.Cusuarioac = Convert.ToString(RESULTADO["Cusuarioac"]);
                    login.Cusuarionu = Convert.ToString(RESULTADO["Cusuarionu"]);
                    login.Cdireccion = Convert.ToString(RESULTADO["Cdireccion"]);
                    login.validacion = Convert.ToString(RESULTADO["validacion"]);
                }

                return login;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open) { }
                command.Connection.Close();
            }
            command.Dispose();

        }


        public Boolean actualizarContrasenaUsuario(string Cidcliente, string usuario, string ContrasenaActual,string ContrasenaNueva)
        {

            SqlCommand command = null;
            //ClsELogin login = new ClsELogin();
            try
            {
                command = ConexionBD.GET_CONEXION().CreateCommand();

                command.CommandText = "CP_sp_upd_actulizarContrasena_filter";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();

                command.Parameters.Add(new SqlParameter("@Cidcliente", Cidcliente));
                command.Parameters.Add(new SqlParameter("@Usuario", usuario));
                command.Parameters.Add(new SqlParameter("@ContrasenaActual", ContrasenaActual));
                command.Parameters.Add(new SqlParameter("@ContrasenaNueva", ContrasenaNueva));
                command.Connection.Open();

                SqlDataReader RESULTADO = ((SqlDataReader)command.ExecuteReader());

                if (RESULTADO.Read())
                {
                    //login.Ccontacto = Convert.ToString(RESULTADO["Ccontacto"]);
                    //login.Cidcliente = Convert.ToString(RESULTADO["Cidcliente"]);
                    //login.cdecliente = Convert.ToString(RESULTADO["cdecliente"]);
                    //login.Cnumcedula = Convert.ToString(RESULTADO["Cnumcedula"]);
                    //login.Ctelefono = Convert.ToString(RESULTADO["Ctelefono"]);
                    //login.Ctelefono2 = Convert.ToString(RESULTADO["Ctelefono2"]);
                    //login.Cfax = Convert.ToString(RESULTADO["Cfax"]);
                    //login.Cemail = Convert.ToString(RESULTADO["Cemail"]);
                    //login.Ccontacto = Convert.ToString(RESULTADO["Ccontacto"]);
                    //login.Cusuarioac = Convert.ToString(RESULTADO["Cusuarioac"]);
                    //login.Cusuarionu = Convert.ToString(RESULTADO["Cusuarionu"]);
                    //login.Cdireccion = Convert.ToString(RESULTADO["Cdireccion"]);
                    //login.validacion = Convert.ToString(RESULTADO["validacion"]);
                   
                }
                return true;
               

            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open) { }
                command.Connection.Close();
            }
            command.Dispose();

        }


    }
}
