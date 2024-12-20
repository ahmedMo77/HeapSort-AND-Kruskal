# HeapSort and Kruskal's Algorithm in C#

## Overview
This repository contains C# implementations of two fundamental algorithms in computer science:
- **Heap-Sort Algorithm**: Used for efficiently sorting sequences of numbers.
- **Kruskal's Algorithm**: Finds the Minimum Spanning Tree (MST) of a graph using a greedy approach.

Each implementation includes detailed pseudocode, efficiency analysis, and clear modular code for ease of understanding and use.

---

## Heap-Sort Algorithm

### Description
Heap-Sort is a sorting algorithm that uses a binary heap structure to organize data for efficient sorting. It is in-place and guarantees \( O(n \log n) \) time complexity.

### Implementation Details
1. **HEAPIFY**: Ensures the Max-Heap property for a subtree rooted at a given index.
2. **BUILD_MAX_HEAP**: Converts an unordered array into a Max-Heap.
3. **HEAP_SORT**: Extracts the maximum element repeatedly and rebuilds the heap.

### Time Complexity
- **HEAPIFY**: \( O(\log n) \)
- **BUILD_MAX_HEAP**: \( O(n) \)
- **HEAP_SORT**: \( O(n \log n) \)
---

## Kruskal's Algorithm

### Description
Kruskal's Algorithm is a method to find the MST of a graph by selecting edges in increasing order of weight while avoiding cycles. It utilizes the Union-Find data structure for efficient cycle detection.

### Implementation Details
1. **FIND**: Locates the root of a set in the Union-Find structure.
2. **UNION**: Merges two sets without creating a cycle.
3. **KRUSKAL_MST**: Selects edges in sorted order to construct the MST.

### Time Complexity
- **Sorting Edges**: \( O(E \log E) \)
- **Union-Find Operations**: \( O(E \alpha(V)) \)
- **Overall**: \( O(E \log E) \)
