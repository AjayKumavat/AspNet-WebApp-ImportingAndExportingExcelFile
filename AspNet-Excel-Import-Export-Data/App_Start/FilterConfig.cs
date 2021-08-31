using System.Web;
using System.Web.Mvc;

namespace AspNet_Excel_Import_Export_Data
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
