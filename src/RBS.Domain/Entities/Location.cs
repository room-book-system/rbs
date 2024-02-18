using NetTopologySuite.Geometries;

namespace RBS.Domain.Entities;

public class Location
{
    public int Id { get; set; }

    public string? Name { get; set; }
    public Point? Coordinates { get; set; }
}