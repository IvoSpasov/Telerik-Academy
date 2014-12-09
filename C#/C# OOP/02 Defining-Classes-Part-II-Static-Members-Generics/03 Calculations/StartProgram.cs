namespace _03_Calculations
{
    using System;
    using _04_Attributes;

    [Version(4.32)]
    public class StartProgram
    {
        static void Main()
        {
            var firstMatrix = new Matrix<int>(2, 3);
            firstMatrix[0, 0] = 0;
            firstMatrix[0, 1] = 1;
            firstMatrix[0, 2] = 2;
            firstMatrix[1, 0] = -9;
            firstMatrix[1, 1] = 8;
            firstMatrix[1, 2] = -7;

            var secondMatrix = new Matrix<int>(2, 3);
            secondMatrix[0, 0] = 6;
            secondMatrix[0, 1] = 5;
            secondMatrix[0, 2] = 4;
            secondMatrix[1, 0] = 3;
            secondMatrix[1, 1] = -4;
            secondMatrix[1, 2] = -5;

            var result = firstMatrix + secondMatrix;

            Console.WriteLine("First matrix:");
            Console.WriteLine(firstMatrix);
            Console.WriteLine("Second matrix:");
            Console.WriteLine(secondMatrix);
            Console.WriteLine("The result after adding the first matrix with the second one:");
            Console.WriteLine(result);

            result = firstMatrix - secondMatrix;
            Console.WriteLine("The result after subtracting the first matrix with the second one:");
            Console.WriteLine(result);

            var thirdMatrix = new Matrix<int>(3, 2);
            thirdMatrix[0, 0] = 4;
            thirdMatrix[0, 1] = 8;
            thirdMatrix[1, 0] = 0;
            thirdMatrix[1, 1] = 2;
            thirdMatrix[2, 0] = 1;
            thirdMatrix[2, 1] = 6;

            var fourthMatrix = new Matrix<int>(2, 2);
            fourthMatrix[0, 0] = 5;
            fourthMatrix[0, 1] = 2;
            fourthMatrix[1, 0] = 9;
            fourthMatrix[1, 1] = 4;

            Console.WriteLine("Third matrix:");
            Console.WriteLine(thirdMatrix);
            Console.WriteLine("Fourth matrix:");
            Console.WriteLine(fourthMatrix);

            Console.WriteLine("The result after multipying the third matrix with the fourht one:");
            result = thirdMatrix * fourthMatrix;
            Console.WriteLine(result);

            var A = new Matrix<int>(1, 3);
            A[0, 0] = 1;
            A[0, 1] = 4;
            A[0, 2] = 6;

            var B = new Matrix<int>(3, 2);
            B[0, 0] = 2;
            B[0, 1] = 3;
            B[1, 0] = 5;
            B[1, 1] = 8;
            B[2, 0] = 7;
            B[2, 1] = 9;

            Console.WriteLine("Another example:");
            Console.WriteLine("Matrix A:");
            Console.WriteLine(A);
            Console.WriteLine("Matrix B");
            Console.WriteLine(B);
            Console.WriteLine("Result A*B");
            Console.WriteLine(A * B);

            Console.WriteLine("Are there any matices with only zeros in it?");
            Console.WriteLine("First matrix: {0}", firstMatrix ? "yes" : "no");
            Console.WriteLine("Second matrix: {0}", secondMatrix ? "yes" : "no");
            Console.WriteLine("Third matrix: {0}", thirdMatrix ? "yes" : "no");
            Console.WriteLine("Fourth matrix: {0}", fourthMatrix ? "yes" : "no");
            Console.WriteLine("Matrix A: {0}", A ? "yes" : "no");
            Console.WriteLine("Matrix B: {0}", B ? "yes" : "no");

            var C = new Matrix<double>(5, 2);
            Console.WriteLine("Matrix C: {0}", C ? "yes" : "no");

        }
    }
}
