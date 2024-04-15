using EntityFramework.Domain.Abstractions;

namespace EntityFramework.Domain.Models;
public class Category : Entity
{
    public required string Name { get; set; }

    public ICollection<LotCategory>? Lots { get; set; }
}