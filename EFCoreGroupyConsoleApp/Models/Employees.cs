﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EFCoreGroupByConsoleApp.Models
{
    public partial class Employees
    {
        public Employees()
        {
            InverseReportsToNavigationEmployee = new HashSet<Employees>();
        }

        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int? ContactTypeIdentifier { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public int? CountryIdentifier { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }
        public int? ReportsToNavigationEmployeeId { get; set; }

        public virtual Employees ReportsToNavigationEmployee { get; set; }
        public virtual ICollection<Employees> InverseReportsToNavigationEmployee { get; set; }
    }
}