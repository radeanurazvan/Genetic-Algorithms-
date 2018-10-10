using System;
using HeuristicFunctionMinimum.Function;
using HeuristicFunctionMinimum.Strategies;

namespace HeuristicFunctionMinimum.Heuristic
{
    public class HeuristicRandomMinimumBuilder
    {
        private int randomTriesCount;
        private double step;
        private FunctionStrategy strategy;

        public HeuristicRandomMinimumBuilder WithTries(int tries)
        {
            if (tries < 0)
            {
                throw new ArgumentException("The heuristic random minimum builder should try at least once!");
            }

            this.randomTriesCount = tries;

            return this;
        }

        public HeuristicRandomMinimumBuilder WithStep(double step)
        {
            this.step = step;

            return this;
        }


        public HeuristicRandomMinimumBuilder WithStrategy(FunctionStrategy strategy)
        {
            this.strategy = strategy;

            return this;
        }

        public double Build()
        {
            var currentMinimum = double.MaxValue;

            for (var currentTry = 1.0; currentTry <= randomTriesCount; currentTry += step)
            {
                var functionParameters =
                    DomainHelper.RandomNumbersInDomainRange(strategy.GetDomain(), strategy.GetDimension());

                var functionValue = strategy.GetValue(functionParameters);

                currentMinimum = TestMinimum(currentMinimum, functionValue);
            }

            return currentMinimum;
        }

        private double TestMinimum(double minimum, double currentValue)
        {
            if (currentValue < minimum)
            {
                return currentValue;
            }

            return minimum;
        }
    }
}