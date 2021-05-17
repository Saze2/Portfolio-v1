using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PortfolioWebApp.Services;
using PortfolioWebApp.Models;
using Microsoft.Extensions.Configuration;

namespace PortfolioWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private JsonProjectService _jsonProjectService;
        public IEnumerable<Project> _projects; 

        public IndexModel(ILogger<IndexModel> logger, JsonProjectService jsonProjectService)
        {
            _logger = logger;
            _jsonProjectService = jsonProjectService;
        }

        public void OnGet()
        {         
            _projects = _jsonProjectService.GetProjects();
            SortProjects();
        }

        public void SortProjects()
        {
            _projects = _projects.OrderByDescending(p => p.dateYear).ThenByDescending(p => 
            p.dateSeason == "Winter" ? 1: 
            p.dateSeason == "Spring" ? 2: 
            p.dateSeason == "Summer" ? 3: 
            p.dateSeason == "Autumn" ? 4:
            5);                   
        }
    }
}
