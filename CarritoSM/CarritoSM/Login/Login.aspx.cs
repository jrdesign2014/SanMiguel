using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using Entidades;
using Negocio;

namespace CarritoSM
{
    public partial class Login : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public void validarUsuarios()
        {
            string cusuario=TxtUsuario.Text.ToString();
            string ccontrasena=TxtContrasena.Text.ToString();

            ClsELogin logueo = new ClsNLogin().LoginLN(cusuario, ccontrasena);
            Session["Cliente"] = logueo;

            if (logueo.validacion.Equals("S"))
            {
                Response.Write("<script>alert('Usuario valido')</script>");

                if (logueo.Cusuarioac.Equals("S"))
                {
                    Response.Write("<script>alert('Usuario activo')</script>");

                    if(logueo.Cusuarionu.Equals("S")){

                        //ActualizarContasena(logueo.Cidcliente, cusuario, ccontrasena,"rsds");
                        ClientScript.RegisterStartupScript(this.GetType(), "fnAceptar", "<script> fnAceptar(); </script>");

                        //Response.Write("<script>alert('Usuario nuevo cambiar contrasena')</script>");
                        
                    }else{

                        Response.Write("<script>alert('Usuario viejo')</script>");
                    }

                }
                else {

                    Response.Write("<script>alert('Usuario inactivo')</script>");
                
                }


            }
            else
            {
                Response.Write("<script>alert('Usuario invalido')</script>");

            }

        }

        public void ActualizarContasena(string Cidcliente, string usuario, string ContrasenaActual, string ContrasenaNueva) 
        {

            Boolean result = new ClsNLogin().ActualizarContrasenaLN(Cidcliente, usuario, ContrasenaActual, ContrasenaNueva);
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            validarUsuarios();
        }

    }
}