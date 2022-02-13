using System.Web;
using System.Web.Mvc;

namespace N01522297_Assignment2_JoshColvin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
