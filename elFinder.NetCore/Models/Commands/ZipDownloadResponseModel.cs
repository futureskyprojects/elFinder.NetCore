using Newtonsoft.Json;

namespace elFinder.NetCore.Models.Commands
{
    public class ZipDownloadResponseModel
    {
        [JsonProperty("zipdl")]
        public ZipDownloadData ZipDownload { get; set; }

        public class ZipDownloadData
        {
            [JsonProperty("file")]
            public string File { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("mime")]
            public string Mime { get; set; }
        }
    }
}