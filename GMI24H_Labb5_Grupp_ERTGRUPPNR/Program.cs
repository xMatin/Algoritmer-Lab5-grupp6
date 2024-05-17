using GMI24H_Labb5_Grupp_6;
using GMI24H_Labb5_Grupp_6.MyAlgorithmLibrary;
using System.Diagnostics;
using System.IO;


/// <summary>
/// NOTE: You are by no means obligated to use this project structure. It is just a suggestion. If you want to create
/// your own project from scratch, you are most welcome to do so.
/// 
/// In the Program class you have the Main methods which is the starting point of any program which I am sure that you
/// already are aware of. 
/// 
/// Please write comments in your own code for specific test cases or other things that you want to show.
/// It is ok to write your code in English and your comments in Swedish. However, do not mix Enlish and Swedish IN THE CODE.
/// 
/// It is very much up to you how you decide to organize your work so do not feel obligated to use the structure provided in this template.
///
/// Experiment and have fun! 
/// 
/// Best of luck! /Elin
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {

        //You can create arrays to test your sorting algorithms and you can create
        //a sorted array and an element to search for to test your searching algorithms. You have some sample data in the MyData.cs file that you can use.
        //but you are of course free to experiment with even larger data sets (in fact, this might be necessary to measure the performance of your algorithms).
        MyData data = new();

        //Since the methods in the Sorter and Searcher classes are not static, you need to create an object of each class
        //in order to call the methods which consist your algorithms.
        Sorter sorter = new();
        Searcher searcher = new();

        // The BubbleSort method of the Sorter class is not yet implemented,
        // the method call below is just for reference on how you
        //can call the method and pass the sample data provided in the MyData class.
        int[] arraySearchSortSortedTestCase1 = data.SortedNumSmallSmallRange;
        int[] arraySearchSortSortedTestCase2 = data.SortedNumSmallLargeRange;
        int[] arraySearchSortSortedTestCase3 = data.SortedNumMediumSmallRange;
        int[] arraySearchSortSortedTestCase4 = data.SortedNumMediumLargeRange;
        int[] arraySearchSortSortedTestCase5 = data.SortedNumLargeSmallRange;
        int[] arraySearchSortSortedTestCase6 = data.SortedNumLargeLargeRange;


        int[] arraySortRandomTestCase1 = data.RandomNumSmallSmallRange; 
        int[] arraySortRandomTestCase2 = data.RandomNumSmallLargeRange;
        int[] arraySortRandomTestCase3 = data.RandomNumMediumSmallRange;
        int[] arraySortRandomTestCase4 = data.RandomNumMediumLargeRange;
        int[] arraySortRandomTestCase5 = data.RandomNumLargeSmallRange;
        int[] arraySortRandomTestCase6 = data.RandomNumLargeLargeRange;

        int[] arraySortReverseSortedTestCase1 = data.ReverseSortedNumSmallSmallRange; 
        int[] arraySortReverseSortedTestCase2 = data.ReverseSortedNumSmallLargeRange;
        int[] arraySortReverseSortedTestCase3 = data.ReverseSortedNumMediumSmallRange;
        int[] arraySortReverseSortedTestCase4 = data.ReverseSortedNumMediumLargeRange;
        int[] arraySortReverseSortedTestCase5 = data.ReverseSortedNumLargeSmallRange;
        int[] arraySortReverseSortedTestCase6 = data.ReverseSortedNumLargeLargeRange;

        int[] arraySortNearlySortedTestCase1 = data.NearlySortedNumSmallSmallRange; 
        int[] arraySortNearlySortedTestCase2 = data.NearlySortedNumSmallLargeRange;
        int[] arraySortNearlySortedTestCase3 = data.NearlySortedNumMediumSmallRange;
        int[] arraySortNearlySortedTestCase4 = data.NearlySortedNumMediumLargeRange;
        int[] arraySortNearlySortedTestCase5 = data.NearlySortedNumLargeSmallRange;
        int[] arraySortNearlySortedTestCase6 = data.NearlySortedNumLargeLargeRange;


       // sorter.BubbleSort(arraySearchSortSortedTestCase1); // <-- implement the methods from ISorter in the Sorter class in order to use them and passing the previously initialized array as an argument to the sorting method we want to test...

        //To be able to measure how long it takes to run an algorithm, you can use
        //The Stopwatch and the TimeSpan classes.
        string csvSearchFilePath = "../../../search_results.csv";
        string csvSortFilePath = "../../../sort_results.csv";

        TimeSpan totalTimeBinarySearch = TimeSpan.Zero;
        TimeSpan totalTimeLinearSearch = TimeSpan.Zero;

        var binaryCase1Results = TestSearchAlgorithm(searcher.BinarySearch, arraySearchSortSortedTestCase1, 100);
        WriteToFile("binaryCase1", binaryCase1Results, csvSearchFilePath);
        var binaryCase2Results = TestSearchAlgorithm(searcher.BinarySearch, arraySearchSortSortedTestCase2, 1000);
        WriteToFile("binaryCase2", binaryCase2Results, csvSearchFilePath);
        var binaryCase3Results = TestSearchAlgorithm(searcher.BinarySearch, arraySearchSortSortedTestCase3, 100);
        WriteToFile("binaryCase3", binaryCase3Results, csvSearchFilePath);
        var binaryCase4Results = TestSearchAlgorithm(searcher.BinarySearch, arraySearchSortSortedTestCase4, 1000);
        WriteToFile("binaryCase4", binaryCase4Results, csvSearchFilePath);
        var binaryCase5Results = TestSearchAlgorithm(searcher.BinarySearch, arraySearchSortSortedTestCase5, 100);
        WriteToFile("binaryCase5", binaryCase5Results, csvSearchFilePath);
        var binaryCase6Results = TestSearchAlgorithm(searcher.BinarySearch, arraySearchSortSortedTestCase6, 1000);
        WriteToFile("binaryCase6", binaryCase6Results, csvSearchFilePath);

        var linearCase1Results = TestSearchAlgorithm(searcher.LinearSearch, arraySearchSortSortedTestCase1, 100);
        WriteToFile("linearCase1", linearCase1Results, csvSearchFilePath);
        var linearCase2Results = TestSearchAlgorithm(searcher.LinearSearch, arraySearchSortSortedTestCase2, 1000);
        WriteToFile("linearCase2", linearCase2Results, csvSearchFilePath);
        var linearCase3Results = TestSearchAlgorithm(searcher.LinearSearch, arraySearchSortSortedTestCase3, 100);
        WriteToFile("linearCase3", linearCase3Results, csvSearchFilePath);
        var linearCase4Results = TestSearchAlgorithm(searcher.LinearSearch, arraySearchSortSortedTestCase4, 1000);
        WriteToFile("linearCase4", linearCase4Results, csvSearchFilePath);
        var linearCase5Results = TestSearchAlgorithm(searcher.LinearSearch, arraySearchSortSortedTestCase5, 100);
        WriteToFile("linearCase5", linearCase5Results, csvSearchFilePath);
        var linearCase6Results = TestSearchAlgorithm(searcher.LinearSearch, arraySearchSortSortedTestCase6, 1000);
        WriteToFile("linearCase6", linearCase6Results, csvSearchFilePath);

        var jumpCase1Results = TestSearchAlgorithm(searcher.JumpSearch, arraySearchSortSortedTestCase1, 100);
        WriteToFile("jumpCase1", jumpCase1Results, csvSearchFilePath);
        var jumpCase2Results = TestSearchAlgorithm(searcher.JumpSearch, arraySearchSortSortedTestCase2, 1000);
        WriteToFile("jumpCase2", jumpCase2Results, csvSearchFilePath);
        var jumpCase3Results = TestSearchAlgorithm(searcher.JumpSearch, arraySearchSortSortedTestCase3, 100);
        WriteToFile("jumpCase3", jumpCase3Results, csvSearchFilePath);
        var jumpCase4Results = TestSearchAlgorithm(searcher.JumpSearch, arraySearchSortSortedTestCase4, 1000);
        WriteToFile("jumpCase4", jumpCase4Results, csvSearchFilePath);
        var jumpCase5Results = TestSearchAlgorithm(searcher.JumpSearch, arraySearchSortSortedTestCase5, 100);
        WriteToFile("jumpCase5", jumpCase5Results, csvSearchFilePath);
        var jumpCase6Results = TestSearchAlgorithm(searcher.JumpSearch, arraySearchSortSortedTestCase6, 1000);
        WriteToFile("jumpCase6", jumpCase6Results, csvSearchFilePath);


        //SORTING

        var bubbelCase1RandomResult = TestSortAlgorithm(sorter.BubbleSort, arraySortRandomTestCase1);
        WriteToFile("bubbleSortCase1Random", bubbelCase1RandomResult);
        var bubbelCase2RandomResult = TestSortAlgorithm(sorter.BubbleSort, arraySortRandomTestCase2);
        WriteToFile("bubbleSortCase2Random", bubbelCase2RandomResult);
        var bubbelCase3RandomResult = TestSortAlgorithm(sorter.BubbleSort, arraySortRandomTestCase3);
        WriteToFile("bubbleSortCase3Random", bubbelCase3RandomResult);
        var bubbelCase4RandomResult = TestSortAlgorithm(sorter.BubbleSort, arraySortRandomTestCase4);
        WriteToFile("bubbleSortCase4Random", bubbelCase4RandomResult);
        var bubbelCase5RandomResult = TestSortAlgorithm(sorter.BubbleSort, arraySortRandomTestCase5);
        WriteToFile("bubbleSortCase5Random", bubbelCase5RandomResult);
        var bubbelCase6RandomResult = TestSortAlgorithm(sorter.BubbleSort, arraySortRandomTestCase6);
        WriteToFile("bubbleSortCase6Random", bubbelCase6RandomResult);

        var bubbelCase1Result = TestSortAlgorithm(sorter.BubbleSort, arraySearchSortSortedTestCase1);
        WriteToFile("bubbleSortCase1Sorted", bubbelCase1Result);
        var bubbelCase2Result = TestSortAlgorithm(sorter.BubbleSort, arraySearchSortSortedTestCase2);
        WriteToFile("bubbleSortCase2Sorted", bubbelCase2Result);
        var bubbelCase3Result = TestSortAlgorithm(sorter.BubbleSort, arraySearchSortSortedTestCase3);
        WriteToFile("bubbleSortCase3Sorted", bubbelCase3Result);
        var bubbelCase4Result = TestSortAlgorithm(sorter.BubbleSort, arraySearchSortSortedTestCase4);
        WriteToFile("bubbleSortCase4Sorted", bubbelCase4Result);
        var bubbelCase5Result = TestSortAlgorithm(sorter.BubbleSort, arraySearchSortSortedTestCase5);
        WriteToFile("bubbleSortCase5Sorted", bubbelCase5Result);
        var bubbelCase6Result = TestSortAlgorithm(sorter.BubbleSort, arraySearchSortSortedTestCase6);
        WriteToFile("bubbleSortCase6Sorted", bubbelCase6Result);


        var bubbelCase1ReverseResult = TestSortAlgorithm(sorter.BubbleSort, arraySortReverseSortedTestCase1);
        WriteToFile("bubbleSortCase1Reverse", bubbelCase1ReverseResult);
        var bubbelCase2ReverseResult = TestSortAlgorithm(sorter.BubbleSort, arraySortReverseSortedTestCase2);
        WriteToFile("bubbleSortCase2Reverse", bubbelCase2ReverseResult);
        var bubbelCase3ReverseResult = TestSortAlgorithm(sorter.BubbleSort, arraySortReverseSortedTestCase4);
        WriteToFile("bubbleSortCase3Reverse", bubbelCase3ReverseResult);
        var bubbelCase4ReverseResult = TestSortAlgorithm(sorter.BubbleSort, arraySortReverseSortedTestCase4);
        WriteToFile("bubbleSortCase4Reverse", bubbelCase4ReverseResult);
        var bubbelCase5ReverseResult = TestSortAlgorithm(sorter.BubbleSort, arraySortReverseSortedTestCase5);
        WriteToFile("bubbleSortCase5Reverse", bubbelCase5ReverseResult);
        var bubbelCase6ReverseResult = TestSortAlgorithm(sorter.BubbleSort, arraySortReverseSortedTestCase6);
        WriteToFile("bubbleSortCase6Reverse", bubbelCase6ReverseResult);

        var bubbelCase1NearlySortedResult = TestSortAlgorithm(sorter.BubbleSort, arraySortNearlySortedTestCase1);
        WriteToFile("bubbleSortCase1NearlySorted", bubbelCase1NearlySortedResult);
        var bubbelCase2NearlySortedResult = TestSortAlgorithm(sorter.BubbleSort, arraySortNearlySortedTestCase2);
        WriteToFile("bubbleSortCase2NearlySorted", bubbelCase2NearlySortedResult);
        var bubbelCase3NearlySortedResult = TestSortAlgorithm(sorter.BubbleSort, arraySortNearlySortedTestCase3);
        WriteToFile("bubbleSortCase3NearlySorted", bubbelCase3NearlySortedResult);
        var bubbelCase4NearlySortedResult = TestSortAlgorithm(sorter.BubbleSort, arraySortNearlySortedTestCase4);
        WriteToFile("bubbleSortCase4NearlySorted", bubbelCase4NearlySortedResult);
        var bubbelCase5NearlySortedResult = TestSortAlgorithm(sorter.BubbleSort, arraySortNearlySortedTestCase5);
        WriteToFile("bubbleSortCase5NearlySorted", bubbelCase5NearlySortedResult);
        var bubbelCase6NearlySortedResult = TestSortAlgorithm(sorter.BubbleSort, arraySortNearlySortedTestCase6);
        WriteToFile("bubbleSortCase5NearlySorted", bubbelCase6NearlySortedResult);





        var insertionCase1RandomResult = TestSortAlgorithm(sorter.InsertionSort, arraySortRandomTestCase1);
        WriteToFile("insertionSortCase1Random", insertionCase1RandomResult);
        var insertionCase2RandomResult = TestSortAlgorithm(sorter.InsertionSort, arraySortRandomTestCase2);
        WriteToFile("insertionSortCase2Random", insertionCase2RandomResult);
        var insertionCase3RandomResult = TestSortAlgorithm(sorter.InsertionSort, arraySortRandomTestCase3);
        WriteToFile("insertionSortCase3Random", insertionCase3RandomResult);
        var insertionCase4RandomResult = TestSortAlgorithm(sorter.InsertionSort, arraySortRandomTestCase4);
        WriteToFile("insertionSortCase4Random", insertionCase4RandomResult);
        var insertionCase5RandomResult = TestSortAlgorithm(sorter.InsertionSort, arraySortRandomTestCase5);
        WriteToFile("insertionSortCase5Random", insertionCase5RandomResult);
        var insertionCase6RandomResult = TestSortAlgorithm(sorter.InsertionSort, arraySortRandomTestCase6);
        WriteToFile("insertionSortCase6Random", insertionCase6RandomResult);

        var insertionCase1SortedResult = TestSortAlgorithm(sorter.InsertionSort, arraySearchSortSortedTestCase1);
        WriteToFile("insertionSortCase1Sorted", insertionCase1SortedResult);
        var insertionCase2SortedResult = TestSortAlgorithm(sorter.InsertionSort, arraySearchSortSortedTestCase2);
        WriteToFile("insertionSortCase2Sorted", insertionCase2SortedResult);
        var insertionCase3SortedResult = TestSortAlgorithm(sorter.InsertionSort, arraySearchSortSortedTestCase3);
        WriteToFile("insertionSortCase3Sorted", insertionCase3SortedResult);
        var insertionCase4SortedResult = TestSortAlgorithm(sorter.InsertionSort, arraySearchSortSortedTestCase4);
        WriteToFile("insertionSortCase4Sorted", insertionCase4SortedResult);
        var insertionCase5SortedResult = TestSortAlgorithm(sorter.InsertionSort, arraySearchSortSortedTestCase5);
        WriteToFile("insertionSortCase5Sorted", insertionCase5SortedResult);
        var insertionCase6SortedResult = TestSortAlgorithm(sorter.InsertionSort, arraySearchSortSortedTestCase6);
        WriteToFile("insertionSortCase6Sorted", insertionCase6SortedResult);

        var insertionCase1ReverseResult = TestSortAlgorithm(sorter.InsertionSort, arraySortReverseSortedTestCase1);
        WriteToFile("insertionSortCase1Reverse", insertionCase1ReverseResult);
        var insertionCase2ReverseResult = TestSortAlgorithm(sorter.InsertionSort, arraySortReverseSortedTestCase2);
        WriteToFile("insertionSortCase2Reverse", insertionCase2ReverseResult);
        var insertionCase3ReverseResult = TestSortAlgorithm(sorter.InsertionSort, arraySortReverseSortedTestCase3);
        WriteToFile("insertionSortCase3Reverse", insertionCase3ReverseResult);
        var insertionCase4ReverseResult = TestSortAlgorithm(sorter.InsertionSort, arraySortReverseSortedTestCase4);
        WriteToFile("insertionSortCase4Reverse", insertionCase4ReverseResult);
        var insertionCase5ReverseResult = TestSortAlgorithm(sorter.InsertionSort, arraySortReverseSortedTestCase5);
        WriteToFile("insertionSortCase5Reverse", insertionCase5ReverseResult);
        var insertionCase6ReverseResult = TestSortAlgorithm(sorter.InsertionSort, arraySortReverseSortedTestCase6);
        WriteToFile("insertionSortCase6Reverse", insertionCase6ReverseResult);

        var insertionCase1NearlySortedResult = TestSortAlgorithm(sorter.InsertionSort, arraySortNearlySortedTestCase1);
        WriteToFile("insertionSortCase1NearlySorted", insertionCase1NearlySortedResult);
        var insertionCase2NearlySortedResult = TestSortAlgorithm(sorter.InsertionSort, arraySortNearlySortedTestCase2);
        WriteToFile("insertionSortCase2NearlySorted", insertionCase2NearlySortedResult);
        var insertionCase3NearlySortedResult = TestSortAlgorithm(sorter.InsertionSort, arraySortNearlySortedTestCase3);
        WriteToFile("insertionSortCase3NearlySorted", insertionCase3NearlySortedResult);
        var insertionCase4NearlySortedResult = TestSortAlgorithm(sorter.InsertionSort, arraySortNearlySortedTestCase4);
        WriteToFile("insertionSortCase4NearlySorted", insertionCase4NearlySortedResult);
        var insertionCase5NearlySortedResult = TestSortAlgorithm(sorter.InsertionSort, arraySortNearlySortedTestCase5);
        WriteToFile("insertionSortCase5NearlySorted", insertionCase5NearlySortedResult);
        var insertionCase6NearlySortedResult = TestSortAlgorithm(sorter.InsertionSort, arraySortNearlySortedTestCase6);
        WriteToFile("insertionSortCase6NearlySorted", insertionCase6NearlySortedResult);



        var heapCase1RandomResult = TestSortAlgorithm(sorter.HeapSort, arraySortRandomTestCase1);
        WriteToFile("heapSortCase1Random", heapCase1RandomResult);
        var heapCase2RandomResult = TestSortAlgorithm(sorter.HeapSort, arraySortRandomTestCase2);
        WriteToFile("heapSortCase2Random", heapCase2RandomResult);
        var heapCase3RandomResult = TestSortAlgorithm(sorter.HeapSort, arraySortRandomTestCase3);
        WriteToFile("heapSortCase3Random", heapCase3RandomResult);
        var heapCase4RandomResult = TestSortAlgorithm(sorter.HeapSort, arraySortRandomTestCase4);
        WriteToFile("heapSortCase4Random", heapCase4RandomResult);
        var heapCase5RandomResult = TestSortAlgorithm(sorter.HeapSort, arraySortRandomTestCase5);
        WriteToFile("heapSortCase5Random", heapCase5RandomResult);
        var heapCase6RandomResult = TestSortAlgorithm(sorter.HeapSort, arraySortRandomTestCase6);
        WriteToFile("heapSortCase6Random", heapCase6RandomResult);

        var heapCase1SortedResult = TestSortAlgorithm(sorter.HeapSort, arraySearchSortSortedTestCase1);
        WriteToFile("heapSortCase1Sorted", heapCase1SortedResult);
        var heapCase2SortedResult = TestSortAlgorithm(sorter.HeapSort, arraySearchSortSortedTestCase2);
        WriteToFile("heapSortCase2Sorted", heapCase2SortedResult);
        var heapCase3SortedResult = TestSortAlgorithm(sorter.HeapSort, arraySearchSortSortedTestCase3);
        WriteToFile("heapSortCase3Sorted", heapCase3SortedResult);
        var heapCase4SortedResult = TestSortAlgorithm(sorter.HeapSort, arraySearchSortSortedTestCase4);
        WriteToFile("heapSortCase4Sorted", heapCase4SortedResult);
        var heapCase5SortedResult = TestSortAlgorithm(sorter.HeapSort, arraySearchSortSortedTestCase5);
        WriteToFile("heapSortCase5Sorted", heapCase5SortedResult);
        var heapCase6SortedResult = TestSortAlgorithm(sorter.HeapSort, arraySearchSortSortedTestCase6);
        WriteToFile("heapSortCase6Sorted", heapCase6SortedResult);

        var heapCase1ReverseResult = TestSortAlgorithm(sorter.HeapSort, arraySortReverseSortedTestCase1);
        WriteToFile("heapSortCase1Reverse", heapCase1ReverseResult);
        var heapCase2ReverseResult = TestSortAlgorithm(sorter.HeapSort, arraySortReverseSortedTestCase2);
        WriteToFile("heapSortCase2Reverse", heapCase2ReverseResult);
        var heapCase3ReverseResult = TestSortAlgorithm(sorter.HeapSort, arraySortReverseSortedTestCase3);
        WriteToFile("heapSortCase3Reverse", heapCase3ReverseResult);
        var heapCase4ReverseResult = TestSortAlgorithm(sorter.HeapSort, arraySortReverseSortedTestCase4);
        WriteToFile("heapSortCase4Reverse", heapCase4ReverseResult);
        var heapCase5ReverseResult = TestSortAlgorithm(sorter.HeapSort, arraySortReverseSortedTestCase5);
        WriteToFile("heapSortCase5Reverse", heapCase5ReverseResult);
        var heapCase6ReverseResult = TestSortAlgorithm(sorter.HeapSort, arraySortReverseSortedTestCase6);
        WriteToFile("heapSortCase6Reverse", heapCase6ReverseResult);

        var heapCase1NearlySortedResult = TestSortAlgorithm(sorter.HeapSort, arraySortNearlySortedTestCase1);
        WriteToFile("heapSortCase1NearlySorted", heapCase1NearlySortedResult);
        var heapCase2NearlySortedResult = TestSortAlgorithm(sorter.HeapSort, arraySortNearlySortedTestCase2);
        WriteToFile("heapSortCase2NearlySorted", heapCase2NearlySortedResult);
        var heapCase3NearlySortedResult = TestSortAlgorithm(sorter.HeapSort, arraySortNearlySortedTestCase3);
        WriteToFile("heapSortCase3NearlySorted", heapCase3NearlySortedResult);
        var heapCase4NearlySortedResult = TestSortAlgorithm(sorter.HeapSort, arraySortNearlySortedTestCase4);
        WriteToFile("heapSortCase4NearlySorted", heapCase4NearlySortedResult);
        var heapCase5NearlySortedResult = TestSortAlgorithm(sorter.HeapSort, arraySortNearlySortedTestCase5);
        WriteToFile("heapSortCase5NearlySorted", heapCase5NearlySortedResult);
        var heapCase6NearlySortedResult = TestSortAlgorithm(sorter.HeapSort, arraySortNearlySortedTestCase6);
        WriteToFile("heapSortCase6NearlySorted", heapCase6NearlySortedResult);

        var quickCase1RandomResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySortRandomTestCase1, 0, 99);
        WriteToFile("quickSortCase1Random", quickCase1RandomResult);
        var quickCase2RandomResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySortRandomTestCase2, 0, 99);
        WriteToFile("quickSortCase2Random", quickCase2RandomResult);
        var quickCase3RandomResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySortRandomTestCase3, 0, 999);
        WriteToFile("quickSortCase3Random", quickCase3RandomResult);
        var quickCase4RandomResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySortRandomTestCase4, 0, 999);
        WriteToFile("quickSortCase4Random", quickCase4RandomResult);
        var quickCase5RandomResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySortRandomTestCase5, 0, 9999);
        WriteToFile("quickSortCase5Random", quickCase5RandomResult);
        var quickCase6RandomResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySortRandomTestCase6, 0, 9999);
        WriteToFile("quickSortCase6Random", quickCase6RandomResult);

        var quickCase1SortedResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySearchSortSortedTestCase1, 0, 99);
        WriteToFile("quickSortCase1Sorted", quickCase1SortedResult);
        var quickCase2SortedResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySearchSortSortedTestCase2, 0, 99);
        WriteToFile("quickSortCase2Sorted", quickCase2SortedResult);
        var quickCase3SortedResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySearchSortSortedTestCase3, 0, 999);
        WriteToFile("quickSortCase3Sorted", quickCase3SortedResult);
        var quickCase4SortedResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySearchSortSortedTestCase4, 0, 999);
        WriteToFile("quickSortCase4Sorted", quickCase4SortedResult);
        var quickCase5SortedResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySearchSortSortedTestCase5, 0, 9999);
        WriteToFile("quickSortCase5Sorted", quickCase5SortedResult);
        var quickCase6SortedResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySearchSortSortedTestCase6, 0, 9999);
        WriteToFile("quickSortCase6Sorted", quickCase6SortedResult);

        var quickCase1ReverseResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySortReverseSortedTestCase1, 0, 99);
        WriteToFile("quickSortCase1Reverse", quickCase1ReverseResult);
        var quickCase2ReverseResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySortReverseSortedTestCase2, 0, 99);
        WriteToFile("quickSortCase2Reverse", quickCase2ReverseResult);
        var quickCase3ReverseResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySortReverseSortedTestCase3, 0, 999);
        WriteToFile("quickSortCase3Reverse", quickCase3ReverseResult);
        var quickCase4ReverseResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySortReverseSortedTestCase4, 0, 999);
        WriteToFile("quickSortCase4Reverse", quickCase4ReverseResult);
        var quickCase5ReverseResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySortReverseSortedTestCase5, 0, 9999);
        WriteToFile("quickSortCase5Reverse", quickCase5ReverseResult);
        var quickCase6ReverseResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySortReverseSortedTestCase6, 0, 9999);
        WriteToFile("quickSortCase6Reverse", quickCase6ReverseResult);

        var quickCase1NearlySortedResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySortNearlySortedTestCase1, 0, 99);
        WriteToFile("quickSortCase1NearlySorted", quickCase1NearlySortedResult);
        var quickCase2NearlySortedResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySortNearlySortedTestCase2, 0, 99);
        WriteToFile("quickSortCase2NearlySorted", quickCase2NearlySortedResult);
        var quickCase3NearlySortedResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySortNearlySortedTestCase3, 0, 999);
        WriteToFile("quickSortCase3NearlySorted", quickCase3NearlySortedResult);
        var quickCase4NearlySortedResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySortNearlySortedTestCase4, 0, 999);
        WriteToFile("quickSortCase4NearlySorted", quickCase4NearlySortedResult);
        var quickCase5NearlySortedResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySortNearlySortedTestCase5, 0, 9999);
        WriteToFile("quickSortCase5NearlySorted", quickCase5NearlySortedResult);
        var quickCase6NearlySortedResult = TestQuickSortAlgorithm(sorter.QuickSort, arraySortNearlySortedTestCase6, 0, 9999);
        WriteToFile("quickSortCase6NearlySorted", quickCase6NearlySortedResult);

        var selectionCase1RandomResult = TestSortAlgorithm(sorter.SelectionSort, arraySortRandomTestCase1);
        WriteToFile("selectionSortCase1Random", selectionCase1RandomResult);
        var selectionCase2RandomResult = TestSortAlgorithm(sorter.SelectionSort, arraySortRandomTestCase2);
        WriteToFile("selectionSortCase2Random", selectionCase2RandomResult);
        var selectionCase3RandomResult = TestSortAlgorithm(sorter.SelectionSort, arraySortRandomTestCase3);
        WriteToFile("selectionSortCase3Random", selectionCase3RandomResult);
        var selectionCase4RandomResult = TestSortAlgorithm(sorter.SelectionSort, arraySortRandomTestCase4);
        WriteToFile("selectionSortCase4Random", selectionCase4RandomResult);
        var selectionCase5RandomResult = TestSortAlgorithm(sorter.SelectionSort, arraySortRandomTestCase5);
        WriteToFile("selectionSortCase5Random", selectionCase5RandomResult);
        var selectionCase6RandomResult = TestSortAlgorithm(sorter.SelectionSort, arraySortRandomTestCase6);
        WriteToFile("selectionSortCase6Random", selectionCase6RandomResult);

        var selectionCase1SortedResult = TestSortAlgorithm(sorter.SelectionSort, arraySearchSortSortedTestCase1);
        WriteToFile("selectionSortCase1Sorted", selectionCase1SortedResult);
        var selectionCase2SortedResult = TestSortAlgorithm(sorter.SelectionSort, arraySearchSortSortedTestCase2);
        WriteToFile("selectionSortCase2Sorted", selectionCase2SortedResult);
        var selectionCase3SortedResult = TestSortAlgorithm(sorter.SelectionSort, arraySearchSortSortedTestCase3);
        WriteToFile("selectionSortCase3Sorted", selectionCase3SortedResult);
        var selectionCase4SortedResult = TestSortAlgorithm(sorter.SelectionSort, arraySearchSortSortedTestCase4);
        WriteToFile("selectionSortCase4Sorted", selectionCase4SortedResult);
        var selectionCase5SortedResult = TestSortAlgorithm(sorter.SelectionSort, arraySearchSortSortedTestCase5);
        WriteToFile("selectionSortCase5Sorted", selectionCase5SortedResult);
        var selectionCase6SortedResult = TestSortAlgorithm(sorter.SelectionSort, arraySearchSortSortedTestCase6);
        WriteToFile("selectionSortCase6Sorted", selectionCase6SortedResult);

        var selectionCase1ReverseResult = TestSortAlgorithm(sorter.SelectionSort, arraySortReverseSortedTestCase1);
        WriteToFile("selectionSortCase1Reverse", selectionCase1ReverseResult);
        var selectionCase2ReverseResult = TestSortAlgorithm(sorter.SelectionSort, arraySortReverseSortedTestCase2);
        WriteToFile("selectionSortCase2Reverse", selectionCase2ReverseResult);
        var selectionCase3ReverseResult = TestSortAlgorithm(sorter.SelectionSort, arraySortReverseSortedTestCase3);
        WriteToFile("selectionSortCase3Reverse", selectionCase3ReverseResult);
        var selectionCase4ReverseResult = TestSortAlgorithm(sorter.SelectionSort, arraySortReverseSortedTestCase4);
        WriteToFile("selectionSortCase4Reverse", selectionCase4ReverseResult);
        var selectionCase5ReverseResult = TestSortAlgorithm(sorter.SelectionSort, arraySortReverseSortedTestCase5);
        WriteToFile("selectionSortCase5Reverse", selectionCase5ReverseResult);
        var selectionCase6ReverseResult = TestSortAlgorithm(sorter.SelectionSort, arraySortReverseSortedTestCase6);
        WriteToFile("selectionSortCase6Reverse", selectionCase6ReverseResult);

        var selectionCase1NearlySortedResult = TestSortAlgorithm(sorter.SelectionSort, arraySortNearlySortedTestCase1);
        WriteToFile("selectionSortCase1NearlySorted", selectionCase1NearlySortedResult);
        var selectionCase2NearlySortedResult = TestSortAlgorithm(sorter.SelectionSort, arraySortNearlySortedTestCase2);
        WriteToFile("selectionSortCase2NearlySorted", selectionCase2NearlySortedResult);
        var selectionCase3NearlySortedResult = TestSortAlgorithm(sorter.SelectionSort, arraySortNearlySortedTestCase3);
        WriteToFile("selectionSortCase3NearlySorted", selectionCase3NearlySortedResult);
        var selectionCase4NearlySortedResult = TestSortAlgorithm(sorter.SelectionSort, arraySortNearlySortedTestCase4);
        WriteToFile("selectionSortCase4NearlySorted", selectionCase4NearlySortedResult);
        var selectionCase5NearlySortedResult = TestSortAlgorithm(sorter.SelectionSort, arraySortNearlySortedTestCase5);
        WriteToFile("selectionSortCase5NearlySorted", selectionCase5NearlySortedResult);
        var selectionCase6NearlySortedResult = TestSortAlgorithm(sorter.SelectionSort, arraySortNearlySortedTestCase6);
        WriteToFile("selectionSortCase6NearlySorted", selectionCase6NearlySortedResult);

        //for (int i = 0; i < 10; i++)
        //{

        //    Stopwatch sw = Stopwatch.StartNew();

        //    //HINT: this is an appropriate place to run your algorithm.
        //    searcher.BinarySearch(arraySearchSortSortedTestCase1, 100);
        //    sw.Stop();
        //    TimeSpan elapsedTimeBinarySearch = sw.Elapsed;
        //    binaryCase1Results.Add(elapsedTimeBinarySearch);
        //    totalTimeBinarySearch += elapsedTimeBinarySearch;

        //    sw.Restart();
        //    //searcher.BinarySearch();

        //    sw.Restart();
        //    searcher.LinearSearch(arraySearchSortSortedTestCase1, 100);
        //    sw.Stop();
        //    TimeSpan elapsedTimeLinearSearch = sw.Elapsed;
        //    linearCase1Results.Add( elapsedTimeLinearSearch);
        //    totalTimeLinearSearch += elapsedTimeLinearSearch;

        //}

        //WriteToFile("binaryCase1", binaryCase1Results, csvSearchFilePath);
        //WriteToFile("linearCase1", linearCase1Results, csvSearchFilePath);
        //TimeSpan averageTimeBinarySearch = TimeSpan.FromTicks(totalTimeBinarySearch.Ticks / 10);
        //TimeSpan averageTimeLinearSearch = TimeSpan.FromTicks(totalTimeLinearSearch.Ticks / 10);

        // Export results to a CSV file
        //using (StreamWriter writer = new StreamWriter(csvFilePath))
        //{
        //    writer.WriteLine("Algorithm,Average Time (ms)");
        //    writer.WriteLine("Linear Search," + averageTimeLinearSearch.TotalMilliseconds);
        //}

        // Display a message to the user

        Console.WriteLine($"Results exported to {csvSearchFilePath}");

        //Console.WriteLine("Binary Search case 1:");
        //Console.WriteLine($"Average Time: {averageTimeBinarySearch}");
        //Console.WriteLine();

        //Console.WriteLine("Linear Search case 1:");
        //Console.WriteLine($"Average Time: {averageTimeLinearSearch}");
        List<TimeSpan> TestSearchAlgorithm(Func<int[], int, int> searchAlgorithm, int[] testData, int target)
        {
            var results = new List<TimeSpan>();

            for (int i = 0; i<11; i++) 
            {
                Stopwatch sw = Stopwatch.StartNew();

                int targetIndex = searchAlgorithm(testData, target);
                sw.Stop();
                TimeSpan elapsedTimeSearch = sw.Elapsed;
                if (i==0)
                {
                    continue;
                }
                results.Add(elapsedTimeSearch);
            }
            return results;
        }

        List<TimeSpan> TestSortAlgorithm(Action<int[]> sortAlgorithm, int[] testData)
        {
            var results = new List<TimeSpan>();

            for (int i = 0; i < 11; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();

                sortAlgorithm(testData);
                sw.Stop();
                TimeSpan elapsedTimeBinarySearch = sw.Elapsed;

                if (i==0)
                {
                    continue;
                }
                results.Add(elapsedTimeBinarySearch);
            }
            return results;
        }

        List<TimeSpan> TestQuickSortAlgorithm(Action<int[], int, int> sortAlgorithm, int[] testData, int low, int high)
        {
            var results = new List<TimeSpan>();

            for (int i = 0; i < 11; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();

                sortAlgorithm(testData, low, high);
                sw.Stop();
                TimeSpan elapsedTimeBinarySearch = sw.Elapsed;
                if (i == 0)
                {
                    continue;
                }
                results.Add(elapsedTimeBinarySearch);
            }
            return results;
        }

        void WriteToFile(string algorithm, List<TimeSpan> results, string csvPath = "../../../sort_results.csv")
        {
            
            using (StreamWriter writer = new StreamWriter(csvPath,true))
            {
                writer.Write($"{algorithm}");

                foreach(var result in results)
                {
                    writer.Write($"...{result.TotalMilliseconds}");
                }
                writer.Write('\n');
            }
        }
        
    }
}