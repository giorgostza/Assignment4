using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.SortingAlgorithms
{
    public class BubbleSort
    {
        public static void OrderBySizeAscending(List<TShirt> shirts)
        {
            TShirt temp;
            for (int p = 0; p <= shirts.Count - 2; p++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (shirts[i].Size > shirts[i + 1].Size)  //Compare based on value
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }
        }

        public static void OrderBySizeDescending(List<TShirt> shirts)
        {
            TShirt temp;
            for (int p = 0; p <= shirts.Count - 2; p++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (shirts[i].Size < shirts[i + 1].Size)  //Compare based on value
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }
        }

        public static void OrderBySizeColorFabriceAscending(List<TShirt> shirts)
        {
            TShirt temp;
            for (int p = 0; p <= shirts.Count - 2; p++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (shirts[i].Fabric > shirts[i + 1].Fabric)  //Compare based on value
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }

                    if (shirts[i].Color > shirts[i + 1].Color)  //Compare based on value
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }

                    if (shirts[i].Size > shirts[i + 1].Size)  //Compare based on value
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }


                }
            }
        }


        public static void OrderBySizeColorFabriceDescending(List<TShirt> shirts)
        {
            TShirt temp;
            for (int p = 0; p <= shirts.Count - 2; p++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (shirts[i].Fabric < shirts[i + 1].Fabric)  //Compare based on value
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }

                    if (shirts[i].Color < shirts[i + 1].Color)  //Compare based on value
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }

                    if (shirts[i].Size < shirts[i + 1].Size)  //Compare based on value
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }


                }
            }
        }


    }
}
