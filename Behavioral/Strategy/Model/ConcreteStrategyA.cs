using System;
using Strategy.Interfacee;

namespace Strategy.Model
{
    public class ConcreteStrategyA:IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }
}
