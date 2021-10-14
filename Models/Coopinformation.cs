namespace Project3.Models
{
    /// <summary>
    /// Model for the CoopTable section of the API
    /// Contains getters and setters for the data of the API - they return strings
    /// Used by the Cooptable.cs, which is then used by CoopTableViewModel.cs
    /// @author Filipa Ivankovic
    /// </summary>
    public class Coopinformation
    {
        public string employer { get; set; }
        public string degree { get; set; }
        public string city { get; set; }
        public string term { get; set; }
    }

}
