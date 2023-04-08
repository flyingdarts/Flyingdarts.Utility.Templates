using System;
using Amazon.Lambda.APIGatewayEvents;
using MediatR;

public class OnConnectCommand : IRequest<APIGatewayProxyResponse>
{
    public Guid UserId { get; set; }
}