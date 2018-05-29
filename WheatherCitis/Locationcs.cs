﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WheatherCitis
{
    [XmlRoot(ElementName = "location")]
    public class Location
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "region")]
        public string Region { get; set; }
        [XmlElement(ElementName = "country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "lat")]
        public string Lat { get; set; }
        [XmlElement(ElementName = "lon")]
        public string Lon { get; set; }
        [XmlElement(ElementName = "tz_id")]
        public string TzId { get; set; }
        [XmlElement(ElementName = "localtime_epoch")]
        public string LocaltimeEpoch { get; set; }
        [XmlElement(ElementName = "localtime")]
        public string Localtime { get; set; }
    }
}
