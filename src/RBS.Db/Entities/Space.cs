namespace RBS.Db.Entities;

public class Space
{
    public int Id { get; set; }

    public Guid Guid { get; set; }

    public Location Location { get; set; }
}