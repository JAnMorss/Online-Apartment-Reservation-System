namespace OnlineApartmentReservationSystem.Shared.Abstractions.Domain
{
    public abstract class AggregateRoot<T>
    {
        public T Id { get; protected set; }
        public int Version { get; protected set; }
        public IEnumerable<IDomainEvent> Events => _events;

        private readonly List<IDomainEvent> _events = new();
        private bool _versionIncremented;

        public IReadOnlyList<IDomainEvent> GetDomainEvents()
            => _events.ToList();

        public void ClearDomainEvents() => _events.Clear();

        protected void IncrementVersion()
        {
            if (_versionIncremented)
            {
                return;
            }

            Version++;
            _versionIncremented = true;
        }

        protected void RaiseDomainEvent(IDomainEvent domainEvent)
        {
            if (!_events.Any() && !_versionIncremented)
            {
                Version++;
                _versionIncremented = true;
            }

            _events.Add(domainEvent);
        }
    }
}
