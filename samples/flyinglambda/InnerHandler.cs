using Amazon.Lambda.APIGatewayEvents;
using Flyingdarts.Lambdas.Shared;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
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
    public async Task<APIGatewayProxyResponse> Handle(SocketMessage<OnConnectCommand> request)
    {
        if (request?.Message is null)
            throw new BadRequestException("Unable to parse request.", typeof(OnConnectCommand));
        
        return await _mediator.Send(request.Message);
    }
}