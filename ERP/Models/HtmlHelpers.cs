using Microsoft.AspNetCore.Mvc.Rendering;

namespace ERP.Models
{
    public static class HtmlHelpers
    {
        public static string DisplayRoute(this IHtmlHelper htmlHelper, int? isRoute)
        {
            return isRoute switch
            {
                0 => "Hayır",
                1 => "Evet",
                2 => "Olmayacak"
            };
        }
        public static string DisplayBom(this IHtmlHelper htmlHelper, int? isBom)
        {
            return isBom switch
            {
                0 => "Hayır",
                1 => "Evet",
                2 => "Olmayacak"
            };
        }
        public static string DisplayPassive(this IHtmlHelper htmlHelper, int? isPassive)
        {
            return isPassive == 1 ? "Evet" : "Hayır";
        }
        public static string DisplayDelete(this IHtmlHelper htmlHelper, int? isDeleted)
        {
            return isDeleted == 1 ? "Evet" : "Hayır";
        }

        public static string DisplaySupply(this IHtmlHelper htmlHelper, int? supplyType)
        {
            return supplyType == 1 ? "Üretilen" : "Satın Alınan";
        }
        public static string DisplayMainUnit(this IHtmlHelper htmlHelper, int? isMainUnit)
        {
            return isMainUnit == 1 ? "Evet" : "Hayır";
        }
    }
}
