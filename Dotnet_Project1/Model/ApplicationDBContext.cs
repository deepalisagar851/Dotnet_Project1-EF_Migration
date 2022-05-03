using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Dotnet_Project1.Model
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(): base("Data Source = CHETUIWK1860\\SQLEXPRESS; Initial Catalog = EmployeeDb; Integrated Security = True; Pooling = False") { }

        public DbSet<Employee>Employees { get; set; }
    }
}