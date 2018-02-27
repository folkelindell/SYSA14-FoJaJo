using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Model
{
    public class EmployeeRelative
    {
        /*
            select employee.[First Name], employee.[Last Name], employee.[Job Title], relative.[First Name], relative.[Relative Code] 
            from [CRONUS Sverige AB$Employee] employee
            right join [CRONUS Sverige AB$Employee Relative] relative
            on employee.No_ = relative.[Employee No_];
         */
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public string EmpJobTitle { get; set; }
        public string RelativeFirstName { get; set; }
        public string RelativeCode { get; set; }

        public EmployeeRelative() { }
        public EmployeeRelative(string eName, string eLName, string title, string relativeName, string relativeCode)
        {
            EmpFirstName = eName;
            EmpLastName = eLName;
            EmpJobTitle = title;
            RelativeFirstName = relativeName;
            RelativeCode = relativeCode;
        }
    }
}