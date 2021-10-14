namespace Project3.Models
{
    /// <summary>
    /// Model for the extra News section of the API
    /// Contains getters and setters for the data of the API - they return strings
    /// Used by the NewsViewModel.cs model
    /// @author Filipa Ivankovic
    /// </summary>
    public class Older
    {
        public string date { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }

}
