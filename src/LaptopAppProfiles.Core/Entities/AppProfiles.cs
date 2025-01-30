using System.ComponentModel;

namespace LaptopAppProfiles.Core.Entities;

public class App
{
    public Guid ProfileID { get; set; }
    public required string Name { get; set; }
    public virtual required ICollection<Category> Categories { get; set; }
}