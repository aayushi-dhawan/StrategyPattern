using System;

namespace StrategyPattern
{
    class BubbleSortAlgo : ISortAlgo
    {
        public void SortData()
        {
            Console.WriteLine("Data Sorted using Bubble Sort");
        }
    }
}