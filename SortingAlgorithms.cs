using System; 
using System.Linq; 

/// <summary> 
/// This class contains implementations of various sorting algorithms in C#. 
/// </summary> 
public static class SortingAlgorithms 
{ 
    /// <summary> 
    /// Performs bubble sort on the given array. 
    /// </summary> 
    public static void BubbleSort(int[] arr) 
    { 
        int n = arr.Length; 
        for (int i = 0; i < n - 1; i++) 
        { 
            for (int j = 0; j < n - i - 1; j++) 
            { 
                if (arr[j] > arr[j + 1]) 
                { 
                    // swap arr[j] and arr[j+1] 
                    int temp = arr[j]; 
                    arr[j] = arr[j + 1]; 
                    arr[j + 1] = temp; 
                } 
            } 
        } 
    } 

    /// <summary> 
    /// Performs selection sort on the given array. 
    /// </summary> 
    public static void SelectionSort(int[] arr) 
    { 
        int n = arr.Length; 
        for (int i = 0; i < n - 1; i++) 
        { 
            int minIndex = i; 
            for (int j = i + 1; j < n; j++) 
            { 
                if (arr[j] < arr[minIndex]) 
                    minIndex = j; 
            } 
            // swap arr[i] and arr[minIndex] 
            int temp = arr[i]; 
            arr[i] = arr[minIndex]; 
            arr[minIndex] = temp; 
        } 
    } 

    /// <summary> 
    /// Performs insertion sort on the given array. 
    /// </summary> 
    public static void InsertionSort(int[] arr) 
    { 
        int n = arr.Length; 
        for (int i = 1; i < n; i++) 
        { 
            int key = arr[i]; 
            int j = i - 1; 
            while (j >= 0 && arr[j] > key) 
            { 
                arr[j + 1] = arr[j]; 
                j--; 
            } 
            arr[j + 1] = key; 
        } 
    } 

    /// <summary> 
    /// Performs merge sort on the given array. 
    /// </summary> 
    public static void MergeSort(int[] arr) 
    { 
        if (arr.Length < 2) return; 
        int mid = arr.Length / 2; 
        int[] left = arr.Take(mid).ToArray(); 
        int[] right = arr.Skip(mid).ToArray(); 

        MergeSort(left); 
        MergeSort(right); 
        Merge(arr, left, right); 
    } 

    private static void Merge(int[] arr, int[] left, int[] right) 
    { 
        int i = 0, j = 0, k = 0; 
        while (i < left.Length && j < right.Length) 
        { 
            if (left[i] <= right[j]) 
                arr[k++] = left[i++]; 
            else 
                arr[k++] = right[j++]; 
        } 
        while (i < left.Length) arr[k++] = left[i++]; 
        while (j < right.Length) arr[k++] = right[j++]; 
    } 

    /// <summary> 
    /// Performs quick sort on the given array. 
    /// </summary> 
    public static void QuickSort(int[] arr, int low, int high) 
    { 
        if (low < high) 
        { 
            int pi = Partition(arr, low, high); 
            QuickSort(arr, low, pi - 1); 
            QuickSort(arr, pi + 1, high); 
        } 
    } 

    private static int Partition(int[] arr, int low, int high) 
    { 
        int pivot = arr[high]; 
        int i = (low - 1); 
        for (int j = low; j < high; j++) 
        { 
            if (arr[j] < pivot) 
            { 
                i++; 
                int temp = arr[i]; 
                arr[i] = arr[j]; 
                arr[j] = temp; 
            } 
        } 
        int temp1 = arr[i + 1]; 
        arr[i + 1] = arr[high]; 
        arr[high] = temp1; 
        return i + 1; 
    } 

    /// <summary> 
    /// Performs heap sort on the given array. 
    /// </summary> 
    public static void HeapSort(int[] arr) 
    { 
        int n = arr.Length; 
        for (int i = n / 2 - 1; i >= 0; i--) 
            Heapify(arr, n, i); 
        for (int i = n - 1; i >= 0; i--) 
        { 
            int temp = arr[0]; 
            arr[0] = arr[i]; 
            arr[i] = temp; 
            Heapify(arr, i, 0); 
        } 
    } 

    private static void Heapify(int[] arr, int n, int i) 
    { 
        int largest = i; 
        int left = 2 * i + 1; 
        int right = 2 * i + 2; 
        if (left < n && arr[left] > arr[largest]) 
            largest = left; 
        if (right < n && arr[right] > arr[largest]) 
            largest = right; 
        if (largest != i) 
        { 
            int swap = arr[i]; 
            arr[i] = arr[largest]; 
            arr[largest] = swap; 
            Heapify(arr, n, largest); 
        } 
    } 

    /// <summary> 
    /// Performs counting sort on the given array. 
    /// </summary> 
    public static void CountingSort(int[] arr) 
    { 
        int max = arr.Max(); 
        int[] count = new int[max + 1]; 
        int[] output = new int[arr.Length]; 

        foreach (var num in arr) 
            count[num]++; 
        for (int i = 1; i <= max; i++) 
            count[i] += count[i - 1]; 
        for (int i = arr.Length - 1; i >= 0; i--) 
        { 
            output[count[arr[i]] - 1] = arr[i]; 
            count[arr[i]]--; 
        } 
        Array.Copy(output, arr, arr.Length); 
    }
}

/// Usage example: 
// int[] sampleArray = { 64, 34, 25, 12, 22, 11, 90 }; 
// SortingAlgorithms.BubbleSort(sampleArray); 
// Console.WriteLine(string.Join(", ", sampleArray));