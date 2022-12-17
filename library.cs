namespace MyLibrary
{
    class library
    {
        public static int[] MyCreateArray(int length = 10,int minValue = 0,int maxValue = 99){
            int[] arr = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = random.Next(minValue,maxValue+1);
            }
            return arr;
        }

        public static double[] MyCreateArray(int length = 9){
            double[] arr = new double[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = Math.Round((random.NextDouble() * 10), 2);
            }
            return arr;
        }

        public static int[,] MyCreateTwoDimensionalArray(int row = 5, int col = 5,int minValue = 0,int maxValue = 99){
            int[,] arr = new int[row,col];
            Random random = new Random();
            maxValue++;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i,j] = random.Next(minValue,maxValue);
                }
            }
            return arr;
        }    

        public static double[,] MyCreateTwoDimensionalArray(int row = 5, int col = 5, 
                                                            double fractionСoef = 10, int rounding = 2){
            double[,] arr = new double[row,col];
            Random random = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i,j] = Math.Round(random.NextDouble() * fractionСoef , rounding);
                }
            }
            return arr;
        }    



            public static void MyLookArray(int[] arr){
                int size = arr.Length;
                Console.WriteLine("Вывод массива:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i]+ ", ");
            }
            Console.WriteLine();
        }

        public static void MyLookArray(double[] arr){
                int size = arr.Length;
                Console.WriteLine("Вывод массива:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i]+ ", ");
            }
            Console.WriteLine();
        }

        public static void MyLookArray(string[] arr){
                int size = arr.Length;
                Console.WriteLine("Вывод массива:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i]+ ", ");
            }
            Console.WriteLine();
        }


        public static void MyLookTwoDimensionalArray(int[,] arr){
           
            int row = arr.GetLength(0);
            int col = arr.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i,j]+"\t");
                }
                Console.WriteLine();
            }
           Console.WriteLine();
        }    

        public static void MyLookTwoDimensionalArray(double[,] arr){
           
            int row = arr.GetLength(0);
            int col = arr.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i,j]+"\t");
                }
                Console.WriteLine();
            }
           Console.WriteLine();
        }    

        public static int MyReadCons(string message = "Введите число"){
            Console.WriteLine(message);
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        public static void MyRotationArray(int[] arr){
            
            int size = arr.Length;
            int j = size-1;
            for (int i = 0; i <size/2; i++)
            {
                (arr[i],arr[j])=(arr[j],arr[i]);
                j--;
            }
        }

    }
}