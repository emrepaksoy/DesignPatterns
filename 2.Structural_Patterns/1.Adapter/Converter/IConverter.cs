using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public interface IConverter
    {
        string ConvertXmlToJson();
    }

    public class XmlToJsonAdapter : IConverter
    {
        private readonly ThirdParyAPI _xmlConverter;

        public XmlToJsonAdapter(ThirdParyAPI xmlConverter)
        {
            _xmlConverter = xmlConverter;
        }
        public string ConvertXmlToJson()
        {

            string jsonText = JsonConvert.SerializeXNode(_xmlConverter.GetXML());
            return jsonText;
        }
       
    }
}
