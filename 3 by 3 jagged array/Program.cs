namespace _3_by_3_jagged_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] jag = new int[2, 3, 2]
            {
                {{1, 4}, {2, 7}, {9, 2} },
                {{4, 3}, {4, 0}, {2, 2} }
            };
            int[,,] jagged = new int[2, 3, 2]
            {
                {{1, 3}, {2, 5}, {3, 2} },
                {{5, 3}, {4, 10}, {2, 5} }
            };
            int [,,]multiply = new int[2, 3, 2];
            for (int i = 0; i < 2; i++) 
            {
                for (int j = 0; j < 3; j++) 
                {
                    for (int k = 0; k < 2; k++) 
                    {
                        multiply[i,j,k] = jag[i,j,k] * jagged[i, j, k];
                        
                        Console.WriteLine(multiply[i,j,k]);
                    }
                    
                }
            }

        }
    }
}