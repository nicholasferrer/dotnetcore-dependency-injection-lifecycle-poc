namespace DotnetDependencyInjectionLifecycle.Services
{
    public class ThirdService
    {
        private readonly FirstService _firstService;
        private readonly SecondService _secondService;

        public ThirdService(FirstService firstService, SecondService secondService)
        {
            _firstService = firstService;
            _secondService = secondService;
        }
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid FirstServiceId => _firstService.Id;
        public Guid SecondServiceId => _secondService.Id;
    }
}
