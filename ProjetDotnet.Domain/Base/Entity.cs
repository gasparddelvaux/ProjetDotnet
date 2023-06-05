namespace ProjetDotnet.Domain.Base;

public class Entity
{
    public Guid Id { get; init; } = Guid.NewGuid();
}