using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WebApiApplicationTest.Dto;

namespace WebApiApplicationTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RapidApi : ControllerBase
    {
        /*
 * 'https://working-days.p.rapidapi.com/analyse?country_code=AU&start_date=2022-01-01&end_date=2022-12-31&configuration=Queensland&start_time=09:13&end_time=17:35' \
--header 'X-RapidAPI-Key: 37c9993b09mshc41dc4f6dc793fap181029jsnf7fa2596915f' \
--header 'X-RapidAPI-Host: working-days.p.rapidapi.com'
 */
        [HttpGet]
        public async Task<AnalyseRsp> Analyse(string country_code = "AU", string startDate = "2022-01-01", 
            string endDate = "2022-12-31", string configuration = "Queensland", string startTime = "09:13", string endTime = "17:35")
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "37c9993b09mshc41dc4f6dc793fap181029jsnf7fa2596915f");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "working-days.p.rapidapi.com");

            var analyseRsp = await client
                .GetAsync($"https://working-days.p.rapidapi.com/analyse?country_code={country_code}&start_date={startDate}" +
                $"&end_date={endDate}&configuration={configuration}&start_time={startTime}&end_time={endTime}");

            var responseString = await analyseRsp.Content.ReadAsStringAsync();
            AnalyseRsp result = JsonConvert.DeserializeObject<AnalyseRsp>(responseString.ToString());
            return result;
        }
    }
}
