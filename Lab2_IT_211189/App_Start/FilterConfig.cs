using System.Web;
using System.Web.Mvc;

namespace Lab2_IT_211189
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
