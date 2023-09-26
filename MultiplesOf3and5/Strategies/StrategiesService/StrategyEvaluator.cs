using MultiplesOf3and5.Strategies.Interface;
using MultiplesOf3and5.Strategies.StrategiesService.Interface;

namespace MultiplesOf3and5.Strategies.StrategiesService
{
    
    public class StrategyEvaluator: IStrategyEvaluator
    {
        private readonly IEnumerable<IFizzBuzz> fizzBuzzes;

        //Leverages the multiple strategies without being tightly coupled to any specific one
        public StrategyEvaluator(IEnumerable<IFizzBuzz> fizzBuzzes) 
        {
            this.fizzBuzzes = fizzBuzzes;
        }

        //Evaluates numbers based on the provided strategies
        //Order of strategy registration Matters, thus in Program, FizzBuzz comes first, as this is going to 
        //iterate over each strategy in the order they are provided
        public string Evaluate(int number)
        {
            foreach(var item in fizzBuzzes)
            {
                if(item.Checker(number))
                {
                    return item.GetResult(number);
                }
            }

            return number.ToString();
        }

    }
}
