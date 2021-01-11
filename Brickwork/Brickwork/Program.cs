using System;
using System.Linq;

namespace Brickwork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read the dimensions
            int[] line = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            //Rows    
            int rows = line[0];
            //Columns
            int cols = line[1];

            //Creation of the matrix
            int[,] matrix = new int[rows, cols];

            //Validations
            if (rows > 1 && cols > 1 && rows < 100 && cols < 100 && rows % 2 == 0 && cols % 2 == 0)
            {


                for (int row = 0; row < rows; row++)
                {
                    //Fill the matrix with the numbers
                    int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = numbers[col];

                    }
                }


                //Starting the second layer
                for (int i = 0; i < rows; i++)
                {
                    for (int y = 0; y < cols; y += 2)
                    {
                        //First number of the first brick
                        int a = matrix[i, y];



                        if (cols > 2 && matrix[i, y] == matrix[i, y + 1] && y + 2 < cols && matrix[i, y + 2] == matrix[i, y + 3] && i < rows - 1)
                        {
                            //First number of the second brick
                            int b = matrix[i, y + 3];
                            //First number of the first brick on the second row
                            int c = matrix[i + 1, y];
                            //First number of the second brick on the second row
                            int d = matrix[i + 1, y + 2];

                            if (y + 3 == cols - 1)
                            {
                                matrix[i, y + 2] = a;
                                matrix[i, y] = b;
                                matrix[i + 1, y + 2] = c;
                                matrix[i, y + 3] = d;
                                matrix[i + 1, y] = b;

                            }

                        }
                    }
                }

                //Print the result
                for (int row = 0; row < matrix.GetLength(0); row++)
                {


                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write("{0} ", matrix[row, col]);

                    }

                    Console.WriteLine();
                }
            }

            else
            {
                Console.WriteLine("Error");

            }


        }
    }
}
