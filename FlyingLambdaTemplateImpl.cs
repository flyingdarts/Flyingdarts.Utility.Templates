public class FlyingLambdaTemplateImpl : ITemplate
{
    public IHostSpecificData Configure(IEngineEnvironmentSettings environmentSettings, IHostSpecificData hostSpecificData)
    {
        return hostSpecificData;
    }

    public void Evaluate(ITemplateEngineHost host, IVariableCollection variables, IParameterSet parameters, IComponentManager componentManager)
    {
        var command = parameters.GetValueOrDefault("command")?.ToString() ?? "";
        host.LogMessage($"The command is {command}");
    }
}