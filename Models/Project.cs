using Microsoft.AspNetCore.Components.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PortfolioWebApp.Models
{
    public class Project
    {
        public string searchtag { get; set; }
        public string name { get; set; }
        public string logoLink { get; set; }
        public string badges { get; set; }
        public string description { get; set; }
        public string dateYear { get; set; }
        public string dateSeason { get; set; }
        public string link { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Project>(this);
        }
    }
}

