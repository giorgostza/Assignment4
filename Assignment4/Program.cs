
using Assignment4.SortingAlgorithms;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDatabase db = new MyDatabase();
            //View.PrintAllTShirts(db.TShirts.OrderBy(x => x.Size).ToList(), "All Shirts");
            //View.PrintAllTShirts(db.TShirts.OrderBy(x => x.Fabric).ToList(), "All Shirts");
            //View.PrintAllTShirts(db.TShirts.OrderBy(x => x.Color).ToList(), "All Shirts");

            //View.PrintAllTShirts(db.TShirts.OrderByDescending(x => x.Size).ToList(), "All Shirts");
            //View.PrintAllTShirts(db.TShirts.OrderByDescending(x => x.Fabric).ToList(), "All Shirts");
            //View.PrintAllTShirts(db.TShirts.OrderByDescending(x => x.Color).ToList(), "All Shirts");

            //View.PrintAllTShirts(db.TShirts.OrderByDescending(x => x.Size).ThenBy(x => x.Color).ThenByDescending(x=>x.Fabric).ToList(), "All Shirts ordered by size Descending then by Color");

            string choice;
            var shirts = db.TShirts;
            do
            {
                
                Console.WriteLine("Choose Algorithm");
                Console.WriteLine("1 - Ordered By Size Ascending with Bubble Sort");
                Console.WriteLine("2 - Ordered By Size Descending with Bubble Sort");
                Console.WriteLine("3 - Ordered By Color Ascending with Quick Sort");
                Console.WriteLine("4 - Ordered By Color Descending with Quick Sort");
                Console.WriteLine("5 - Ordered By Fabric Ascending with Bucket Sort");
                Console.WriteLine("6 - Ordered By Fabric Descending with Bucket Sort");
                Console.WriteLine("7 - Ordered By Size Color Fabric Ascending with Bubble Sort");
                Console.WriteLine("8 - Ordered By Size Color Fabric Descending with Bubble Sort");
                Console.WriteLine("E - For Exit");

                choice = Console.ReadLine();
                string message="";
                Console.Clear();
                if (choice == "1")
                {
                    BubbleSort.OrderBySizeAscending(shirts);
                    message = "Ordered By Size Ascending with Bubble Sort";
                }
                else if (choice == "2")
                {
                    BubbleSort.OrderBySizeDescending(shirts);
                    message = "Ordered By Size Descending with Bubble Sort";
                }
                else if (choice == "3")
                {
                    QuickSort.OrderByColorAscending(shirts,0,shirts.Count-1);
                    message = "Ordered By Color Ascending with Quick Sort";
                }
                else if (choice == "4")
                {
                    QuickSort.OrderByColorDescending(shirts,0,shirts.Count-1);
                    message = "Ordered By Color Descending with Quick Sort";
                }
                else if (choice == "5")
                {
                    BucketSort.OrderByFabricAscending(shirts);
                    message = "Ordered By Fabric Ascending with Bucket Sort";
                }
                else if (choice == "6")
                {
                    BucketSort.OrderByFabricDescending(shirts);
                    message = "Ordered By Fabric Descending with Bucket Sort";
                }
                else if (choice == "7")
                {
                    BubbleSort.OrderBySizeColorFabriceAscending(shirts);
                    message = "Ordered By Size Color Fabric Ascending with Bubble Sort";
                }
                else if (choice == "8")
                {
                    BubbleSort.OrderBySizeColorFabriceDescending(shirts);
                    message = "Ordered By Size Color Fabric Descending with Bubble Sort";
                }
                else if (choice !="E" && choice != "e")
                {
                    Console.WriteLine("Wrong Choice!!");
                    continue;
                }


                if (choice != "E" && choice != "e")
                {
                    View.PrintAllTShirts(shirts, message);
                    
                }
               
               

            } while (choice !="E" && choice != "e");


        }
    }
}
