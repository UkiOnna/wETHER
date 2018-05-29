using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WheatherCitis
{
    [XmlRoot(ElementName = "current")]
    public class Current
    {
        [XmlElement(ElementName = "last_updated_epoch")]
        public string Lastupdatedepoch { get; set; }
        [XmlElement(ElementName = "last_updated")]
        public string Lastupdated { get; set; }
        [XmlElement(ElementName = "temp_c")]
        public string Tempc { get; set; }
        [XmlElement(ElementName = "temp_f")]
        public string Tempf { get; set; }
        [XmlElement(ElementName = "is_day")]
        public string Isday { get; set; }
        [XmlElement(ElementName = "condition")]
        public Condition Condition { get; set; }
        [XmlElement(ElementName = "wind_mph")]
        public string WindMph { get; set; }
        [XmlElement(ElementName = "wind_kph")]
        public string WindKph { get; set; }
        [XmlElement(ElementName = "wind_degree")]
        public string WindDegree { get; set; }
        [XmlElement(ElementName = "wind_dir")]
        public string WindDir { get; set; }
        [XmlElement(ElementName = "pressure_mb")]
        public string PressureMb { get; set; }
        [XmlElement(ElementName = "pressure_in")]
        public string PressureIn { get; set; }
        [XmlElement(ElementName = "precip_mm")]
        public string PrecipMm { get; set; }
        [XmlElement(ElementName = "precip_in")]
        public string PrecipIn { get; set; }
        [XmlElement(ElementName = "humidity")]
        public string Humidity { get; set; }
        [XmlElement(ElementName = "cloud")]
        public string Cloud { get; set; }
        [XmlElement(ElementName = "feelslike_c")]
        public string FeelslikeC { get; set; }
        [XmlElement(ElementName = "feelslike_f")]
        public string FeelslikeF { get; set; }
        [XmlElement(ElementName = "vis_km")]
        public string VisKm { get; set; }
        [XmlElement(ElementName = "vis_miles")]
        public string VisMiles { get; set; }
    }
}
