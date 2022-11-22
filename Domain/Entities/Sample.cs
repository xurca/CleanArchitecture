using Domain.Shared;

namespace Domain.Entities;

public sealed class Sample : Entity
{
    public Sample(Guid id, string name, DateTime scheduledOn)
    {
        Id = id;
        Name = name;
        ScheduledOn = scheduledOn;
    }

    private Sample() { }

    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public DateTime ScheduledOn { get; private set; }
}
