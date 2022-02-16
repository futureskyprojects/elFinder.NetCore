using Newtonsoft.Json;

namespace elFinder.NetCore.Models
{
    public class RootModel : DirectoryModel
    {
        [JsonProperty("isroot")]
        public byte IsRoot => 1;
    }
}