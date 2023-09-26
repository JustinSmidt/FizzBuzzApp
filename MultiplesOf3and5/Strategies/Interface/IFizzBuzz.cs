namespace MultiplesOf3and5.Strategies.Interface
{
    //I am using the strategy pattern
    public interface IFizzBuzz
    {
        
        //Checks to see if number is a Fizz, Buzz or a FizzBuzz based on mathematical implementations
        bool Checker(int number);

        //Returns necessary output(Fizz, Buzz, FizzBuzz based on Checker)
        string GetResult(int number);
    }
}
