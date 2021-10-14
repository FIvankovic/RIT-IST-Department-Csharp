using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Models
{
    /// <summary>
    /// Model for the Undergraduate section of the API - Undergraduate & Graduate
    /// Contains getters and setters for the data of the API - they return strings
    /// Used by the DegreesViewModel.cs model
    /// @author Filipa Ivankovic
    /// </summary>
    public class Undergraduate
    {
            public string degreeName { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string[] concentrations { get; set; }

    }
}
