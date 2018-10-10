using System.Collections.Generic;
using System.Linq;
using HeuristicFunctionMinimum.Function;
using static System.Math;

namespace HeuristicFunctionMinimum.Strategies
{
    public class SchwefelStrategy : FunctionStrategy
    {
        public override Domain GetDomain()
        {
            return new UniversalDomain(-500, 500);
        }

        public override DimensionDefinition GetDimension()
        {
            return new DimensionDefinition(8);
        }

        public override double GetValue(IEnumerable<double> tuple)
        {
            return tuple.Sum(x => SingleItemExpressionValue(x));
        }

        private static double SingleItemExpressionValue(double x)
        {
            var sinArg = Sqrt(x);
            var sinValue = Sin(sinArg);

            return -x * sinValue;
        }
    }
}