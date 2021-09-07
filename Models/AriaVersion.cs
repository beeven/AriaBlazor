using System;

namespace AriaBlazor.Models
{
    public record AriaVersion
    {
        public string Version {get;init;} = "";
        public string[] EnabledFeatures {get;init;} = {};
    }
}