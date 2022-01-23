using System.Web;
using System.Web.Mvc;

namespace WebAPI_For_Curd_Employee
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
