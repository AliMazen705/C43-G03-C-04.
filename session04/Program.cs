namespace session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //Console.WriteLine("Enter the coordinates of the first point (x1, y1):");
            //double.TryParse(Console.ReadLine(), out double x1);
            //double.TryParse(Console.ReadLine(), out double y1);

            //Console.WriteLine("Enter the coordinates of the second point (x2, y2):");
            //double.TryParse(Console.ReadLine(), out double x2);
            //double.TryParse(Console.ReadLine(), out double y2);

            //Console.WriteLine("Enter the coordinates of the third point (x3, y3):");
            //double.TryParse(Console.ReadLine(),out double x3);
            //double.TryParse(Console.ReadLine(), out double y3);

            //comments
            // (y2 - y1) / (x2 - x1) == (y3 - y1) / (x3 - x1)
            // To avoid division by zero, cross-multiply:
            // (y2 - y1) * (x3 - x1) == (y3 - y1) * (x2 - x1)

            //if ((y2 - y1) * (x3 - x1) == (y3 - y1) * (x2 - x1))
            //    Console.WriteLine("The points lie on a single straight line.");

            //else
            //    Console.WriteLine("The points do not lie on a single straight line.");

            #endregion

            #region q2
            //Console.Write("What The Time Taken For The Task In Hours: ");
            //double.TryParse(Console.ReadLine(), out double time);
            //if (time >= 2 && time < 3)
            //    Console.WriteLine("The worker is highly efficient");
            //else if (time >= 3 && time < 4)
            //    Console.WriteLine("The worker needs to improve speed.");
            //else if (time >= 4 && time <= 5)
            //    Console.WriteLine("The worker requires training to improve speed.");
            //else if (time > 5)
            //    Console.WriteLine("The worker needs to leave the company");
            //else
            //    Console.WriteLine("Invalid input. Please enter a time greater than or equal to 2 hours");

            #endregion q

            #region q3
            //Console.Write("Enter Size The Matrix(n * n): ");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[,] matrix = new int[size, size];
            //if (size <= 0)
            //    Console.WriteLine("Invalid Input");
            //else
            //{
            //    for (int i = 0; i < size; i++)
            //    {
            //        for (int j = 0; j < size; j++)
            //        {
            //            Console.Write($"{j + 1} ");
            //        }
            //        Console.WriteLine();
            //    }
            //}

            #endregion

            #region q20
            //Console.Write("Enter Size Of The Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //if(size <= 0)
            //    Console.WriteLine("Invaild Input ");
            //else
            //{

            //    int[] arr = new int[size];
            //    int sum = 0;
            //    Console.WriteLine("Enter The Elements Of The Array: ");
            //    for(int i = 0 ; i < arr.Length; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1} ==> ");
            //        arr[i] = int.Parse(Console.ReadLine());

            //        sum += arr[i];

            //    }
            //    Console.WriteLine($"The Sum Of All Element In The Array Is --> {sum}");
            //}
            #endregion

            #region q21
            //Console.Write("Enter Size Of The Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //if (size <= 0)
            //    Console.WriteLine("Invaild Input ");
            //else
            //{
            //    int[] arr01 = new int[size];
            //    Console.WriteLine("Enter The Elements Of The 1st Array: ");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1} ==> ");
            //        arr01[i] = int.Parse(Console.ReadLine());

            //    }
            //    int[] arr02 = new int[size];
            //    Console.WriteLine("Enter The Elements Of The 2nd Array: ");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1} ==> ");
            //        arr02[i] = int.Parse(Console.ReadLine());

            //    }

            //    int index1 = 0, index2 = 0, indexmer = 0;
            //    int[] merge = new int[size * 2];

            //    while (index1 < size && index2 < size)
            //    {
            //        if (arr01[index1] < arr02[index2])
            //        {
            //            merge[indexmer++] = arr01[index1++];
            //        }
            //        else
            //        {
            //            merge[indexmer++] = arr02[index2++];
            //        }

            //    }
            //    // Add remaining elements from array01
            //    while (index1 < size)
            //    {
            //        merge[indexmer++] = arr01[index1++];
            //    }

            //    // Add remaining elements from array02
            //    while (index2 < size)
            //    {
            //        merge[indexmer++] = arr02[index2++];
            //    }
            //    Console.WriteLine("The merged array in ascending order is:");
            //    foreach (int i in merge)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //    Console.WriteLine();

            //}
            #endregion

            #region q22
            //Console.Write("Enter Size Of The Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //if (size <= 0)
            //    Console.WriteLine("Invaild Input ");
            //else
            //{
            //    int[] arr03 = new int[size];
            //    Console.WriteLine("Enter The Elements Of The Array: ");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1} ==> ");
            //        while (!(int.TryParse(Console.ReadLine(), out arr03[i])))
            //            Console.WriteLine("Please Enter An Integer");   
            //    }
            //    bool[] visited = new bool[size]; // Array to keep track of visited elements

            //    Console.WriteLine("\nFrequency of Each Element:");
            //    for (int i = 0; i < size; i++)
            //    {
            //        if (visited[i]) 
            //            continue;

            //        int count = 1; 
            //        for (int j = i + 1; j < size; j++)
            //        {
            //            if (arr03[i] == arr03[j])
            //            {
            //                count++;
            //                visited[j] = true;
            //            }
            //        }

            //        Console.WriteLine($"Element {arr03[i]} occurs {count} time(s).");
            //    }
            //}

            #endregion

            #region q23
            //Console.Write("Enter Size Of The Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //if (size <= 0)
            //    Console.WriteLine("Invaild Input ");
            //else
            //{
            //    int[] arr04 = new int[size];
            //    Console.WriteLine("Enter The Elements Of The Array: ");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1} ==> ");
            //        while (!(int.TryParse(Console.ReadLine(), out arr04[i])))
            //            Console.WriteLine("Please Enter An Integer");
            //    }
            //    Console.WriteLine($"Maximum Number In Array --> {arr04.Max()}");
            //    Console.WriteLine($"Minimum Number In Array --> {arr04.Min()}");

            //}
            #endregion

            #region q24
            //Console.Write("Enter Size Of The Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //if (size < 2)
            //    Console.WriteLine("Invaild Input ");
            //else
            //{
            //    int[] arr05 = new int[size];
            //    Console.WriteLine("Enter The Elements Of The Array: ");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1} ==> ");
            //        while (!(int.TryParse(Console.ReadLine(), out arr05[i])))
            //            Console.WriteLine("Please Enter An Integer");
            //    }
            //    int[] ndLargest = new int[size - 1];
            //    for (int i = 0;i < size - 1;i++)
            //    {
            //        if (arr05[i] == arr05.Max())
            //            continue;
            //        else
            //            ndLargest[i] = arr05[i];
            //    }
            //    Console.WriteLine($"The Second Largest Element In An Array --> {ndLargest.Max()}");
            //}
            #endregion

            #region q25
            //Console.Write("Enter Size Of The Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //if (size < 1)
            //    Console.WriteLine("Invaild Input ");
            //else
            //{
            //    int[] arr06 = new int[size];
            //    Console.WriteLine("Enter The Elements Of The Array: ");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1} ==> ");
            //        while (!(int.TryParse(Console.ReadLine(), out arr06[i])))
            //            Console.WriteLine("Please Enter An Integer");
            //    }
            //    int MaxDistance = 0;
            //    for (int i = 0; i < size; i++)
            //    {
            //        for (int j = size - 1; j > 0; j--)
            //        {
            //            if (arr06[i] == arr06[j])
            //            {
            //                int distance = j - i;
            //                if (distance > MaxDistance) 
            //                {
            //                    MaxDistance = distance;
            //                }
            //            }

            //        }

            //    }
            //    Console.WriteLine($"The Longest Distance Between Two Equal Elements Is: {MaxDistance}");
            //}

            #endregion

            #region q26
            //Console.Write("Enter The Words: ");
            //string word = Console.ReadLine();
            //string[] text = word.Split();
            //text = text.Reverse().ToArray();
            //string reverse = string.Join(" ", text);  //// Join(string separator, params obj[] array)
            //Console.WriteLine($"Reversed Words: {reverse}");
            #endregion

            #region q27
            //Console.Write("Enter Size Of Row: ");
            //bool r = int.TryParse(Console.ReadLine(), out int row);
            //Console.Write("Enter Size Of Column: ");
            //bool c = int.TryParse(Console.ReadLine(), out int column);

            //if(!c && !r || row <= 0 || column <= 0)
            //    Console.WriteLine("Please Enter Valid Positive Integers For Rows And Columns");
            //else
            //{
            //    int[,] multidimensional = new int[row, column];
            //    for(int i = 0; i < row; i++)
            //    {
            //        for (int j = 0; j < column; j++)
            //        {
            //            Console.Write($"\nEnter element [{i + 1}, {j + 1}]: ");
            //            multidimensional[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }
            //    int[,]code = new int[row, column];
            //    for (int i = 0; i < row; i++)
            //    {
            //        for (int j = 0; j < column; j++)
            //        {
            //            code[i, j] = multidimensional[i, j];
            //        }
            //    }
            //    Console.WriteLine("=======================Output================================");

            //    for (int i = 0;i < row; i++)
            //    {
            //        for(int j = 0;j < column; j++)
            //            Console.WriteLine($"The Element [{i + 1}, {j + 1}]: = {code[i,j]}");
            //    }
            //}
            #endregion

            #region q28
            //Console.Write("Enter Size Of The Array: ");
            //bool sizeCon = int.TryParse(Console.ReadLine(), out int size);
            //if(! sizeCon || size <= 0)
            //    Console.WriteLine("Please Enter Valid Positive Integers For Rows And Columns");
            //else
            //{
            //    int[] arr07 = new int[size];
            //    int[] Reverse00 = new int[size];
            //    Console.WriteLine("Enter The Elements Of The Array: ");
            //    for (int i = 0; i < arr07.Length; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1}: ");
            //        arr07[i] = int.Parse(Console.ReadLine());
            //    }
            //    for (int i = 0; i < Reverse00.Length; i++)
            //    {
            //        Reverse00[i] = arr07[arr07.Length - 1 - i];
            //    }
            //    Console.WriteLine("Array in Reverse Order: ");
            //    foreach (int i in Reverse00)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            #endregion
        }
    }
}
