using MedExUpdated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace MedExProject.DAL
{
    public class MedExContext : DbContext
    {
        public MedExContext() : base("MedExContext")
        {

        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<CompletedCert> Doctors_Certificates { get; set; }
    }
}