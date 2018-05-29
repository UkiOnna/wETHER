using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WheatherCitis
{
    [XmlRoot(ElementName = "day")]
    public class Day
    {
        [XmlElement(ElementName = "maxtemp_c")]
        public string MaxtempC { get; set; }
        [XmlElement(ElementName = "maxtemp_f")]
        public string MaxtempF { get; set; }
        [XmlElement(ElementName = "mintemp_c")]
        public string MintempC { get; set; }
        [XmlElement(ElementName = "mintemp_f")]
        public string MintempF { get; set; }
        [XmlElement(ElementName = "avgtemp_c")]
        public string AvgtempC { get; set; }
        [XmlElement(ElementName = "avgtemp_f")]
        public string AvgtempF { get; set; }
        [XmlElement(ElementName = "maxwind_mph")]
        public string MaxwindMph { get; set; }
        [XmlElement(ElementName = "maxwind_kph")]
        public string MaxwindKph { get; set; }
        [XmlElement(ElementName = "totalprecip_mm")]
        public string TotalprecipMm { get; set; }
        [XmlElement(ElementName = "totalprecip_in")]
        public string TotalprecipIn { get; set; }
        [XmlElement(ElementName = "avgvis_km")]
        public string AvgvisKm { get; set; }
        [XmlElement(ElementName = "avgvis_miles")]
        public string AvgvisMiles { get; set; }
        [XmlElement(ElementName = "avghumidity")]
        public string Avghumidity { get; set; }
        [XmlElement(ElementName = "condition")]
        public Condition Condition { get; set; }
        [XmlElement(ElementName = "uv")]
        public string Uv { get; set; }
    }
}
