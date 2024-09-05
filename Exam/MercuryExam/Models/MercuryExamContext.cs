using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MercuryExam.Models;

public partial class MercuryExamContext : DbContext
{
    public MercuryExamContext()
    {
    }

    public MercuryExamContext(DbContextOptions<MercuryExamContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=MercuryExam;User ID=mecury;Password=123456;TrustServerCertificate=true");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Myoffice_ACPD>()
            .ToTable("Myoffice_ACPD", "MercuryExam")
            .HasKey(acpd => acpd.AcpdSid);

        modelBuilder.Entity<Myoffice_ExcuteionLog>()
            .ToTable("Myoffice_ExcuteionLog", "MercuryExam")
            .HasKey(officeLog => officeLog.DeLog_AuthID);
    }

    public DbSet<Myoffice_ACPD> Myoffice_ACPDs { get; set; }
    public DbSet<Myoffice_ExcuteionLog> Myoffice_ExcuteionLogs { get; set; }
}
