using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json;

namespace elFinder.NetCore.Models.Commands
{
    public class BaseOpenResponseModel
    {
        private static DebugResponseModel debug = new DebugResponseModel();

        public BaseOpenResponseModel(DirectoryModel currentWorkingDirectory)
        {
            Files = new List<object>();
            CurrentWorkingDirectory = currentWorkingDirectory;
        }

        [JsonProperty("cwd")]
        public DirectoryModel CurrentWorkingDirectory { get; protected set; }

        [JsonProperty("debug")]
        public DebugResponseModel Debug => debug;

        [JsonProperty("files")]
        public List<object> Files { get; protected set; }

        [JsonProperty("options")]
        public Options Options { get; protected set; }
    }
}