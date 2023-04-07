public class FlyingLambdaParametersTemplate : ITemplateInfo
{
    public string Identity => "Flying.Lambda.Template";

    public string Name => "Flyingdarts Lambda template.";

    public string Description => "A template that generatese a boilerplate lambda project tailored for Flyingdarts.";

    public IReadOnlyList<ITemplateParameter> Parameters => new[]
    {
        new FlyingLambdaCommandParameter()
    };
}
