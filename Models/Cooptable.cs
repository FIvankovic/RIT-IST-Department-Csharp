using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Models
{
    /// <summary>
    /// Model for the CoopTable section of the API
    /// Contains getters and setters for the data of the API - they return strings
    /// Used by the CoopTableViewModel.cs
    /// @author Filipa Ivankovic
    /// </summary>
    public class Cooptable
    {
        public string title { get; set; }
        /// <summary>
        /// Function to get and set the data from the Coopinformation.cs model
        /// </summary>
        public Coopinformation[] coopInformation { get; set; }
    }

}
