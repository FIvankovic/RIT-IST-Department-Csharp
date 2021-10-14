using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Models
{
    /// <summary>
    /// Model for the extra News section of the API
    /// Used in the View New.cshtml
    /// @author Filipa Ivankovic
    /// </summary>
    public class NewsViewModel
    {
        public Older[] Older { get; set; }
    }
}
