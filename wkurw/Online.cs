using System.Net;

namespace wkurw
{
    public class Online
    {
        public bool is_Online()
        {
            string wwww = "http://google.com";

            try
            {
                HttpWebRequest tmp = (HttpWebRequest)WebRequest.Create(wwww);
                tmp.Timeout = 5000;
                WebResponse result = tmp.GetResponse();
                result.Close();
                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}