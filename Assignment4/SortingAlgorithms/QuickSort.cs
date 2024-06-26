﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.SortingAlgorithms
{
    public class QuickSort
    {
        public static void OrderByColorAscending(List<TShirt> shirts, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[pi] is  now at right place */
                int pi = PartitionAscending(shirts, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                OrderByColorAscending(shirts, low, pi - 1);
                OrderByColorAscending(shirts, pi + 1, high);
            }
        }

        public static int PartitionAscending(List<TShirt> shirts, int low, int high)
        {
            TShirt pivot = shirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (shirts[j].Color < pivot.Color)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    TShirt temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = shirts[i + 1];
            shirts[i + 1] = shirts[high];
            shirts[high] = temp1;

            return i + 1;

        }


        public static void OrderByColorDescending(List<TShirt> shirts, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[pi] is  now at right place */
                int pi = PartitionDescending(shirts, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                OrderByColorDescending(shirts, low, pi - 1);
                OrderByColorDescending(shirts, pi + 1, high);
            }
        }

        public static int PartitionDescending(List<TShirt> shirts, int low, int high)
        {
            TShirt pivot = shirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (shirts[j].Color > pivot.Color)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    TShirt temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = shirts[i + 1];
            shirts[i + 1] = shirts[high];
            shirts[high] = temp1;

            return i + 1;

        }




























    }
}
