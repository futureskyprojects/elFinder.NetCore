using System.Collections.Generic;
using Newtonsoft.Json;

namespace elFinder.NetCore.Models.Commands
{
    public class TreeResponseModel
    {
        public TreeResponseModel()
        {
            Tree = new List<object>();
        }

        [JsonProperty("tree")]
        public List<object> Tree { get; private set; }
    }
}