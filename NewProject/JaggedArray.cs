namespace NewProject
{
     class JaggedArray{

      public  static void SumJagged(){
        Console.WriteLine("Enter the number of Rows for the matrix");
            _ = int.TryParse(Console.ReadLine(), out int rows);
            int[][] first = new int[rows][];
        int[][] second = new int[rows][];
        int[][] sum = new int[rows][];


            Console.WriteLine($"For Matrix first ");

        for(int i = 0; i < rows; i++){
            Console.WriteLine($"Enter the size of Row {i + 1} ");
            _ = int.TryParse(Console.ReadLine(), out int size);
            first[i] = new int[size];
            second[i] = new int[size];
            sum[i] = new int[size];

            for(int j = 0; j < size; j++){
                Console.WriteLine($"Enter the element for first[{i}][{j}]");
                _ = int.TryParse(Console.ReadLine(), out  first[i][j]);

            }
        }
            Console.WriteLine();

            Console.WriteLine($"For Matrix second ");
            for(int i = 0; i < rows; i++){
            for(int j = 0; j < second[i].Length; j++){
                Console.WriteLine($"Enter the element for second[{i}][{j}]");
                _ = int.TryParse(Console.ReadLine(), out  second[i][j]);
                sum[i][j] = second[i][j] + first[i][j];

            }
        }
            Console.WriteLine("The Sum Matrix is ");


              for(int i = 0; i < rows; i++){
            for(int j = 0; j < second[i].Length; j++){
                Console.Write($"{sum[i][j]} ");

            }
            Console.WriteLine();
        }



        }
   

    }

}