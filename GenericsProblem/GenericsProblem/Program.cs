namespace GenericsProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            MaxNumber problem = new MaxNumber();
           

            bool check = true;
            Console.WriteLine("Welcome to Generics Problem");
            while(check)
            {
                Console.WriteLine("\n1.Maximum of Integer\n 2.Maximum of Float\n");
                int Option=Convert.ToInt32(Console.ReadLine());
                switch(Option)
                {
                    case 1:
                        //First Test case 
                        problem.FindMax(22, 15, 8);
                        //Second Test case
                        problem.FindMax(4, 28, 9);
                        //Third case
                        problem.FindMax(5, 10, 17);
                        break;
                    case 2:
                        //First Test case 
                        problem.MaxFloat(12.2f, 7.5f, 6.0f);
                        //Second Test case
                        problem.MaxFloat(7.5f,15.2f,6.0f);
                        //Third case

                        problem.MaxFloat(8.5f, 1.2f, 19.0f);
                        break;
                }
            }
           
          
        }
    }
}