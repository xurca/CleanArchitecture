﻿namespace Domain.Shared;

public abstract class Entity : IEquatable<Entity>
{
    protected Entity(Guid id) => Id = id;

    protected Entity() { }

    public Guid Id { get; private init; }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;

        if (obj.GetType() != GetType()) return false;

        if (obj is not Entity entity) return false;

        return entity.Id == Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode() * 33;
    }

    public bool Equals(Entity? other)
    {
        if (other is null) return false;

        if (other.GetType() != GetType()) return false;

        return other.Id == Id;
    }

    public static bool operator ==(Entity? first, Entity? second) => first is not null && second is not null && first.Equals(second);

    public static bool operator !=(Entity? first, Entity? second) => !(first == second);
}
