using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Soft_Landing.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Landing.DAL.Contexts;

public class AppDbContext :DbContext
{
    private readonly string _connectionstring = "Server=DESKTOP-GTVND9D;Database=SoftLandingDB;Trusted_Connection=True;TrustServerCertificate=True";
    public DbSet<StaffModel> StaffModels { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionstring);
        base.OnConfiguring(optionsBuilder);
    }

  

}
