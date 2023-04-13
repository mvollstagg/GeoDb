using System.Text;
using System.Text.Json;
using Newtonsoft.Json.Serialization;

namespace Vanora.GeoDb
{
    public class CustomNamingStrategy : NamingStrategy
    {
        protected override string ResolvePropertyName(string name)
        {
            // Replace underscores with spaces and split into words
            var words = name.Replace("_", " ").Split(" ");

            // Capitalize the first letter of each word and join them together
            var result = string.Join("", words.Select(word => char.ToUpper(word[0]) + word.Substring(1)));

            // Lowercase the first letter and return the result
            return char.ToLower(result[0]) + result.Substring(1);
        }
    }
}