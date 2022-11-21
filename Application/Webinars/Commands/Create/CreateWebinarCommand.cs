namespace Application.Webinars.Commands.Create
{
    public sealed record CreateWebinarCommand(string Name, DateTime ScheduledOn) : ICommand<Guid>;
}
