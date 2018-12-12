using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rotation
{
    class Program
    {
        const int n = 5;
        
        static void Main(string[] args)
        {
            string[,] matrix = buildMatrix();

            print(matrix);
            rotate( matrix);
          //  Console.Write(matrix);
            print(matrix);




        }


        public static string[,] rotate(string[,] matrix)
        {
            for(int layer = 0; layer<n/2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for(int i = first; i < last; i++)
                {
                    int offset = i - first;

                    string top = matrix[first,i];

                    //left -> top
                    matrix[first, i] = matrix[last - offset, first];

                    //bottom -> left
                    matrix[last - offset, first] = matrix[last, last - offset];

                    //right -> bottom
                    matrix[last, last - offset] = matrix[i, last];

                    //top -> right
                    matrix[i, last] = top;

                }
            }

            return matrix;
        }


            /*
            public static string[,] rotate( string[,] matrix)
            {
                int nprime = 0;
                for(int i=0; i < n; i++)
                {
                    nprime = n-i;

                    for(int j=i; j < n-i; j++)
                    {
                       if(j == i)
                       {

                            //0,0
                            string temp1 = matrix[i, j];
                            //0,4
                            string temp2 = matrix[i, n-1-j];
                            //4,4
                            string temp3 = matrix[n - 1 - i, n-1-j];
                            //4,0
                            string temp4 = matrix[n - i - 1, j];

                            matrix[i,j] = temp4;
                            matrix[i, n - 1 - j] = temp1;
                            matrix[n - 1 - i, n - 1 - j] = temp2;
                            matrix[n - i - 1, j] = temp3;


                        }
                        else if(j!=n-1 && j != 0)
                        {

                            //0,1
                            string temp1 = matrix[i, j];
                            //4,1
                            string temp2 = matrix[n - 1 - j, i];
                            //4,3
                            string temp3 = matrix[n - 1 - i, n - 1 - j];
                            //0,1
                            string temp4 = matrix[i, n - 1 - j];

                            matrix[i, j] = temp4;
                            matrix[n - 1 - j, i] = temp1;
                            matrix[n - 1 - i, n - 1 - j] = temp2;
                            matrix[i, n - 1 - j] = temp3;
                        }

                        //break;

                        //Console.Write(matrix[i, j] + "|");

                    }
                }

                return matrix;
            }
            */
            public static string[,] buildMatrix()
        {
            string[,] matrix = new string[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = i + "," + j;
                }
            }

            return matrix;
        }

        public static void print(string[,] m)
        {
            Console.WriteLine("-------------------------");
            for (int i = 0; i < n; i++)
            {
                Console.Write("|");
                for (int j = 0; j < n; j++)
                {
                    Console.Write(m[i, j] + "|");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("-------------------------");
        }
    }
}
