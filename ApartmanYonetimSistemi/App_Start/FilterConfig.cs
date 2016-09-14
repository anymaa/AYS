using ApartmanYonetimSistemi.Infrastructure;

namespace ApartmanYonetimSistemi
{
    public class FilterConfig
    {
        public static void Configure(System.Web.Mvc.GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
