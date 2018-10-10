using System;
using HeuristicFunctionMinimum.Heuristic;
using HeuristicFunctionMinimum.Strategies;

namespace HeuristicFunctionMinimum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var minimumBuilder = new HeuristicRandomMinimumBuilder();

            var deJongValue = minimumBuilder
                .WithTries(100)
                .WithStep(0.01)
                .WithStrategy(new DeJongStrategy())
                .Build();
            DisplayResult("DeJong", deJongValue);

            var schwefelValue = minimumBuilder
                .WithTries(150)
                .WithStep(0.001)
                .WithStrategy(new SchwefelStrategy())
                .Build();
            DisplayResult("Schwefel", schwefelValue);

            var rastriginValue = minimumBuilder
                .WithTries(200)
                .WithStep(0.0001)
                .WithStrategy(new RastriginStrategy())
                .Build();
            DisplayResult("Rastrigin", rastriginValue);

            var sixHumpValue = minimumBuilder
                .WithTries(250)
                .WithStep(0.0001)
                .WithStrategy(new SixHumpStrategy())
                .Build();
            DisplayResult("SixHump", sixHumpValue);
        }

        private static void DisplayResult(string strategyName, double value)
        {
            Console.WriteLine($"Today's minimum for {strategyName} is {value}");
        }
    }
}
