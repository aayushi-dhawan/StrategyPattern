using System;

namespace StrategyPattern
{
    class MergeSortAlgo : ISortAlgo
    {
        public void SortData()
        {
            Console.WriteLine("Data Sorted using Merge Sort");
        }

    }
}