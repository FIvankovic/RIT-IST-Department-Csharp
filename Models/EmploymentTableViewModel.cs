using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Models
{
    /// <summary>
    /// Model for the Employment table section of the API
    /// Contains getters and setters for the data of the API - they return strings
    /// Used in the View EmploymentTable.cshtml
    /// @author Filipa Ivankovic
    /// </summary>
    public class EmploymentTableViewModel
    {
        /// <summary>
        /// Get and set the model Employmenttable.cs
        /// </summary>
        public Employmenttable employmentTable { get; set; }
    }

}
