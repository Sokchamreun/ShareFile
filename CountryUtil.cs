using System.Globalization;

namespace SlashX.Net
{
    public class CountryDto
    {
        public int GeoId { get; set; }
        public int Lcid { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string CultureName { get; set; }
        public string DisplayName { get; set; }
        public string TwoLetterISORegionName { get; set; }
        public string ThreeLetterISORegionName { get; set; }
        public string ISOCurrencySymbol { get; set; }
        public string CurrencyEnglishName { get; set; }
        public string NativeName { get; set; }
        public string CurrencySymbol { get; set; }
        public string LanguageId { get; set; }
        public override string ToString()
        {
            return string.Join(", ", ThreeLetterISORegionName, NameEn);
        }
    }

    public class CountryUtil
    {
        private static CountryDto GetCountry(CultureInfo culture, RegionInfo region)
        {
            return new CountryDto
            {
                Code = region.EnglishName == "Cambodia" ? "855" : null,
                GeoId = region.GeoId,
                DisplayName = region.DisplayName,
                NameEn = region.EnglishName,
                CurrencyEnglishName = region.CurrencyEnglishName,
                ISOCurrencySymbol = region.ISOCurrencySymbol,
                ThreeLetterISORegionName = region.ThreeLetterISORegionName,
                TwoLetterISORegionName = region.TwoLetterISORegionName,
                Lcid = culture.LCID,
                LanguageId = string.Format("0x{0}", culture.LCID.ToString("X4")),
                NativeName = culture.NativeName,
                CurrencySymbol = region.CurrencySymbol,
                CultureName = culture.Name
            };
        }

        public static IList<CountryDto> Get()
        {
            var list = new List<CountryDto>();
            var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.NeutralCultures);
            foreach (var culture in cultures)
            {
                var regionInfo = new RegionInfo(culture.Name);
                if (list.FirstOrDefault(t=> t.NameEn == regionInfo.EnglishName) == null
                    && !string.IsNullOrEmpty(regionInfo.ThreeLetterISORegionName) && culture.LCID != 127 
                    && (culture.CultureTypes & CultureTypes.NeutralCultures) != CultureTypes.NeutralCultures)
                {
                    list.Add(GetCountry(culture, regionInfo));
                }
            }

            return list.OrderBy(o => o.NameEn).ToList();
        }
    }
}
