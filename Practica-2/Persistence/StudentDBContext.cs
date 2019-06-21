using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class StudentDBContext : DbContext 
    {
        public DbSet<Student> Student { get; set; }

        public StudentDBContext(DbContextOptions<StudentDBContext> options):base(options)
        { }
    }
}
