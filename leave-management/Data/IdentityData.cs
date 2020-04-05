using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;        
using leave_management.Models;
namespace leave_management.Data
{
    public class IdentityDataContext: IdentityDbContext
    {
        public IdentityDataContext (DbContextOptions<IdentityDataContext> options) :base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }  
        public DbSet<Leavehistory> Leavehistories { get; set; }

        public DbSet<LeaveType> LeaveTypes { get; set; }

        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }

        public DbSet<leave_management.Models.LeaveTypeVM> DetailsLeaveTypeVM { get; set; }
    }

}
