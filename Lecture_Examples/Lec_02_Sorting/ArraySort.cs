using System;


namespace Lec_02_Sorting
{
    internal class ArraySort
    {
        int[] arr;

        public ArraySort(int length)
        {
            arr = new int[length];
        }

        public void RandomFill()
        {
            Random random = new Random();
            for (int i = 0; i < this.arr.Length; i++)
            {
                this.arr[i] = random.Next(0, 100);
            }
        }

        public void Print()
        {
            for (int i = 0; i < this.arr.Length; i++)
            {
                Console.Write(this.arr[i] + " ");
            }
            Console.WriteLine();
        }

        public void SelectionSortIterative()
        {
            for (int i = 0; i < this.arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (this.arr[i] > this.arr[j])
                    {
                        int temp = this.arr[i];
                        this.arr[i] = this.arr[j];
                        this.arr[j] = this.arr[i];
                    }
                }
            }
        }
    }

}
