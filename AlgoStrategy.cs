using System;

namespace StrategyPattern
{
    class AlgoStrategy 
    {
        ISortAlgo obj;
        public AlgoStrategy(ISortAlgo o)
        {
            this.obj = o;
        }

        public void SortData()
        {
            this.obj.SortData();
        }

    }
}