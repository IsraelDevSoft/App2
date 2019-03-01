using System.Web;
using System.Web.Mvc;

namespace CarcenterWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //Habilitar el filtro de sesion para cada submit en la aplicacion
            filters.Add(new Filters.VerificarSesion());
        }
    }
}
