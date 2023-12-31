﻿using Microsoft.EntityFrameworkCore;
using TestApp.Models;

namespace TestApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) { }
        public DbSet<IntegerSum> IntegerSums { get; set; }
    }
}
