
using System;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using FluentValidation;

public static class ServiceFactory
{
    public static ServiceProvider GetServiceProvider()
    {
        var services = new ServiceCollection();
        services.AddValidatorsFromAssemblyContaining<$command$Validator>();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof($command$).Assembly));
        return services.BuildServiceProvider();
    }
}