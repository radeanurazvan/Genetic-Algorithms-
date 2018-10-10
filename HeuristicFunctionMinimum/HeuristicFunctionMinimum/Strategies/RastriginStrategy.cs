using System.Collections.Generic;
using System.Linq;
using HeuristicFunctionMinimum.Function;
using static System.Math;

namespace HeuristicFunctionMinimum.Strategies
{
    public class RastriginStrategy : FunctionStrategy
    {
        public override Domain GetDomain()
        {
            return new UniversalDomain(-5.12, 5.12);
        }

        public override DimensionDefinition GetDimension()
        {
            return new DimensionDefinition(10);
        }

        public override double GetValue(IEnumerable<double> tuple)
        {
            return 10 * GetDimension() + tuple.Sum(x => SingleItemSumValue(x));
        }

        private static double SingleItemSumValue(double x)
        {
            var cosArg = 2 * PI * x;
            var cosValue = Cos(cosArg);
            var square = x * x;

            return square - 10.0 * cosValue;
        }
    }
}