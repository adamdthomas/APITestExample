using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace APITest
{
    public static class Utilities
    {
        //calls web service and returns xml from that webservice as a XmlReader
        public static XmlReader get(Uri uri)
        {
            HttpWebRequest request;

            request = (HttpWebRequest)WebRequest.Create(uri);
            request.Accept = "application/xml";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(resStream);
            string r = reader.ReadToEnd();
            XmlReader responseReader = XmlReader.Create(new StringReader(r));

            return responseReader;
        }

    }

}

