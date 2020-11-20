using System.Web;
using System.Web.Mvc;

namespace NET_Praktika2_Hotels_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
