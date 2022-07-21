using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm_App.Models
{
    public static class Constants
    {
        public static List<string> Departments = new List<string>()
        {
            "IT", "System", "HRD", "Admin", "Production", "Maintenence"
        };
        public static List<string> Designations = new List<string>()
        {
            "Manager", "Lead", "Staff", "Director"
        };
    }
}