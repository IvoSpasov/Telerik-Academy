namespace _03_Calculations
{
    using System;
    using System.Text;

    public class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private T[,] matrixData;

        public Matrix(int numberOfRows, int numberOfColumns)
        {
            this.matrixData = new T[numberOfRows, numberOfColumns];
        }

        public Matrix(T[,] yourMatrix)
        {
            this.matrixData = yourMatrix;
        }

        //indexer
        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || row > this.matrixData.GetLength(0))
                {
                    throw new IndexOutOfRangeException("Rows index out of range.");
                }

                if (col < 0 || col > this.matrixData.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Columns index out of range");
                }

                return this.matrixData[row, col];
            }
            set
            {
                if (row < 0 || row > this.matrixData.GetLength(0))
                {
                    throw new IndexOutOfRangeException("Rows index out of range.");
                }

                if (col < 0 || col > this.matrixData.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Columns index out of range");
                }

                this.matrixData[row, col] = value;
            }
        }

        //operator overloading
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.matrixData.GetLength(0) != secondMatrix.matrixData.GetLength(0) ||
                firstMatrix.matrixData.GetLength(1) != secondMatrix.matrixData.GetLength(1))
            {
                throw new InvalidOperationException("The matrices have different size.");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.matrixData.GetLength(0), firstMatrix.matrixData.GetLength(1));

            for (int row = 0; row < result.matrixData.GetLength(0); row++)
            {
                for (int col = 0; col < result.matrixData.GetLength(1); col++)
                {
                    result[row, col] = (dynamic)firstMatrix[row, col] + secondMatrix[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.matrixData.GetLength(0) != secondMatrix.matrixData.GetLength(0) ||
                firstMatrix.matrixData.GetLength(1) != secondMatrix.matrixData.GetLength(1))
            {
                throw new InvalidOperationException("The matrices have different size.");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.matrixData.GetLength(0), firstMatrix.matrixData.GetLength(1));

            for (int row = 0; row < result.matrixData.GetLength(0); row++)
            {
                for (int col = 0; col < result.matrixData.GetLength(1); col++)
                {
                    result[row, col] = (dynamic)firstMatrix[row, col] - secondMatrix[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.matrixData.GetLength(1) != secondMatrix.matrixData.GetLength(0))
            {
                throw new InvalidOperationException("The two matrices can not be multiplied.");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.matrixData.GetLength(0), secondMatrix.matrixData.GetLength(1));

            for (int resultRow = 0; resultRow < result.matrixData.GetLength(0); resultRow++)
            {
                for (int resultCol = 0; resultCol < result.matrixData.GetLength(1); resultCol++)
                {
                    for (int rowOrCol = 0; rowOrCol < firstMatrix.matrixData.GetLength(1); rowOrCol++)
                    {
                        result[resultRow, resultCol] += (dynamic)firstMatrix[resultRow, rowOrCol] * secondMatrix[rowOrCol, resultCol];
                    }
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> testMatrix)
        {
            for (int row = 0; row < testMatrix.matrixData.GetLength(0); row++)
            {
                for (int col = 0; col < testMatrix.matrixData.GetLength(1); col++)
                {
                    if ((dynamic)testMatrix[row, col] != 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> testMatrix)
        {
            for (int row = 0; row < testMatrix.matrixData.GetLength(0); row++)
            {
                for (int col = 0; col < testMatrix.matrixData.GetLength(1); col++)
                {
                    if ((dynamic)testMatrix[row, col] != 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.matrixData.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrixData.GetLength(1); col++)
                {
                    result.Append(this.matrixData[row, col] + ", ");
                }
                result.AppendLine("\b\b ");
            }
            return result.ToString();
        }

    }
}
