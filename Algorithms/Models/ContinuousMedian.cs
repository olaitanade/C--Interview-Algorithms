using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class ContinuousMedian
    {
		public class ContinuousMedianHandler
		{
			public Heap lowers;
			public Heap greaters;
			public double median = 0;

			public ContinuousMedianHandler()
			{
				this.lowers = new Heap(Heap.MAX_HEAP_FUNC, new List<int>());
				this.greaters = new Heap(Heap.MIN_HEAP_FUNC, new List<int>());
				this.median = 0;
			}

			public void Insert(int number)
			{
				if (lowers.length == 0 || number < lowers.peek())
				{
					this.lowers.Insert(number);
				}
				else
				{
					this.greaters.Insert(number);
				}
				this.rebalanceHeaps();
				this.updateMedian();
			}

			public void rebalanceHeaps()
			{
				if (lowers.length - greaters.length == 2)
				{
					this.greaters.Insert(this.lowers.remove());
				}
				else if (greaters.length - lowers.length == 2)
				{
					this.lowers.Insert(this.greaters.remove());
				}
			}

			public void updateMedian()
			{
				if (lowers.length == greaters.length)
				{
					median = ((double)lowers.peek() + (double)greaters.peek()) / 2;
				}
				else if (lowers.length > greaters.length)
				{
					median = lowers.peek();
				}
				else
				{
					median = greaters.peek();
				}
			}

			public double GetMedian()
			{
				return median;
			}
		}

		public class Heap
		{
			public List<int> heap = new List<int>();
			public Func<int, int, bool> comparisonFunc;
			public int length;

			public Heap(Func<int, int, bool> func, List<int> array)
			{
				this.comparisonFunc = func;
				this.heap = buildHeap(array);
				this.length = heap.Count;
			}

			public int peek()
			{
				return heap[0];
			}

			public int remove()
			{
				this.swap(0, heap.Count - 1);
				int valueToRemove = heap[heap.Count - 1];
				this.heap.RemoveAt(heap.Count - 1);
				this.length -= 1;
				this.siftDown(0, heap.Count - 1, heap);
				return valueToRemove;
			}

			public void Insert(int value)
			{
				this.heap.Add(value);
				this.length += 1;
				this.siftUp(heap.Count - 1, heap);
			}

			public List<int> buildHeap(List<int> array)
			{
				int firstParentIdx = (array.Count - 2) / 2;
				for (int currentIdx = firstParentIdx; currentIdx >= 0; currentIdx--)
				{
					this.siftDown(currentIdx, array.Count - 1, array);
				}
				return array;
			}

			public void siftDown(int currentIdx, int endIdx, List<int> heap)
			{
				int childOneIdx = currentIdx * 2 + 1;
				while (childOneIdx <= endIdx)
				{
					int childTwoIdx = currentIdx * 2 + 2 <= endIdx ? currentIdx * 2 + 2 : -1;
					int idxToSwap;
					if (childTwoIdx != -1)
					{
						if (comparisonFunc(heap[childTwoIdx], heap[childOneIdx]))
						{
							idxToSwap = childTwoIdx;
						}
						else
						{
							idxToSwap = childOneIdx;
						}
					}
					else
					{
						idxToSwap = childOneIdx;
					}
					if (comparisonFunc(heap[idxToSwap], heap[currentIdx]))
					{
						swap(currentIdx, idxToSwap);
						currentIdx = idxToSwap;
						childOneIdx = currentIdx * 2 + 1;
					}
					else
					{
						return;
					}
				}
			}

			public void siftUp(int currentIdx, List<int> heap)
			{
				int parentIdx = (currentIdx - 1) / 2;
				while (currentIdx > 0)
				{
					if (comparisonFunc(heap[currentIdx], heap[parentIdx]))
					{
						swap(currentIdx, parentIdx);
						currentIdx = parentIdx;
						parentIdx = (currentIdx - 1) / 2;
					}
					else
					{
						return;
					}
				}
			}

			public void swap(int i, int j)
			{
				int temp = this.heap[j];
				this.heap[j] = this.heap[i];
				this.heap[i] = temp;
			}

			public static bool MAX_HEAP_FUNC(int a, int b)
			{
				return a > b;
			}

			public static bool MIN_HEAP_FUNC(int a, int b)
			{
				return a < b;
			}
		}
	}
}
