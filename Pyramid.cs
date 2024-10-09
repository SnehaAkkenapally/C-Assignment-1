namespace ConsoleApp2;

public class Pyramid
{
    
    public  void pyramid()
    {
        // Define the height of the pyramid
        int height = 5; // You can change this to adjust the pyramid height

        // Outer loop for each line
        for (int i = 1; i <= height; i++)
        {
            // Print spaces
            for (int j = height; j > i; j--)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            // Move to the next line after each row is printed
            Console.WriteLine();
        }
    }
}


//

