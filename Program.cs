using DotnetDependencyInjectionLifecycle.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<FirstService>();
builder.Services.AddScoped<SecondService>();
builder.Services.AddTransient<ThirdService>();

var app = builder.Build();

app.MapGet(pattern: "/", handler:
    (FirstService firstService,
    SecondService secondService,
    ThirdService thirdService) => new
    {
        Id = Guid.NewGuid(),
        FirstServiceId = firstService.Id,
        SecondServiceId = new
        {
            Id = secondService.Id,
            FirstServiceId = secondService.FirstServiceId
        },
        ThirdServiceId = new
        {
            Id = thirdService.Id,
            FirstServiceId = thirdService.FirstServiceId,
            SecondServiceId = thirdService.SecondServiceId
        }
    });

app.Run();
