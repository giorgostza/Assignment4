using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Pixel a = new Pixel();
            Pixel b = new Pixel(255,23,12);
            
            
            Console.WriteLine(a.Blue);
            Console.WriteLine(a.Red);
            Console.WriteLine(a.Green);

            Console.WriteLine(b.Blue);
            Console.WriteLine(b.Red);
            Console.WriteLine(b.Green);

        }
    }


    struct Pixel  //Basiki proipothesi se ena struct einai kathe FIELD i Property na arxikopoitai
    {
        public byte Red;
        public byte Blue;
        public byte Green;

        public Pixel(byte red,byte blue,byte green)
        {
            Red = red;
            Blue = blue;
            Green = green;
        }

        public Pixel( byte blue, byte green)
        {
            Red = new byte();
            Blue = blue;
            Green = green;
        }

    }


}
