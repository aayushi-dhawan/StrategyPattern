using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AlgoStrategy obj = new AlgoStrategy(new MergeSortAlgo());
            obj.SortData();

            obj = new AlgoStrategy(new QuickSortAlgo());
            obj.SortData();
        }
    }
}
