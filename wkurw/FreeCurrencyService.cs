using System.Linq;
using Newtonsoft.Json.Linq;

namespace wkurw
{
    public class FreeCurrencyServise
    {
        public double GetDataFromService(string waluta1, string waluta2)
        {
            var srodek = waluta1 + "_" + waluta2;

            var exUrl = "http://free.currencyconverterapi.com/api/v3/convert?q=" + srodek + "&compact=y";
            string kursWymiany = "";
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(exUrl);

                var stuff = JObject.Parse(json);


                foreach (var rate in stuff[srodek].Cast<JProperty>())
                {
                    kursWymiany = rate.Value.ToString();
                }
            }
            return double.Parse(kursWymiany);
        }
    }
}