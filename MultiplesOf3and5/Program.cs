using MultiplesOf3and5.Strategies;
using MultiplesOf3and5.Strategies.Interface;
using MultiplesOf3and5.Strategies.StrategiesService;
using MultiplesOf3and5.Strategies.StrategiesService.Interface;

namespace MultiplesOf3and5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Order matters. FizzBuzz comes first as it is first strategy to be checked.
            //If it is not first, then it wont be dislayed, as other conditions will first be checked, such
            //as the multiple of 3. If it is true, then Fizz will be displayed, but it wont go further, leaving
            //FizzBuzz to be unchecked, as Evaluator does not reach it first. 
            //Registering Fizz,Buzz,FizzBuzz for DI
            builder.Services.AddTransient<IFizzBuzz, FizzBuzz>();
            builder.Services.AddTransient<IFizzBuzz, Fizz>();
            builder.Services.AddTransient<IFizzBuzz, Buzz>();

            //Registering FizzBuzz serive
            builder.Services.AddTransient<IStrategyEvaluator, StrategyEvaluator>();



            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }



            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}