namespace Project3.Models
{
    /// <summary>
    /// Model for the Employment table section of the API
    /// Contains getters and setters for the data of the API - they return strings
    /// Used by the EmploymenTableViewModel.cs
    /// @author Filipa Ivankovic
    /// </summary>
    public class Employmenttable
    {
        public string title { get; set; }

        /// <summary>
        /// Getters and setter for the model Professionalemploymentinformation which contains the table data
        /// </summary>
        public Professionalemploymentinformation[] professionalEmploymentInformation { get; set; }
    }

}
