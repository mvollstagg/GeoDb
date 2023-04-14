using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Vanora.Entities;

namespace Vanora.GeoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class GeoApiController : ControllerBase
{
    private readonly ILogger<GeoApiController> _logger;

    public GeoApiController(ILogger<GeoApiController> logger)
    {
        _logger = logger;
    }

    [HttpGet()]
    public JsonResult Get()
    {
        try
        {
            List<TestCountry> countries = new List<TestCountry> { };

            using (WebClient client = new WebClient())
            {
                using (StreamReader sr = new StreamReader(client.OpenRead("https://raw.githubusercontent.com/mvollstagg/GeoDb/main/Vanora.GeoApi/countries%2Bstates%2Bcities.json")))
                {
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        countries = JsonSerializer.CreateDefault().Deserialize<List<TestCountry>>(reader);
                    }
                }
            }

            var turkey = countries.Where(x => x.Iso2 == "TR").FirstOrDefault();

            List<CmsCountry> _cmsCountries = new List<CmsCountry> { };
            int counter = 1;
            foreach (var country in countries)
            {
                _cmsCountries.Add(new CmsCountry
                {
                    Active = true,
                    DisplayOrder = counter++,
                    Iso3 = country.Iso3,
                    Iso2 = country.Iso2,
                    NumericCode = country.NumericCode,
                    PhoneCode = country.PhoneCode,
                    Capital = country.Capital,
                    Currency = country.Currency,
                    CurrencyName = country.CurrencyName,
                    CurrencySymbol = country.CurrencySymbol,
                    TopLevelDomain = country.Tld,
                    Native = country.Native,
                    Region = country.Region,
                    Subregion = country.Subregion,
                    Latitude = country.Latitude,
                    Longitude = country.Longitude,
                    Emoji = country.Emoji,
                    Deleted = false,
                    Timezones = country.Timezones.Select(p => new CmsCountryTimezone
                                                        {
                                                            ZoneName = p.ZoneName,
                                                            GmtOffset = p.GmtOffset,
                                                            GmtOffsetName = p.GmtOffsetName,
                                                            Abbreviation = p.Abbreviation,
                                                            TimezoneName = p.TzName
                                                        }).ToList(),
                    Texts = new List<CmsCountryText>
                    {
                        new CmsCountryText
                        {
                            CmsLanguageId = 1,
                            Name = country.Translations.Tr
                        },
                        new CmsCountryText
                        {
                            CmsLanguageId = 2,
                            Name = country.Name
                        },
                        new CmsCountryText
                        {
                            CmsLanguageId = 3,
                            Name = country.Translations.De
                        },
                        new CmsCountryText
                        {
                            CmsLanguageId = 4,
                            Name = country.Translations.Es
                        },
                        new CmsCountryText
                        {
                            CmsLanguageId = 5,
                            Name = country.Translations.Fr
                        },
                        new CmsCountryText
                        {
                            CmsLanguageId = 6,
                            Name = country.Translations.It
                        },
                    },
                    Cities = country.States.Select(p => new CmsCity
                            {
                                Active = true,
                                StateCode = p.StateCode,
                                Latitude = p.Latitude,
                                Longitude = p.Longitude,
                                Type = p.Type,
                                Deleted = false,                                
                                Texts = new List<CmsCityText>
                                {
                                    new CmsCityText
                                    {
                                        CmsLanguageId = 1,
                                        Name = p.Name
                                    },
                                    new CmsCityText
                                    {
                                        CmsLanguageId = 2,
                                        Name = p.Name
                                    },
                                    new CmsCityText
                                    {
                                        CmsLanguageId = 3,
                                        Name = p.Name
                                    },
                                    new CmsCityText
                                    {
                                        CmsLanguageId = 4,
                                        Name = p.Name
                                    },
                                    new CmsCityText
                                    {
                                        CmsLanguageId = 5,
                                        Name = p.Name
                                    },
                                    new CmsCityText
                                    {
                                        CmsLanguageId = 6,
                                        Name = p.Name
                                    }
                                },
                                Counties = p.Cities.Select(x => new CmsCounty
                                {
                                    Active = true,
                                    Latitude = x.Latitude,
                                    Longitude = x.Longitude,
                                    Deleted = false,
                                    Texts = new List<CmsCountyText>
                                    {
                                        new CmsCountyText
                                        {
                                            CmsLanguageId = 1,
                                            Name = x.Name
                                        },
                                        new CmsCountyText
                                        {
                                            CmsLanguageId = 2,
                                            Name = x.Name
                                        },
                                        new CmsCountyText
                                        {
                                            CmsLanguageId = 3,
                                            Name = x.Name
                                        },
                                        new CmsCountyText
                                        {
                                            CmsLanguageId = 4,
                                            Name = x.Name
                                        },
                                        new CmsCountyText
                                        {
                                            CmsLanguageId = 5,
                                            Name = x.Name
                                        },
                                        new CmsCountyText
                                        {
                                            CmsLanguageId = 6,
                                            Name = x.Name
                                        }
                                    }
                                }).ToList(),
                            }).ToList(),
                            

                });
            }

            return new JsonResult(_cmsCountries);            
        }
        catch (System.Exception ex)
        {
            _logger.LogError(ex, "Error occured while getting countries");
            return new JsonResult(ex.Message);
        }        
    }
}