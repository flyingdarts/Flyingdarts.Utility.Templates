using Amazon.Lambda.APIGatewayEvents;
using System;
using System.Threading;
using System.Threading.Tasks;
using Flyingdarts.Persistence;
using MediatR;

public class $command$Handler : IRequestHandler<$command$, APIGatewayProxyResponse>
{
    private readonly DynamoDbService _dynamoDbService;

    public $command$Handler(DynamoDbService dynamoDbService)
    {
        _dynamoDbService = dynamoDbService;
    }
    public async Task<APIGatewayProxyResponse> Handle($command$ request, CancellationToken cancellationToken)
    {
        return new APIGatewayProxyResponse { StatusCode = 200 };
    }
}