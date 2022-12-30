static void Main(string[] args)
        {

            int[,] array2d = new int[5, 8];
            //int[,] array2d = new int[3, 3];
            //int[,] array2d = new int[4, 4];
            Console.WriteLine("Массив из двузначных неповторяющихся чисел:");

            FillRandom(array2d, new Random());
            WriteArray2d(array2d);
        }


        private static void FillRandom(int[,] array2d, Random random)
        {
            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    int randNumber = random.Next(10, 100);

                    while (Array2dContains(array2d, randNumber))
                    {
                        randNumber = random.Next(10, 100);
                    }

                    array2d[i, j] = randNumber;

                }
            }

        }

        private static bool Array2dContains(int[,] array2d, int randNumber)
        {
            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    if (array2d[i, j] == randNumber)
                        return true;
                }
            }

            return false;
        }

        private static void WriteArray2d(int[,] array2d)
        {
            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    Console.Write(array2d[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

