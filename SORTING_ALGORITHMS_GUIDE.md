# Sorting Algorithms Guide

This document provides detailed explanations and ASCII diagrams for various sorting algorithms, which are essential for data organization and manipulation.

## 1. Bubble Sort

**Explanation:** Bubble Sort is a simple sorting algorithm that repeatedly steps through the list, compares adjacent elements, and swaps them if they are in the wrong order. The pass through the list is repeated until the list is sorted.

**ASCII Diagram:**
```
Initial: 5, 3, 8, 4, 2

Pass 1: 3, 5, 4, 2, 8
Pass 2: 3, 4, 2, 5, 8
Pass 3: 3, 2, 4, 5, 8
Pass 4: 2, 3, 4, 5, 8  (Sorted)
```

## 2. Selection Sort

**Explanation:** Selection Sort divides the input list into two parts: the sorted part at the front and the unsorted part at the back. The algorithm repeatedly selects the smallest element from the unsorted part and moves it to the sorted part.

**ASCII Diagram:**
```
Initial: 64, 25, 12, 22, 11

Pass 1: 11, 25, 12, 22, 64
Pass 2: 11, 12, 25, 22, 64
Pass 3: 11, 12, 22, 25, 64
Pass 4: 11, 12, 22, 25, 64 (Sorted)
```

## 3. Insertion Sort

**Explanation:** Insertion Sort builds the final sorted array one item at a time, with the sorted elements being built in place. It works similarly to how one might sort playing cards.

**ASCII Diagram:**
```
Initial: 5, 2, 9, 1, 5, 6

Step 1: 2, 5, 9, 1, 5, 6
Step 2: 1, 2, 5, 9, 5, 6
Step 3: 1, 2, 5, 5, 9, 6
Step 4: 1, 2, 5, 5, 6, 9 (Sorted)
```

## 4. Merge Sort

**Explanation:** Merge Sort is a divide-and-conquer algorithm that was first conceptualized by John von Neumann in 1945. It divides the unsorted list into n sublists until each sublist contains a single element and then merges those sublists to produce new sorted sublists until there is only one sublist remaining.

**ASCII Diagram:**
```
Initial: [38, 27, 43, 3, 9, 82, 10]

Divide Stage: 
1. [38, 27, 43] [3, 9, 82, 10]
2. [38] [27, 43] [3] [9, 82, 10]
3. [38] [27] [43] [3] [9] [82, 10]
4. [38] [27] [43] [3] [9] [82] [10]

Merge Stage: 
1. [27, 38, 43] [3, 9, 82, 10]
2. [3, 9, 10, 82]
3. [3, 9, 10, 27, 38, 43, 82] (Sorted)
```

## 5. Quick Sort

**Explanation:** Quick Sort is a divide-and-conquer algorithm that works by selecting a 'pivot' element from the array and partitioning the other elements into two sub-arrays according to whether they are less than or greater than the pivot.

**ASCII Diagram:**
```
Initial: 10, 80, 30, 90, 40, 50, 70

Pivot = 40

Partition: [10, 30] [40] [80, 90, 50, 70]

Sorted arrays: [10, 30, 40, 50, 70, 80, 90]
```

## 6. Heap Sort

**Explanation:** Heap Sort is a comparison-based sorting technique based on a binary heap data structure. It is considered an in-place sort since it doesn't require the allocation of additional storage.

**ASCII Diagram:**
```
Initial: [3, 9, 2, 1, 4]

Max Heap: [9, 4, 2, 1, 3]

Sorted: [1, 2, 3, 4, 9]
```

## 7. Counting Sort

**Explanation:** Counting Sort is a non-comparison-based sorting algorithm that is particularly useful for sorting integers. It works by counting the occurrences of each value.

**ASCII Diagram:**
```
Initial: [4, 2, 2, 8]

Count Array: [0, 1, 2, 0, 1, 0, 0, 0, 1]

Sorted: [2, 2, 4, 8]
```
