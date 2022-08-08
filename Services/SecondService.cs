namespace DotnetDependencyInjectionLifecycle.Services
{
    public class SecondService
    {
        private readonly FirstService _firstService;

        public SecondService(FirstService firstService)
        {
            _firstService = firstService;
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid FirstServiceId => _firstService.Id;
    }
}
