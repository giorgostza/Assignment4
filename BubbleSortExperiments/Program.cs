using System;
using Assignment4;
using System.Linq;


public class Bubble_Sort
{
    public static void Main(string[] args)
    {

        MyDatabase db = new MyDatabase();

        View.PrintAllTShirts(db.TShirts,"Unsorted Tshirts");


        var a = db.TShirts.ToArray();


        TShirt temp;
        for (int p = 0; p <= a.Length - 2; p++)
        {
            for (int i = 0; i <= a.Length - 2; i++)
            {
                if (a[i].Size < a[i + 1].Size)  //Compare based on value
                {
                    temp = a[i + 1];
                    a[i + 1] = a[i]; 
                    a[i] = temp;
                }
            }
        }

        View.PrintAllTShirts(a.ToList(), "Sorted By Color");


    }
}
