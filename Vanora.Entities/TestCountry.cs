using System.Text.Json.Serialization;

namespace Vanora.Entities
{
    public class TestCountry
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("iso3")]
        public string Iso3 { get; set; }

        [JsonPropertyName("iso2")]
        public string Iso2 { get; set; }

        [JsonPropertyName("numeric_code")]
        public string NumericCode { get; set; }

        [JsonPropertyName("phone_code")]
        public string PhoneCode { get; set; }

        [JsonPropertyName("capital")]
        public string Capital { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("currency_name")]
        public string CurrencyName { get; set; }

        [JsonPropertyName("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonPropertyName("tld")]
        public string Tld { get; set; }

        [JsonPropertyName("native")]
        public string Native { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("subregion")]
        public string Subregion { get; set; }

        [JsonPropertyName("timezones")]
        public List<Timezone> Timezones { get; set; }

        [JsonPropertyName("translations")]
        public Translations Translations { get; set; }

        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        [JsonPropertyName("emoji")]
        public string Emoji { get; set; }

        [JsonPropertyName("emojiU")]
        public string EmojiU { get; set; }

        [JsonPropertyName("states")]
        public List<City> States { get; set; }
    }

    public class City
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("state_code")]
        public string StateCode { get; set; }

        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("cities")]
        public List<County> Cities { get; set; }
    }

    public class County
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }
    }

    public class Timezone
    {
        [JsonPropertyName("zoneName")]
        public string ZoneName { get; set; }

        [JsonPropertyName("gmtOffset")]
        public int GmtOffset { get; set; }

        [JsonPropertyName("gmtOffsetName")]
        public string GmtOffsetName { get; set; }

        [JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonPropertyName("tzName")]
        public string TzName { get; set; }
    }

    public class Translations
    {
        [JsonPropertyName("kr")]
        public string Kr { get; set; }

        [JsonPropertyName("pt-BR")]
        public string PtBR { get; set; }

        [JsonPropertyName("pt")]
        public string Pt { get; set; }

        [JsonPropertyName("nl")]
        public string Nl { get; set; }

        [JsonPropertyName("hr")]
        public string Hr { get; set; }

        [JsonPropertyName("fa")]
        public string Fa { get; set; }

        [JsonPropertyName("de")]
        public string De { get; set; }

        [JsonPropertyName("es")]
        public string Es { get; set; }

        [JsonPropertyName("fr")]
        public string Fr { get; set; }

        [JsonPropertyName("ja")]
        public string Ja { get; set; }

        [JsonPropertyName("it")]
        public string It { get; set; }

        [JsonPropertyName("cn")]
        public string Cn { get; set; }

        [JsonPropertyName("tr")]
        public string Tr { get; set; }
    }
}