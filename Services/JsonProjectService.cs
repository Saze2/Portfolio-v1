using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using PortfolioWebApp.Models;

namespace PortfolioWebApp.Services
{
    public class JsonProjectService
    {
        //webhostenvironment to get the filepath
        public JsonProjectService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "projects.json"); }
        }

        public IEnumerable<Project> GetProjects()
        {

            // deserialize JSON directly from a file
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {

                return JsonSerializer.Deserialize<Project[]>(jsonFileReader.ReadToEnd());
            }
        }
    }
}
