
using System;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using FluentValidation;

public static class ServiceFactory
{
    public static ServiceProvider GetServiceProvider()
    {
        var configuration = new ConfigurationBuilder()
            .AddSystemsManager($"/{System.Environment.GetEnvironmentVariable("EnvironmentName")}/Application")
            .Build();
        
        var services = new ServiceCollection();
        services.AddDefaultAWSOptions(configuration.GetAWSOptions());
        services.AddAWSService<IAmazonDynamoDB>(configuration.GetAWSOptions("DynamoDb"));
        services.AddOptions<ApplicationOptions>();
        services.AddTransient<IDynamoDBContext, DynamoDBContext>();
        services.AddValidatorsFromAssemblyContaining<$command$Validator>();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof($command$).Assembly));
        return services.BuildServiceProvider();
    }
}