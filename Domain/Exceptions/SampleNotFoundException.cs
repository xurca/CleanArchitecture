using Domain.Entities;
using Domain.Exceptions.Base;

namespace Domain.Exceptions
{
    public sealed class SampleNotFoundException : NotFoundException
    {
        public SampleNotFoundException(Guid id) : base($"The {nameof(Sample)} with the identifier {id} was not found.")
        {

        }
    }
}
