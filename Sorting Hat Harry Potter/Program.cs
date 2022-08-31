using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Hat_Harry_Potter
{
    class Program
    {
        static void Main(string[] args)
        {
            // sorting hat program fun
            // i will only evaluate the user on 1 trait and figure out where to send them from there
            // traits in question is - bravery, loyal, knowledge-seeking and powerhungry each corresponding to their houses, in that specific order

            SortingHat sh = new SortingHat();  

            bool run = true;
            while (run)  // while loop to test all cases 
            {
                Console.WriteLine("would you describe yourself as mostly brave, loyal, knowledge-seeking or power-hungry?");
                
                Console.WriteLine(sh.Sorting(Console.ReadLine())); // the sh.sorting method returns the answer in a string, thefore we just throw everything together and now it looks like im a good or something... just kidding

            }
            
        }
    }
}
