using Linkedin.Application.Abstractions;
using Linkedin.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedin.Infrastructure.Persistance
{
    public class LinkedinDbContext : DbContext, ILinkedinDbContext
    {
        public LinkedinDbContext(DbContextOptions<LinkedinDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }

    }
}
