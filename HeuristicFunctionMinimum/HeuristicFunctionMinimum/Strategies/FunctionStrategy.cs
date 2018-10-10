using System.Collections.Generic;
using HeuristicFunctionMinimum.Function;

namespace HeuristicFunctionMinimum.Strategies
{
    public abstract class FunctionStrategy
    {
        public abstract Domain GetDomain();

        public abstract DimensionDefinition GetDimension();

        public abstract double GetValue(IEnumerable<double> tuple);
    }
}