using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Project3.Models;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace Project3.Services
{
    /// <summary>
    /// The main class for consuming the data from the RIT IST API
    /// @author Filipa Ivankovic
    /// </summary>
    public class ISTClient
    {
        /// <summary>
        /// Global variable - HttpClient client
        /// </summary>
        private static readonly HttpClient client = new HttpClient();

        /// <summary>
        /// Static ISTClient
        /// Defines Uri address for the global client & makes it accept only json data
        /// </summary>
        static ISTClient() 
        {
            client.BaseAddress = new Uri("http://ist.rit.edu");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    
        /// <summary>
        /// GetAboutAsyncs() static async function
        /// Consumes the data from the '/about' section of the API and returns it deserialized
        /// </summary>
        /// <returns>Deserialized json data formated according to the About.cs model</returns>
        public static async Task<About> GetAboutAsync()
        {
            Task<string> aboutTask = client.GetStringAsync("/api/about");
            string response = await aboutTask;
            About about = JsonConvert.DeserializeObject<About>(response);

            return about;
        }

        /// <summary>
        ///  GetNewsAsync() static async function()
        ///  Consumes data from the '/news' section of the API and returns is deserialized
        /// </summary>
        /// <returns>NewsViewModel - Deserialized json data formated according to the NewsViewModel.cs structure</returns>
        /// <exception cref="HttpRequestException">Error with the consuming the API - returns empty NewsViewModel</exception>
        /// <exception cref="Exception">Basic generic exception</exception>
        public static async Task<NewsViewModel> GetNewsAsync() 
        {
            try 
            {
                HttpResponseMessage response = await client.GetAsync("/api/news", HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();

                NewsViewModel newsList = JsonConvert.DeserializeObject<NewsViewModel>(data);
                return newsList;
            }
            catch (HttpRequestException hre)
            {
                var msg = hre.Message;
                NewsViewModel newsList = new NewsViewModel();
                return newsList;
            }
            catch (Exception e)
            {
                var msg = e.Message;
                NewsViewModel newsList = new NewsViewModel();
                return newsList;
            }
        }

        /// <summary>
        ///  GetDegreesAsync() static async function()
        ///  Consumes data from the '/degrees' section of the API and returns is deserialized
        ///  The data for the undergraduate & graduate sections
        /// </summary>
        /// <returns>DegreesViewModel- Deserialized json data formated according to the DegreesViewModel.cs structure</returns>
        /// <exception cref="HttpRequestException">Error with the consuming the API - returns empty DegreesViewModel</exception>
        /// <exception cref="Exception">Basic generic exception</exception>
        public static async Task<DegreesViewModel> GetDegreesAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("/api/degrees", HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();

                DegreesViewModel degreesList = JsonConvert.DeserializeObject<DegreesViewModel>(data);
                return degreesList;
            }
            catch (HttpRequestException hre)
            {
                var msg = hre.Message;
                DegreesViewModel degreesList = new DegreesViewModel();
                return degreesList;
            }
            catch (Exception e)
            {
                var msg = e.Message;
                DegreesViewModel degreesList = new DegreesViewModel();
                return degreesList;
            }

        }

        /// <summary>
        ///  GetFacultyAsync() static async function()
        ///  Consumes data from the '/people/faculty' section of the API and returns is deserialized
        ///  The data for the faculty section
        /// </summary>
        /// <returns>FacultyViewModel- Deserialized json data formated according to the FacultyViewModel.cs structure</returns>
        /// <exception cref="HttpRequestException">Error with the consuming the API - returns empty FacultyViewModel</exception>
        /// <exception cref="Exception">Basic generic exception</exception>
        public static async Task<FacultyViewModel> GetFacultyAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("/api/people/faculty", HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();

                FacultyViewModel facultyList = JsonConvert.DeserializeObject<FacultyViewModel>(data);
                return facultyList;
            }
            catch (HttpRequestException hre)
            {
                var msg = hre.Message;
                FacultyViewModel facultyList = new FacultyViewModel();
                return facultyList;
            }
            catch (Exception e)
            {
                var msg = e.Message;
                FacultyViewModel facultyList = new FacultyViewModel();
                return facultyList;
            }
        }

        /// <summary>
        ///  GetCoopTable() static async function()
        ///  Consumes data from the '/employment' section of the API and returns is deserialized
        ///  The data for the coop table
        /// </summary>
        /// <returns>CoopTableViewModel- Deserialized json data formated according to the CoopTableViewModel.cs structure</returns>
        /// <exception cref="HttpRequestException">Error with the consuming the API - returns empty CoopTableViewModel</exception>
        /// <exception cref="Exception">Basic generic exception</exception>
        public static async Task<CoopTableViewModel> GetCoopTableAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("/api/employment", HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();

                CoopTableViewModel coopTableList = JsonConvert.DeserializeObject<CoopTableViewModel>(data);
                return coopTableList;
            }
            catch (HttpRequestException hre)
            {
                var msg = hre.Message;
                CoopTableViewModel coopTableList = new CoopTableViewModel();
                return coopTableList;
            }
            catch (Exception e)
            {
                var msg = e.Message;
                CoopTableViewModel coopTableList = new CoopTableViewModel();
                return coopTableList;
            }
        }

        /// <summary>
        ///  GetEmploymentAsync() static async function()
        ///  Consumes data from the '/employment' section of the API and returns is deserialized - same as the coop table function
        ///  The data for the employment table
        /// </summary>
        /// <returns>EmploymentTableViewModel- Deserialized json data formated according to the EmploymentTableViewModel.cs structure</returns>
        /// <exception cref="HttpRequestException">Error with the consuming the API - returns empty EmploymentTableViewModel</exception>
        /// <exception cref="Exception">Basic generic exception</exception>
        public static async Task<EmploymentTableViewModel> GetEmploymentTableAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("/api/employment", HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();

                EmploymentTableViewModel coopTableList = JsonConvert.DeserializeObject<EmploymentTableViewModel>(data);
                return coopTableList;
            }
            catch (HttpRequestException hre)
            {
                var msg = hre.Message;
                EmploymentTableViewModel coopTableList = new EmploymentTableViewModel();
                return coopTableList;
            }
            catch (Exception e)
            {
                var msg = e.Message;
                EmploymentTableViewModel coopTableList = new EmploymentTableViewModel();
                return coopTableList;
            }
        }
    }
}
