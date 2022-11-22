using Domain.Shared;

namespace Domain.Entities;

public sealed class Sample : Entity
{
    public Sample(Guid id, string name, DateTime scheduledOn)
        : base(id)
    {
        Id = id;
        Name = name;
        ScheduledOn = scheduledOn;
    }

    private Sample() { }

    public string Name { get; private set; }

    public DateTime ScheduledOn { get; private set; }
}
