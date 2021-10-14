using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Models
{
    /// <summary>
    /// Model for the About section of the API
    /// Contains getters and setters for the data of the API - they return strings
    /// Used in the Index.cshtml View
    /// @author Filipa Ivankovic
    /// </summary>
    public class About
    {
        public string title { get; set; }
        public string description { get; set; }
        public string quote { get; set; }
        public string quoteAuthor { get; set; }
    }
}
