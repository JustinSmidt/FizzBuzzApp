using Microsoft.AspNetCore.Mvc;
using MultiplesOf3and5.Models;
using MultiplesOf3and5.Strategies.StrategiesService;
using MultiplesOf3and5.Strategies.StrategiesService.Interface;
using System.Diagnostics;


namespace MultiplesOf3and5.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStrategyEvaluator strategyEvaluator;

        //Has dependency on IStrategyEvaluator, an Abstraction
        public HomeController(IStrategyEvaluator strategyEvaluator)
        {
            this.strategyEvaluator = strategyEvaluator;
        }

        public IActionResult Index()
        {
            FizzBuzzModel model = new FizzBuzzModel();

            //Each number (1-100) is evaluated using strategyEvaluator, and then adds the result to FizzBuzzResults
            for(int i = 1; i <= 100; i++)
            {
                model.FizzBuzzResults.Add(strategyEvaluator.Evaluate(i));
            }

            //Populated model is passed to view
            return View(model);
        }
        
    }
}