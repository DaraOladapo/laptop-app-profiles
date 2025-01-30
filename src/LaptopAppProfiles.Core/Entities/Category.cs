namespace LaptopAppProfiles.Core.Entities;

public class Category
{
    public Guid CategoryID { get; set; }
    public required string Name { get; set; }
    public virtual required ICollection<App> Apps { get; set; }
}
