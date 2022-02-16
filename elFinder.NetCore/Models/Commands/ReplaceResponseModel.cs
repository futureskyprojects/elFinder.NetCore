using System.Collections.Generic;
using Newtonsoft.Json;

namespace elFinder.NetCore.Models.Commands
{
    public class ReplaceResponseModel
    {
        public ReplaceResponseModel()
        {
            Added = new List<object>();
            Removed = new List<string>();
        }

        [JsonProperty("added")]
        public List<object> Added { get; private set; }

        [JsonProperty("removed")]
        public List<string> Removed { get; private set; }
    }
}