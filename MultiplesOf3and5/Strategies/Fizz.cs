using MultiplesOf3and5.Strategies.Interface;

namespace MultiplesOf3and5.Strategies
{
    //Concrete implementation of IFizzBuzz
    public class Fizz : IFizzBuzz
    {
        public bool Checker(int number)
        {
            return number % 3 == 0;
        }

        public string GetResult(int number)
        {
            return "Fizz";
        }
    }
}
