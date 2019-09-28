using sys_bodega.Filters;
using System.Web;
using System.Web.Mvc;

namespace sys_bodega
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new FiltroSessiom());
        }
    }
}
