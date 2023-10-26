using Mike.Domain.ValueObjects;

namespace Mike.Domain.Entities
{
    public class Customer : Entity
    {
        public Name Name { get; private set; }
    }
}
