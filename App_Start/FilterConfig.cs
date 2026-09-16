using System.Web;
using System.Web.Mvc;

namespace nguyenngocthang_25dh110213
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
