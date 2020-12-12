using System;

namespace StrategyPattern
{
    class QuickSortAlgo : ISortAlgo
    {
        public void SortData()
        {
            Console.WriteLine("Data Sorted using Quick Sort");
        }

    }
}