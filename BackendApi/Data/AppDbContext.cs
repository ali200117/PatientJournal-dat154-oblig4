using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models;

namespace BackendApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<PatientCase> PatientCases { get; set; }

    public DbSet<VitalSigns> VitalSigns { get; set; }

    public DbSet<Intervention> Interventions { get; set; }

    public DbSet<TimelineEvent> TimelineEvents { get; set; }
}