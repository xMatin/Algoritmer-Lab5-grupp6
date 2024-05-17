using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GMI24H_Labb5_Grupp_6.MyAlgorithmLibrary
{
    /// <summary>
    /// This class is used to implement the algorithms defined in the ISearcher interface.
    /// When you have implemented the algorithms, you should be able to test them by instantiating
    /// a Searcher object and call the methods.
    /// </summary>
    public class Searcher : ISearcher
    {
        public int BinarySearch(int[] array, int target)
        {
            //Wikipedia (16 Maj, 2024). Binary search algorithm. https://en.wikipedia.org/wiki/Binary_search_algorithm 
            /*
            function binary_search(A, n, T) is
                L := 0
                R:= n − 1
                while L ≤ R do
                        m:= floor((L + R) / 2)
                    if A[m] < T then
                        L := m + 1
                    else if A[m] > T then
                        R := m − 1
                    else:
                        return m
                return unsuccessful
            */

            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                if (array[middle] == target)
                    return middle;
                else if (array[middle] < target)
                    left = middle + 1;
                else
                    right = middle - 1;
            }
            return -1;
        }

        public static int Min(int a, int b)
        {
            return a < b ? a : b;
        }
        public int ExponentialSearch(int[] array, int target)
        {
            //tutorialspoint. (u.å.b). Exponential search algorithm. https://www.tutorialspoint.com/data_structures_algorithms/exponential_search.htm 
            /*
            Begin
               m := pow(2, k) // m is the block size
               start := 1
               low := 0
               high := size – 1 // size is the size of input
               if array[0] == key
                  return 0
               while array[m] <= key AND m < size do
                  start := start + 1
                  m := pow(2, start)
                  while low <= high do:
                     mid = low + (high - low) / 2
                     if array[mid] == x
                        return mid
                     if array[mid] < x
                        low = mid + 1
                     else
                        high = mid - 1
               done
               return invalid location
            End
            */
            int size = array.Length;
            if (array[0] == target)
                return 0;
            int m = 1;
            while (m < size && array[m] <= target)
            {
                m *= 2;
            }
            int low = 0;
            int high = Min(m, size) - 1;
            while ( low <= high)
            {
                int mid = low + (high - low) / 2;
                if (array[mid] == target)
                    return mid;
                else if (array[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }
        public int InterpolationSearch(int[] array, int target)
        {
            //tutorialspoint. (u.å.c). Interpolation search algorithm. https://www.tutorialspoint.com/data_structures_algorithms/interpolation_search_algorithm.htm 
            /*
            A → Array list
            N → Size of A
            X → Target Value
            Procedure Interpolation_Search()
               Set Lo → 0
               Set Mid → -1
               Set Hi → N-1
               While X does not match
                  if Lo equals to Hi OR A[Lo] equals to A[Hi]
                     EXIT: Failure, Target not found
                  end if
                  Set Mid = Lo + ((Hi - Lo) / (A[Hi] - A[Lo])) * (X - A[Lo])
                  if A[Mid] = X
                     EXIT: Success, Target found at Mid
                  else
                     if A[Mid] < X
                        Set Lo to Mid+1
                     else if A[Mid] > X
                        Set Hi to Mid-1
                     end if
                  end if
               End While
            End Procedure
            */
            int n = array.Length;
            int low = 0;
            int high = n - 1;
            while (array[low] != array[high] && target >= array[low] && target <= array[high])
            {
                int mid = low + ((target - array[low]) * (high - low) / (array[high] - array[low]));
                if (array[mid] == target)
                    return mid;
                else if (array[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            if (array[low] == target)
                return low;
            else
                return -1;
        }
        public int JumpSearch(int[] array, int target)
        {
            //tutorialspoint. (u.å.d). Jump search algorithm. https://www.tutorialspoint.com/Jump-Search 
            /*
            Begin
                blockSize := √size
                start := 0
                end := blockSize
                while array[end] <= key AND end < size do
                    start := end
                    end := end + blockSize
                    if end > size – 1 then
                        end := size
                done
                for i := start to end -1 do
                    if array[i] = key then
                        return i
                done
                return invalid location
            End
             */
            int size = array.Length;
            int blockSize = 1;
            while (blockSize * blockSize < size)
            {
                blockSize++;
            }
            int start = 0;
            int end = blockSize;
            while (end < size && array[end] <= target)
            {
                start = end;
                end += blockSize;
                if (end > size - 1)
                    end = size;
            }
            for (int i = start; i < end; i++)
            {
                if (array[i] == target)
                    return i;
            }
            return -1;


        }
        public int LinearSearch(int[] array, int target)
        {
            //tutorialspoint. (u.å.e). Linear search algorithm. https://www.tutorialspoint.com/data_structures_algorithms/linear_search_algorithm.htm 
            /*
                procedure linear_search(list, value)
                   for each item in the list
                      if match item == value
                         return the item's location
                      end if
                   end for
                end procedure
            */
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                    return i;
            }
            return -1;
        }
    }
}

