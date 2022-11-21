using Domain.Exceptions.Base;

namespace Domain.Exceptions
{
    public sealed class WebinarNotFoundException : NotFoundException
    {
        public WebinarNotFoundException(Guid id) : base($"The webinar with the identifier {id} was not found.")
        {

        }
    }
}
