using System;

namespace ArrayDimensions
{

    /*After watching a video by Jaime King about multi dimensional arrays
     * I wanted to explore the idea more. The code below will more than
     * likely be a mash-up of ridiculous code experiments meant to test
     * limits of some OOP concepts
     */

    class Program
    {
        static void Main(string[] args)
        {
            //Nothing Special
            int[] basicArray = new int[] { 5, 22, 68, 42, 36 };

            //Slightly more special square array
            int[][] multiArray = new int[3][];
            multiArray[0] = new int[] { 2,5,8,3,6,9 };
            multiArray[1] = new int[] { 9,6,3,8,5,2 };
            multiArray[2] = new int[] { 1,4,7,2,5,8 };

            /*Oh no this doesn't work! You can't daisy chain multi dimensional arrays 
             * togther. It seems that the compiler won't let you store a refernce to 
             * another MD array. I don't fully understand why this is the case, but I'm
             * sure it will come to me. My original thinking was that the array holding 
             * pointers to other arrays wouldnt care about the diminsions of the arrays 
             * it was pointing to... obviously I was wrong lol.
             
            int[][] multilvl1 = new int[2][];

            int[][] multilvl21 = new int[2][];
            int[][] multilvl22 = new int[2][];

            multilvl1[0] = multilvl21;
            multilvl1[1] = multilvl22;
            */

            /*This is the "correct" ridiculous implementation of what I wanted to explore.
             * If I give the top level a third dimension, I'm allowed to store a second set
             * of multi dimensional arrays and I get the desired affect
            */
             
            int[][][] multilvl1 = new int[2][][];

            int[][] multilvl21 = new int[2][];
            int[][] multilvl22 = new int[2][];

            multilvl1[0] = multilvl21;
            multilvl1[1] = multilvl22;
        }
    }
}
