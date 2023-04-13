using System.Text;
using System.Text.Json;
using AutoMapper;
using Newtonsoft.Json.Serialization;
using Vanora.Entities;

namespace Vanora.GeoDb
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<TestCountry, CmsCountry>()
                // .ForMember(dest => dest.Texts.FirstOrDefault(), opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Iso3, opt => opt.MapFrom(src => src.Iso3))
                .ForMember(dest => dest.Iso2, opt => opt.MapFrom(src => src.Iso2))
                .ForMember(dest => dest.NumericCode, opt => opt.MapFrom(src => src.NumericCode))
                .ForMember(dest => dest.PhoneCode, opt => opt.MapFrom(src => src.PhoneCode))
                .ForMember(dest => dest.Capital, opt => opt.MapFrom(src => src.Capital))
                .ForMember(dest => dest.Currency, opt => opt.MapFrom(src => src.Currency))
                .ForMember(dest => dest.CurrencyName, opt => opt.MapFrom(src => src.CurrencyName))
                .ForMember(dest => dest.CurrencySymbol, opt => opt.MapFrom(src => src.CurrencySymbol))
                .ForMember(dest => dest.TopLevelDomain, opt => opt.MapFrom(src => src.Tld))
                .ForMember(dest => dest.Native, opt => opt.MapFrom(src => src.Native))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(src => src.Region))
                .ForMember(dest => dest.Subregion, opt => opt.MapFrom(src => src.Subregion))
                .ForMember(dest => dest.Latitude, opt => opt.MapFrom(src => src.Latitude))
                .ForMember(dest => dest.Longitude, opt => opt.MapFrom(src => src.Longitude))
                .ForMember(dest => dest.Emoji, opt => opt.MapFrom(src => src.Emoji));
                // .ForMember(dest => dest.Timezones, opt => opt.MapFrom(src => src.Timezones))
                // .ForMember(dest => dest.Texts, opt => opt.MapFrom(src => src.Translations))
                // .ForMember(dest => dest.Cities, opt => opt.MapFrom(src => src.States));

            // CreateMap<City, CmsCity>()
            //     .ForMember(dest => dest.Texts.FirstOrDefault(), opt => opt.MapFrom(src => src.Name))
            //     .ForMember(dest => dest.StateCode, opt => opt.MapFrom(src => src.StateCode))
            //     .ForMember(dest => dest.Latitude, opt => opt.MapFrom(src => src.Latitude))
            //     .ForMember(dest => dest.Longitude, opt => opt.MapFrom(src => src.Longitude))
            //     .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
            //     .ForMember(dest => dest.Counties, opt => opt.MapFrom(src => src.Cities));

            // CreateMap<County, CmsCounty>()
            //     .ForMember(dest => dest.Texts.FirstOrDefault(), opt => opt.MapFrom(src => src.Name))
            //     .ForMember(dest => dest.Latitude, opt => opt.MapFrom(src => src.Latitude))
            //     .ForMember(dest => dest.Longitude, opt => opt.MapFrom(src => src.Longitude));

            // CreateMap<Timezone, CmsCountryTimezone>()
            //     .ForMember(dest => dest.ZoneName, opt => opt.MapFrom(src => src.ZoneName))
            //     .ForMember(dest => dest.GmtOffset, opt => opt.MapFrom(src => src.GmtOffset))
            //     .ForMember(dest => dest.GmtOffsetName, opt => opt.MapFrom(src => src.GmtOffsetName))
            //     .ForMember(dest => dest.Abbreviation, opt => opt.MapFrom(src => src.Abbreviation))
            //     .ForMember(dest => dest.TimezoneName, opt => opt.MapFrom(src => src.TzName));

            // CreateMap<Translations, CmsCountryText>()
            //     .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.De))
            //     .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Es))
            //     .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Fr))
            //     .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.It))
            //     .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Tr));

        }        
    }
}