using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Centric_Consulting_Project.Models
{
    public class Profile
    {
        public int EmployeeId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string businessUnit { get; set; }
        // Boston, Charlotte, Chicago, Cincinnati, Cleveland, Columbus, Detroit, India, Indianapolis, 
        // Louisville, Miami, Seattle, and St. Louis. 
        public DateTime hireDate { get; set; }
        public string title { get; set; }
        // Consultant, Senior Consultant, Manager, Senior Manager, Architect, Senior Architect, Partner, and National.
        public string email { get; set; }
        public string phone { get; set; }
    }
}
