using Microsoft.TemplateEngine.Abstractions;

public class FlyingLambdaCommandParameter : ITemplateParameter
{
    public string Documentation => "The command to be executed.";

    public string Name => "command";

    public string DefaultValue => "";

    public bool IsName => false;

    public bool IsVariable => false;

    public IReadOnlyList<string> Choices => null;

    public string DataType => "string";

    public string DisplayName => "Command";
}
