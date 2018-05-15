using System;


namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            int b = 0;
            string Number = Console.ReadLine();
            Console.WriteLine(Number);
            string[] c = Number.Split(' ');
            int input = Int32.Parse(c[0]);
            int input2 = Int32.Parse(c[1]);
            if (input > input2) 
            {
                input = Int32.Parse(c[1]);
                input2 = Int32.Parse(c[0]);
            }
            
            for (int _input = input; _input < input2; _input++)
            {
                int a = 1;
                int result = _input;
                while (result != 1)
                {
                    if (result % 2 == 0)
                    {
                        result = result / 2;
                        a = a + 1;
                    }
                    else
                    {
                        result = result * 3 + 1;
                        a = a + 1;
                    }  
                }

                if (b < a)
                {
                    b = a;
                }
            }

            Console.WriteLine(b);
            Console.Read();
        }
        
    }
}
