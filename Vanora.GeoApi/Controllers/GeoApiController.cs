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
        IList<TestCountry> result = new List<TestCountry> { };

        using (WebClient client = new WebClient())
        {
            using (StreamReader sr = new StreamReader(client.OpenRead("https://raw.githubusercontent.com/mvollstagg/GeoDb/main/Vanora.GeoDb/countries%2Bstates%2Bcities.json")))
            {
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    result = JsonSerializer.CreateDefault().Deserialize<List<TestCountry>>(reader);
                }
            }
        }

        var turkey = result.FirstOrDefault(x => x.Name == "Turkey");

        // var _mapper = serviceProvider.GetRequiredService<IMapper>();

        // var _mappedCountry = _mapper.Map<TestCountry, CmsCountry>(turkey, new CmsCountry());

        return new JsonResult(turkey);
    }
}