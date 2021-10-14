namespace Project3.Models
{
    /// <summary>
    /// Model for the Employment table section of the API
    /// Contains getters and setters for the data of the API - they return strings
    /// Used by EmploymentTableViewModel.cs and Employmenttable.cs
    /// @author Filipa Ivankovic
    /// </summary>
    public class Professionalemploymentinformation
    {
        public string employer { get; set; }
        public string degree { get; set; }
        public string city { get; set; }
        public string title { get; set; }
        public string startDate { get; set; }
    }

}
