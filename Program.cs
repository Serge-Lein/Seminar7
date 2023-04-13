// int[,] CreateRandomArray2d()
// {
//     System.Console.WriteLine("Input a quantity of rows: ");
// int rows = Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine("Input a quantity of colomns: ");
// int colomns = Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine("Input a min possible value: ");
// int minValue = Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine("Input a max possible value: ");
// int maxValue = Convert.ToInt32(System.Console.ReadLine());

//     int[,] array = new int[rows, colomns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < colomns; j++)
//             array [i,j] = new Random().Next(minValue, maxValue);

//     return array;        
// }


// void ShowArray2d(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i,j]} ");
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }




// int[,] myArray = CreateRandomArray2d();
// ShowArray2d(myArray);






// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.



// int[,] ArrayIplusJ()
// {
//      System.Console.WriteLine("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(System.Console.ReadLine());

//     System.Console.WriteLine("Input a quantity of colomns: ");
//     int colomns = Convert.ToInt32(System.Console.ReadLine());


//     int[,] array = new int[rows,colomns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < colomns; j++)
//             array[i,j] = i+j;
//     return array;
// }

// void ShowArray2d(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i,j]} ");
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// ShowArray2d(ArrayIplusJ());





// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.



// int[,] CreateRandomArray2d()
// {
//     System.Console.WriteLine("Input a quantity of rows: ");
// int rows = Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine("Input a quantity of colomns: ");
// int colomns = Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine("Input a min possible value: ");
// int minValue = Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine("Input a max possible value: ");
// int maxValue = Convert.ToInt32(System.Console.ReadLine());

//     int[,] array = new int[rows, colomns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < colomns; j++)
//             array [i,j] = new Random().Next(minValue, maxValue);

//     return array;        
// }

// int[,] EvenIndexToPow2(int[,] array)
// {
//     int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
//     for(int i = 0; i < array.GetLength(0); i++)
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             newArray[i, j] = array[i,j];
//             if(i % 2 == 0 && j % 2 == 0)
//             {
//                 newArray[i,j] = array[i,j] * array[i,j];
//             }

//         }
//         return newArray;
// }

// void ShowArray2d(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i,j]} ");
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] array = CreateRandomArray2d();
// ShowArray2d(array);
// ShowArray2d(EvenIndexToPow2(array));




// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


// int[,] CreateRandomArray2d()
// {
//     System.Console.WriteLine("Input a quantity of rows: ");
// int rows = Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine("Input a quantity of colomns: ");
// int colomns = Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine("Input a min possible value: ");
// int minValue = Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine("Input a max possible value: ");
// int maxValue = Convert.ToInt32(System.Console.ReadLine());

//     int[,] array = new int[rows, colomns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < colomns; j++)
//             array [i,j] = new Random().Next(minValue, maxValue);

//     return array;        
// }

// int SumDiagArray2D(int [,] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.GetLength(0) || i < array.GetLength(1); i++)
//         sum += array[i,i];
//     return sum;
// }

// int[,] array = CreateRandomArray2d();

// void ShowArray2d(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i,j]} ");
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }
// ShowArray2d(array);
// Console.WriteLine(SumDiagArray2D(array));












