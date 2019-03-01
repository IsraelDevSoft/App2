using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarcenterWeb.Models;
using CarcenterWeb.Controllers;
using System.Web.Mvc;

namespace CarcenterWeb.Filters
{
    public class VerificarSesion : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //obtener de la sesion los datos de la persona logueda
            var opersona = (PERSONAS)HttpContext.Current.Session["User"];
            //si la sesion no exite o no se ha iniciado sesion...
            if(opersona == null)
            {
                //si la peticion viene de un controlador diferente a accesocontroller, regresamos
                //al usuario a la pantalla del login
                if(filterContext.Controller is AccesoController == false)
                {
                    filterContext.HttpContext.Response.Redirect("~/Acceso/Index");
                }
            }
            base.OnActionExecuting(filterContext);
        }
    }
}