using Domain.Entities;

namespace Domain.Abstractions
{
    public interface IWebinarRepository
    {
        void Insert(Sample webinar);
    }
}
