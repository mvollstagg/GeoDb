using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Vanora.Entities;
using Vanora.GeoDb;

string json = @"{
    ""id"": 225,
    ""name"": ""Turkey"",
    ""iso3"": ""TUR"",
    ""iso2"": ""TR"",
    ""numericcode"": ""792"",
    ""phonecode"": ""90"",
    ""capital"": ""Ankara"",
    ""currency"": ""TRY"",
    ""currencyname"": ""Turkish lira"",
    ""currencysymbol"": ""₺"",
    ""tld"": "".tr"",
    ""native"": ""Türkiye"",
    ""region"": ""Asia"",
    ""subregion"": ""Western Asia"",
    ""timezones"": [
        {
            ""zoneName"": ""Europe\/Istanbul"",
            ""gmtOffset"": 10800,
            ""gmtOffsetName"": ""UTC+03:00"",
            ""abbreviation"": ""EET"",
            ""tzName"": ""Eastern European Time""
        }
    ],
    ""translations"": {
        ""kr"": ""터키"",
        ""ptBR"": ""Turquia"",
        ""pt"": ""Turquia"",
        ""nl"": ""Turkije"",
        ""hr"": ""Turska"",
        ""fa"": ""ترکیه"",
        ""de"": ""Türkei"",
        ""es"": ""Turquía"",
        ""fr"": ""Turquie"",
        ""ja"": ""トルコ"",
        ""it"": ""Turchia"",
        ""cn"": ""土耳其"",
        ""tr"": ""Türkiye""
    },
    ""latitude"": ""39.00000000"",
    ""longitude"": ""35.00000000"",
    ""emoji"": ""🇹🇷"",
    ""emojiU"": ""U+1F1F9 U+1F1F7"",
    ""states"": [            
        {
            ""id"": 2213,
            ""name"": ""Zonguldak"",
            ""statecode"": ""67"",
            ""latitude"": ""41.31249170"",
            ""longitude"": ""31.85982510"",
            ""type"": ""province"",
            ""cities"": [
                {
                    ""id"": 107124,
                    ""name"": ""Alaplı"",
                    ""latitude"": ""41.18140000"",
                    ""longitude"": ""31.38514000""
                },
                
                {
                    ""id"": 108755,
                    ""name"": ""Merkez"",
                    ""latitude"": ""41.45139000"",
                    ""longitude"": ""31.79305000""
                }
            ]
        }
    ]
}";

var country = JsonConvert.DeserializeObject<TestCountry>(json);
IList<TestCountry> result = new List<TestCountry> { country };

var serializerSettings = new JsonSerializerSettings
{
    ContractResolver = new DefaultContractResolver
    {
        NamingStrategy = new CustomNamingStrategy()
    }
};




using (WebClient client = new WebClient())
{
    using (StreamReader sr = new StreamReader(client.OpenRead("https://raw.githubusercontent.com/dr5hn/countries-states-cities-database/master/countries%2Bstates%2Bcities.json")))
    {
        using (JsonReader reader = new JsonTextReader(sr))
        {
            JsonSerializer serializer = new JsonSerializer();
            result = JsonSerializer.Create(serializerSettings).Deserialize<List<TestCountry>>(reader);
        }
    }
}

var turkey = result.FirstOrDefault(x => x.Name == "Turkey");

Console.WriteLine(json);
