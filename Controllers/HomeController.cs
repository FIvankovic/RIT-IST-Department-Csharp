using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project3.Models;
using Project3.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Controllers
{
    /// <summary>
    /// Main Controller
    /// Responsible for displaying the appropriate partial Views
    /// @author Filipa Ivankovic
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Displays the CoopTable View by calling the ISTClient.GetCoopTableAsync() function
        /// </summary>
        /// <returns>CoopTableViewModel as View</returns>
        public async Task<IActionResult> CoopTable() 
        {
            CoopTableViewModel coopTableViewModel = await ISTClient.GetCoopTableAsync();
            return View(coopTableViewModel);
        }

        /// <summary>
        /// Displays the EmploymentTable View by calling the ISTClient.EmploymentTableAsync() function
        /// </summary>
        /// <returns>EmploymentTableViewModel as View</returns>
        public async Task<IActionResult> EmploymentTable()
        {
            EmploymentTableViewModel employmentTableViewModel = await ISTClient.GetEmploymentTableAsync();
            return View(employmentTableViewModel);
        }

        /// <summary>
        /// Displays the About View by calling the ISTClient.GetAboutAsync() function
        /// <description>The 'about' section of the API serves as the index of the webpage</description>
        /// </summary>
        /// <returns>About model as View</returns>
        public async Task<IActionResult> IndexAsync()
        {
            About about = await ISTClient.GetAboutAsync();
            return View(about);
        }

        /// <summary>
        /// Displays the Degrees View by calling the ISTClient.DegreseAsync() function
        /// Displays both the data for the undergraduate & graduate sections of the API
        /// </summary>
        /// <returns>Degrees as View</returns>
        public async Task<IActionResult> DegreesAsync()
        {
            DegreesViewModel degreesViewModel = await ISTClient.GetDegreesAsync();
            return View(degreesViewModel);
        }

        /// <summary>
        /// Displays the Faculty View by calling the ISTClient.GetFacultyAsync() function
        /// <description>The Faculty & their data are displayed as 'card' divs on the page</description>
        /// </summary>
        /// <returns>FacultyViewModel as View</returns>
        public async Task<IActionResult> FacultyAsync()
        {
            FacultyViewModel facultyViewModel = await ISTClient.GetFacultyAsync();
            return View(facultyViewModel);
        }

        /// <summary>
        /// Displays the Extra News View by calling the ISTClient.GetNewsAsync() function
        /// <description>News articles are displayed from the newest to the oldest (newest being at the top of the page)</description>
        /// </summary>
        /// <returns>NewsViewModel as View</returns>
        public async Task<IActionResult> NewsAsync()
        {
            NewsViewModel newsViewModel = await ISTClient.GetNewsAsync();
            return View(newsViewModel);
        }

        /// <summary>
        /// The Privacy Page
        /// </summary>
        /// <description>No changes from the default</description>
        /// <returns>The Privacy view</returns>
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
