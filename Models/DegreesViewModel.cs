using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Models
{
    /// <summary>
    /// Model for the Degrees section of the API - Undergraduate & Graduate
    /// Contains getters and setters for the data of the API - they return strings
    /// Used in the View Degrees.cshtml
    /// @author Filipa Ivankovic
    /// </summary>
    public class DegreesViewModel
    {
        /// <summary>
        /// Function for getting and setting the undergraduate data from the Undegraduate.cs model
        /// </summary>
        public Undergraduate[] undergraduate { get; set; }

        /// <summary>
        /// Function for getting and setting the graduate data from the Graduate.cs model
        /// </summary>
        public Graduate[] graduate { get; set; }
    }
}
