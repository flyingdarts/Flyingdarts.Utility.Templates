using System;
using System.Threading;
using System.Threading.Tasks;
using Flyingdarts.Persistence;
using MediatR;

public class CreateRoomCommandHandler : IRequestHandler<(MediatR Request)>
{
    private readonly DynamoDbService _dynamoDbService;

    public CreateRoomCommandHandler(DynamoDbService dynamoDbService)
    {
        _dynamoDbService = dynamoDbService;
    }
    public async Task Handle((MediatR Request) request, CancellationToken cancellationToken)
    {
       
    }
}