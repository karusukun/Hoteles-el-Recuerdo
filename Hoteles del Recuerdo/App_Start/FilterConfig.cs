using System.Web;
using System.Web.Mvc;

namespace Hoteles_del_Recuerdo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
