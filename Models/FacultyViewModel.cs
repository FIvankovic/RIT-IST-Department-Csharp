using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Models
{
    /// <summary>
    /// Model for the Faculty section of the API
    /// Used in the Faculty.cshtml View
    /// @author Filipa Ivankovic
    /// </summary>
    public class FacultyViewModel
    {
        /// <summary>
        /// Getters and setters for the faculty model Faculty.cs
        /// </summary>
        public Faculty[] Faculty { get; set; }
    }
}
