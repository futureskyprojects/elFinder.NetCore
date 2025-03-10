﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace elFinder.NetCore.Models.Commands
{
    public class InitResponseModel : BaseOpenResponseModel
    {
        private static string[] empty = new string[0];

        public InitResponseModel(DirectoryModel currentWorkingDirectory, Options options) : base(currentWorkingDirectory)
        {
            Options = options;
        }

        [JsonProperty("api")]
        public string Api => "2.1049";

        [JsonProperty("netDrivers")]
        public IEnumerable<string> NetDrivers => empty;
    }
}