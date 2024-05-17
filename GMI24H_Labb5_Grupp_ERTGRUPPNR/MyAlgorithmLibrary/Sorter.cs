using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GMI24H_Labb5_Grupp_6.MyAlgorithmLibrary
{
    /// <summary>
    /// This class is used to implement the algorithms defined in the ISorter interface.
    /// When you have implemented the algorithms, you should be able to test them by instantiating
    /// a Sorter object and call the methods.
    /// </summary>
    class Sorter : ISorter
    {
        public void BubbleSort(int[] arr)
        {
            //Wikipedia. (5 Maj 2024). Bubble sort. https://en.wikipedia.org/wiki/Bubble_sort 
            //            procedure bubbleSort(A : list of sortable items)
            //    n:= length(A)
            //    repeat
            //        swapped := false
            //        for i := 1 to n - 1 inclusive do
            //                { if this pair is out of order }
            //            if A[i - 1] > A[i] then
            //                { swap them and remember something changed }
            //            swap(A[i - 1], A[i])
            //                swapped:= true
            //            end if
            //        end for
            //    until not swapped
            //end procedure
            int size = arr.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < size; i++)
                {
                    if (arr[i - 1] > arr[i])
                    {
                        int temp = arr[i - 1];
                        arr[i - 1] = arr[i];
                        arr[i] = temp;
                        swapped = true;
                    }
                }
                size--;
            } while (swapped);
        }


        /*
        Stasko, J., (1998). Heapsort. https://sites.cc.gatech.edu/classes/cs3158_98_fall/heapsort.html  
        Heapsort(A) {
           BuildHeap(A)
           for i <- length(A) downto 2 {
              exchange A[1] <-> A[i]
              heapsize <- heapsize -1
              Heapify(A, 1)
        }
        BuildHeap(A) {
           heapsize <- length(A)
           for i <- floor( length/2 ) downto 1
              Heapify(A, i)
        }

        Heapify(A, i) {
           le <- left(i)
           ri <- right(i)
           if (le<=heapsize) and (A[le]>A[i])
              largest <- le
           else
              largest <- i 
           if (ri<=heapsize) and (A[ri]>A[largest])
              largest <- ri
           if (largest != i) {
              exchange A[i] <-> A[largest]
              Heapify(A, largest)
           }
        }
        */
        public void HeapSort(int[] A)
        {
            BuildHeap(A);
            int heapsize = A.Length;

            for (int i = A.Length - 1; i >= 1; i--)
            {
                int temp = A[0];
                A[0] = A[i];
                A[i] = temp;
                heapsize--;
                Heapify(A, 0, heapsize);
            }
        }

        public void BuildHeap(int[] A)
        {
            int heapsize = A.Length;

            for (int i = (int)Math.Floor((double)A.Length / 2) - 1; i >= 0; i--)
            {
                Heapify(A, i, heapsize);
            }
        }

        public void Heapify(int[] A, int i, int heapsize)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < heapsize && A[left] > A[largest])
            {
                largest = left;
            }

            if (right < heapsize && A[right] > A[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                int temp = A[i];
                A[i] = A[largest];
                A[largest] = temp;
                Heapify(A, largest, heapsize);
            }
        }

        public void InsertionSort(int[] arr)
        {
            //Wikipedia. (29 December 2023). Insertion sort. https://en.wikipedia.org/wiki/Insertion_sort 
            //            i ← 1
            //while i < length(A)
            //    j ← i
            //    while j > 0 and A[j - 1] > A[j]
            //        swap A[j] and A[j - 1]
            //        j ← j - 1
            //    end while
            //    i ← i + 1
            //end while
            int i = 1;
            while (i< arr.Length)
            {
                int j = i;
                while((j>0) && (arr[j - 1] > arr[j]))
                {
                    int temp = arr[j];
                    arr[j] = arr[j-1];
                    arr[j-1]=temp;
                }
                i++;

            }

        }

        public void QuickSort(int[] arr, int low, int high)
        {
            //Wyss-Gallifent, J., (6 Mars 2024). CMSC 351: QuickSort. https://www.math.umd.edu/~immortal/CMSC351/notes/quicksort.pdf 
            if (low < high)
            {
                int resultPivotIndex = Partition(arr, low, high);
                QuickSort(arr, low, resultPivotIndex-1);
                QuickSort(arr, resultPivotIndex+1,high);
            }
        }
        private int Partition(int[] arr, int low, int high)
        {
            int pivotKey = arr[high];
            int t = low;
            for (int i = low; i < high; i++) // Loop from low to high-1
            {
                if (arr[i] <= pivotKey)
                {
                    int innerTemp = arr[t];
                    arr[t] = arr[i];
                    arr[i] = innerTemp;
                    t = t + 1;
                }
            }
            int temp = arr[t];
            arr[t] = arr[high];
            arr[high] = temp;
            return t;
        }

        public void SelectionSort(int[] arr)
        {
            //tutorialspoint. (u.å.a). Selection Sort Algorithm. https://www.tutorialspoint.com/data_structures_algorithms/selection_sort_algorithm.htm 
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int smallSub = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallSub])
                    {
                        smallSub = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[smallSub];
                arr[smallSub] = temp;
            }
        }
    }
}
