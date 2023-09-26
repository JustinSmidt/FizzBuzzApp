using MultiplesOf3and5.Strategies.Interface;

namespace MultiplesOf3and5.Strategies
{
    //Concrete implementation of IFizzBuzz
    public class Buzz : IFizzBuzz
    {
        public bool Checker(int number)
        {
            return number % 5 == 0;
        }

        public string GetResult(int number)
        {
            return $"Buzz {number}";
        }
    }
}
