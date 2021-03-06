using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Centric_Consulting_Project.Models
{
    public class Profile
    {
        [Key]
        public int EmployeeId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public enum BusinessUnitName { Boston, Charlotte, Chicago, Cincinnati, Cleveland, Columbus, Detroit, India, Indianapolis, Louisville, Miami, Seattle, StLouis }
        public BusinessUnitName BusinessUnit { get; set; }
        // Boston, Charlotte, Chicago, Cincinnati, Cleveland, Columbus, Detroit, India, Indianapolis, 
        // Louisville, Miami, Seattle, and St. Louis. 
        public DateTime hireDate { get; set; }
        public enum BusinessTitle { Consultant, SeniorConsultant, Manager, SeniorManager, Architect, SeniorArchitect, Partner, National }
        public BusinessTitle Title{ get; set; }
        // Consultant, Senior Consultant, Manager, Senior Manager, Architect, Senior Architect, Partner, and National.
        public string email { get; set; }
        public string Phone { get; set; }
    }
}
