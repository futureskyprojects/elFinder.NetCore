﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace elFinder.NetCore.Models.Commands
{
    public class AddResponseModel
    {
        [JsonProperty("added")]
        public List<object> Added { get; protected set; }

        [JsonProperty("hashes")]
        public Dictionary<string, string> Hashes { get; protected set; }

        public AddResponseModel()
        {
            Added = new List<object>();
            Hashes = new Dictionary<string, string>();
        }
    }
}