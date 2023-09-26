namespace MultiplesOf3and5.Strategies.StrategiesService.Interface
{
    public interface IStrategyEvaluator
    {
        //I want to inject the Interface of StrategyEvaluator into controllers construtor to adhere to SOLID,
        //in which high level modules (controller) should be dependent on abstractions instead of concrete implementations
        string Evaluate(int number);
    }
}
