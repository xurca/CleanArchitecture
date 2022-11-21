using Domain.Primitives;

namespace Domain.Entities;

public sealed class Webinar : Entity
{
    public Webinar(Guid id, string name, DateTime scheduledOn)
    {
        Id = id;
        Name = name;
        ScheduledOn = scheduledOn;
    }

    private Webinar() { }

    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public DateTime ScheduledOn { get; private set; }
}
