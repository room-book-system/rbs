using Microsoft.EntityFrameworkCore;
using RBS.Domain.Entities;

namespace RBS.Application.Common;

public interface IRbsContext
{
    public DbSet<Space> Spaces { get; set; }

    public DbSet<Location> Locations { get; set; }
}