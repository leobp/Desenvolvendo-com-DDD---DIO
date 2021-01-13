using Flunt.Notifications;

namespace Domain.Entities
{
    public abstract class BaseEntity<TKeyType> : Notifiable
    {
        protected BaseEntity(TKeyType id = default)
        {
            Id = id;
        }

        public virtual TKeyType Id { get; }
    }
}