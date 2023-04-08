using Amazon.Lambda.APIGatewayEvents;
using System.Threading;
using System.Threading.Tasks;
using Flyingdarts.Persistence;
using MediatR;

public class $command$Handler : IRequestHandler<$command$, APIGatewayProxyResponse>
{
    public $command$Handler()
    {
    }
    public async Task<APIGatewayProxyResponse> Handle($command$ request, CancellationToken cancellationToken)
    {
        return new APIGatewayProxyResponse { StatusCode = 200 };
    }
}