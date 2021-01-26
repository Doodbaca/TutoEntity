using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TutoEntity
{
    class VaccinContext :DbContext
    {
        public DbSet<Vaccin> Vaccins { get; set; }
        public DbSet<TypeVaccin> TypesVaccin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Data Source = deptinfo420; Initial Catalog = VaccinMathieu; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}