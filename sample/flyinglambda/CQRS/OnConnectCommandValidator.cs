using FluentValidation;

public class OnConnectCommandValidator : AbstractValidator<OnConnectCommand>
{
    public OnConnectCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
    }
}