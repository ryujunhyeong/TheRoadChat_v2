using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.IO;

namespace TheRoadChat
{
    class Address
    {
        static HttpClient client = new HttpClient();
        public string search(string addr)
        {
            bool check = false;
            foreach (char c in addr)
            {
                string a = c.ToString();
                try
                {
                    Int32.Parse(a);
                    check = true;
                }
                catch
                {
                    continue;
                }
            }
            if (check == false)
            {
                return "error";
            }


            var results = "";
            string url = "http://openapi.epost.go.kr/postal/retrieveNewAdressAreaCdSearchAllService/retrieveNewAdressAreaCdSearchAllService/getNewAddressListAreaCdSearchAll"; // URL
            url += "?ServiceKey=" + "r98wAIaVUk5QyYMjhejsD3v8S19OuMwzavL1nBn3rR03tXyv2frh3A8POgYu5H2GBfb6GDnixNuQgCHOdzJW%2FA%3D%3D"; // Service Key
            url += "&srchwrd=" + addr;
            url += "&countPerPage=1";
            url += "&Page=1";

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
                var aa = results.Split('>');
                var bbbb = aa[28].Split('<');
                return bbbb[0];
            }
        }
    }
}
