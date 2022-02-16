using System.Collections.Generic;
using Newtonsoft.Json;

namespace elFinder.NetCore.Models.Commands
{
    public class SearchResponseModel
    {
        public SearchResponseModel()
        {
            Files = new List<object>();
        }

        [JsonProperty("files")]
        public List<object> Files { get; private set; }
    }
}