using System.Globalization;

namespace Multilingual.Helpers
{
    public static class CultureHelper
    {
        public static bool IsArabic()
        {
            bool isArabic = false;
            var currentCulture = CultureInfo.CurrentUICulture.Name;
            if (currentCulture == "ar")
            {
                isArabic = true;
            }
            return isArabic;
        }
    }
}
