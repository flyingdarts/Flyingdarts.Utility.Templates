using Amazon.Lambda.APIGatewayEvents;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

public class OnConnectCommandHandler : IRequestHandler<OnConnectCommand, APIGatewayProxyResponse>
{
    public Task<APIGatewayProxyResponse> Handle(OnConnectCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new APIGatewayProxyResponse { StatusCode = 200 });
    }
}
