using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.SortingAlgorithms
{
    public class BucketSort
    {
        public static void OrderByFabricAscending(List<TShirt> shirts)
        {
            List<List<TShirt>> buckets = new List<List<TShirt>>();
            InitializeBuckets(buckets);

            Scatter(shirts, buckets);

            int i = 0;
            foreach (List<TShirt> bucket in buckets)
            {

                foreach (TShirt d in bucket)
                {
                    shirts[i++] = d;
                }
            }
        }

        public static void OrderByFabricDescending(List<TShirt> shirts)
        {
            List<List<TShirt>> buckets = new List<List<TShirt>>();
            InitializeBuckets(buckets);

            ScatterDescending(shirts, buckets);

            int i = 0;
            foreach (List<TShirt> bucket in buckets)
            {

                foreach (TShirt d in bucket)
                {
                    shirts[i++] = d;
                }
            }
        }
















        private static void Scatter(List<TShirt> shirts, List<List<TShirt>> buckets)
        {
            foreach (TShirt shirt in shirts)
            {
                int bucketNumber = GetBucketNumber(shirt);
                buckets[bucketNumber].Add(shirt);
            }
        }

        private static void ScatterDescending(List<TShirt> shirts, List<List<TShirt>> buckets)
        {
            int fabricLength = Enum.GetNames(typeof(Fabric)).Length;

            foreach (TShirt shirt in shirts)
            {


                int bucketNumber = GetBucketNumberDescending(shirt, fabricLength);
                buckets[bucketNumber].Add(shirt);
            }
        }

        private static int GetBucketNumber(TShirt shirt)  //
        {

            int bucketNumber = (int)shirt.Fabric;
            return bucketNumber;
        }


        private static int GetBucketNumberDescending(TShirt shirt, int fabriclength)  //
        {

            int bucketNumber = fabriclength - ((int)shirt.Fabric + 1); 
            return bucketNumber;
        }







        private static void InitializeBuckets(List<List<TShirt>> buckets)
        {
            var size = Enum.GetNames(typeof(Fabric)).Length;


            for (int i = 0; i < size; i++)
            {
                List<TShirt> a = new List<TShirt>();
                buckets.Add(a);
            }
        }






















    }
}
