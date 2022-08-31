using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Hat_Harry_Potter
{
    class SortingHat
    {   // I am to make a sorting hat (from harry potter), and to supposedly just give the user a house. 
        // i will say, due to unspecification of requirements on this task, i.e there is not specified whether or not to have any reason to send kids to specific houses
        // i am going not going to spend 10 hours on this assignement, even if it is supposed to work my skills in predicting the uncertainty in the missing information (in this case requirements)

        private string sorted;
        public enum hogwarts
        {
            Gryffindor,
            Hufflepuff,
            Ravenclaw,
            Slitherin
        }


        public string Sorting(string trait)  // we make a sorting method to figure out where to send kids dependant on their answer of their trait
        {
            switch (trait)
            {
                case "brave":
                    sorted = hogwarts.Gryffindor.ToString();
                    break;
                case "loyal":
                    sorted = hogwarts.Hufflepuff.ToString();
                    break;
                case "knowledge-seeking":
                    sorted = hogwarts.Ravenclaw.ToString();
                    break;
                case "power-hungry":
                    sorted = hogwarts.Slitherin.ToString();
                    break;
                default:
                    sorted = "your answer is case sensitive, please try again";
                    break;
            }

            return sorted;
        }

        
    }
}
