using Flunt.Notifications;
using System;

namespace Mike.Domain.Entities
{
    public abstract class Entity : Notifiable
    {
        public int Id { get; private set; }
    }
}
