using System;
using System.IO;
using System.Text;

namespace NUMBER_PATTERN
{
    class Program
{
    public static void Main(string[] args)
    {
        // Hello! this morning we are going to write the number pattern Program
        // Previously We wrote the star (*) pattern program but we want to replace
        // the star (*) with numbers. 
        // so long as you were able to grasp the algorithm of the star program
        // we use the same algorithm but expects differents outcome

     // To begin with as always The Square Pattern
        // 1 1 1 1 1  
        // 1 1 1 1 1  
        // 1 1 1 1 1  
        // 1 1 1 1 1
        

        // we declare our variables for the program
        int numb = 10, row, col, p;
    {
        // this is the main outer loop responsible for printing the row pattern
        for(row = 0; row < numb; row++)
        {
            // this inner loop controls the column printing
            for(col = 0; col < numb; col++)
            {
                // this statement prints our object forming the pattern (*) (#) (@) (1)
                Console.Write("1 ");
            }
            // this statement is responsible for printing rows in each next line
            Console.WriteLine(" ");
        }
    }
    

    { // The Right-Angled Triangle
        // 1  
        // 1 1  
        // 1 1 1  
        // 1 1 1 1 

        for(row = 0; row < numb; row++)
        {
            for(col = 0; col < row; col++)
            {
                Console.Write("1 ");
            }
            Console.WriteLine(" ");
        }
    }

    { //The Right-Angled Triangle pattern printing its increament by 1 on a new row
        // with this we will introduce a new variable to do our increament and printing
        // 1  
        // 2 2  
        // 3 3 3  
        // 4 4 4 4 

        for(row = 0, p = 0; row < numb; row++, p++)
        {
            for(col = 0; col < row; col++)
            {
                Console.Write( p + " ");
            }
            Console.WriteLine(" ");
        }
    } 
            // this statement just spaces out my pattern
            // It does not join them together
            Console.WriteLine(" ");

    {   //inverted/decreasing Right-Angled Triangle

        // 4 4 4 4
        // 3 3 3 
        // 2 2  
        // 1
        for(row = 1, p = 9; row <numb; row++, p--)
        {
            for(col = row; col <numb; col++)
            {
                Console.Write( p + " ");
            }
            Console.WriteLine(" ");
        }
    }

    { // Increasing left-Angled Triangle
            //       1  
            //     2 2  
            //   3 3 3  
            // 4 4 4 4 

        for(row=0, p=0; row <numb; row++, p++)
        {
            for(col = row; col <numb; col++)
            {
                Console.Write("  ");
            }
            for(col=0; col < row; col++)
            {
                Console.Write( p + " ");
            }
            Console.WriteLine(" ");
        } 
    }

        Console.WriteLine(" ");
    {   // Decreasing/inverted Left-Angled Triangle 

            // 4 4 4 4  
            //   3 3 3  
            //     2 2  
            //       1
        for(row=1, p=9; row <=numb; row++,p--)
        {
            for(col=0; col < row; col++)
            {
                Console.Write("  ");
            }
            for(col=row; col < numb; col++)
            {
                Console.Write( p + " ");
            }
            Console.WriteLine(" ");
        }
    }

    {    // the pyramid

        
            //       1  
            //     2 2 2  
            //   3 3 3 3 3  
            // 4 4 4 4 4 4 4

// so here you can also initialize both row and p(start pattern) to 1 If 
//don't want to start at zero then release the '<=' in the inner first loop
// and its decreament as well 

        for(row =0, p=0; row <numb; row ++, p++)
        {
            for(col=row; col < numb; col++)
            {
                Console.Write("  ");
            }
// here this inner loop is reduced in order to escape the character 10
// since it is a double character(1,0) which will destroy the pyramid pattern
// at the base. 
            for(col=0; col <row; col ++)
            {
                Console.Write(p + " ");
            }
// here this inner loop is reduced in order to help me print a pointed edge pyramid
            for(col=0; col <row-1; col++)
            {
                Console.Write(p + " ");
            }
            Console.WriteLine(" ");
        }
    }

    {   // the Diamond pattern shape (This only prints starts)

                //       * 
                //     * * *  
                //   * * * * * 
                // * * * * * * *  
                //   * * * * * 
                //     * * * 
                //       *

        // my main for loop
        for(row=0; row < numb; row++)
        {
            for(col = row; col < numb; col++)
            {
                Console.Write("  ");
            }
            for(col =0; col < row; col++)
            {
                Console.Write("* ");
            }
            for(col =0; col < row-1; col++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("");
        }
        for(row=0; row < numb; row++)
        {
            for(col=0; col < row; col ++)
            {
                Console.Write("  ");
            }

            for(col=row; col < numb; col++)
            {
                Console.Write("* ");
            }
            for(col=row; col < numb-1; col++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("");
        }
    }
    { // The Butterfly PATTERN (STAR)
            // *             *   
            // * *         * *   
            // * * *     * * *    
            // * * * * * * * *  
            // * * *     * * *  
            // * *         * *
            // *             * 

        for(row = 0; row < numb; row++)
        {
            for(col = 0; col < row; col++)
            {
                Console.Write("* ");
            }
            
            for(col = row; col <numb; col++)
            {
                Console.Write("  ");
            }

            for(col = row; col <numb; col++)
            {
                Console.Write("  ");
            }

            for(col=0; col < row; col++)
            {
                Console.Write("* ");
            }

            Console.WriteLine(" ");
        }
        for(row=0; row < numb; row++)
        {
            for(col = row; col <numb; col++)
            {
                Console.Write("* ");
            }
            for(col=0; col < row; col++)
            {
                Console.Write("  ");
            }

            for(col=0; col < row; col++)
            {
                Console.Write("  ");
            }
            
            for(col = row; col <numb; col++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("");
        }

    }
        Console.WriteLine("\n");

    {   // I print the sand glass pattern
                // * * * * *
                //   * * *
                //     *
                //    * *
                //   * * *
                // * * * * * 

            for(row =0; row < numb; row++)
            {
                for(col=0; col < row; col++)
                {
                    Console.Write("  ");
                }
                for(col = row; col <numb; col++)
                {
                    Console.Write("* ");
                }// in order the hour glass to join, I add plus 1 to the numb here
                for(col = row; col <numb+1; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            for(row=0; row < numb; row++)
            {
                for(col=row; col < numb; col++)
                {
                    Console.Write("  ");
                }
                for(col=0; col < row; col++)
                {
                    Console.Write("* ");
                }// in order the hour glass to join, I add plus 1 to the row here
                //so it is both sides
                for(col=0; col < row+1; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
    }
        // this statement separates the Sand Glass Pattern from the Triple Mountains
            Console.WriteLine("\n");
    {   // The Triplet Mountains

        for(row =0; row < numb; row++)
        {
            for(col = row; col < numb; col++)
            {   
                Console.Write("  ");
            }
            for(col = 0; col <row; col++)
            {
                Console.Write("* ");
            }
            for(col =0; col <row+1; col++)
            {
                Console.Write("* ");
            }
            // these 2 for loops determines the shape of the second mountain
            for(col = row; col < numb; col++)
            {   
                Console.Write("  ");
            }
            // the other one!
            for(col = row; col < numb; col++)
            {   
                Console.Write("  ");
            }
            //these successive for loops draws 2nd mountain pattern
            for(col = 0; col <row; col++)
            {
                Console.Write("* ");
            }
            for(col =0; col <row+1; col++)
            {
                Console.Write("* ");
            }
            // Printing the 3rd mountain 
            // and as all ways we print the spaces first before the patterns
            for(col = row; col < numb; col++)
            {   
                Console.Write("  ");
            }
            for(col = row; col < numb; col++)
            {   
                Console.Write("  ");
            }
            //Printing the mountain pattern for the 3rd Mountain
            for(col = 0; col <row; col++)
            {
                Console.Write("* ");
            }
            for(col =0; col <row+1; col++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("");
        }
    }

}   
     
}

}