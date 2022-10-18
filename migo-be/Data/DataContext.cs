﻿using System;
using Alliance_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Alliance_API.Data
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees => Set<Employee>();

        public DbSet<Project>  Projects => Set<Project>();

        public DbSet<HRUser> HRUsers => Set<HRUser>();
    }
}
