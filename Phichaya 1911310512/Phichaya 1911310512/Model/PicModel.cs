using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Phichaya_1911310512.Model
{
    public class PicModel
    {
    }

    [JsonObject]
    public class PicDetail
    {
        public string copyright { get; set; }
        public string date { get; set; }
        public string explanation { get; set; }
        public string hdurl { get; set; }
        public string media_type { get; set; }
        public string service_version { get; set; }
        public string title { get; set; }
        public string url { get; set; }
    }
}
