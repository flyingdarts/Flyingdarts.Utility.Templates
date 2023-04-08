using Amazon.Lambda.APIGatewayEvents;
using Flyingdarts.Lambdas.Shared;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

public class InnerHandler
{
    private readonly IMediator _mediator;

    public InnerHandler()
    {
    }
    public InnerHandler(ServiceProvider serviceProvider)
    {
        _mediator = serviceProvider.GetRequiredService<IMediator>();
    }
    public async Task<APIGatewayProxyResponse> Handle(SocketMessage<$command$> request)
    {
        throw new NotImplementedException();
    }

     
}