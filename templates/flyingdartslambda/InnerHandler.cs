using Amazon.Lambda.APIGatewayEvents;
using Flyingdarts.Lambdas.Shared;
using Flyingdarts.Shared;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

/// <summary>
/// Represents the inner handler for processing APIGatewayProxyRequest.
/// </summary>
public class InnerHandler
{
    private readonly IMediator _mediator;

    /// <summary>
    /// Initializes a new instance of the InnerHandler class.
    /// </summary>
    public InnerHandler()
    {
    }

    /// <summary>
    /// Initializes a new instance of the InnerHandler class with a service provider.
    /// </summary>
    /// <param name="serviceProvider">The service provider used to resolve dependencies.</param>
    public InnerHandler(ServiceProvider serviceProvider)
    {
        _mediator = serviceProvider.GetRequiredService<IMediator>();
    }

    /// <summary>
    /// Handles the socket message request and returns the APIGatewayProxyResponse.
    /// </summary>
    /// <param name="request">The socket message request containing the $command$.</param>
    /// <returns>The APIGatewayProxyResponse.</returns>
    public async Task<APIGatewayProxyResponse> Handle(SocketMessage<$command$> request)
    {
        // Check if the request or its message is null
        if (request?.Message is null)
            throw new BadRequestException("Unable to parse request.", typeof($command$));

        // Send the message to the mediator for further processing
        return await _mediator.Send(request.Message);
    }
}