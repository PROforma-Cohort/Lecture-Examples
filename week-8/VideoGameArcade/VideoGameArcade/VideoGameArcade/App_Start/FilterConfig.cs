using System.Web;
using System.Web.Mvc;

namespace VideoGameArcade
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            var x = new int[] { 1, 2, 3, 4, 5 };

            filters.Add(new HandleErrorAttribute());
        }
    }
}
