using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Write a number and I'll tell you if is's a multiple of 10");

                string response = Console.ReadLine();

                if (Int32.TryParse(response, out int outVal))
                {


                    if(outVal % 10 == 0)
                    {
                        Console.WriteLine("It is a multiple of 10");

                    }

                    else
                    {
                        Console.WriteLine("It is not a multiple of 10");
                    }
                }

            }

        }
    }
}
