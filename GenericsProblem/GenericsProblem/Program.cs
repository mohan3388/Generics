namespace GenericsProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            //MaxNumber problem = new MaxNumber();
           

            bool check = true;
            Console.WriteLine("Welcome to Generics Problem");
            while(check)
            {
                Console.WriteLine("\n1.Maximum of Integer\n 2.Maximum of Float\n3. Maximum of String\n4.Refactor above 3 UC's\n5.More then three parameters\n6.extend All find max");
                int Option=Convert.ToInt32(Console.ReadLine());
                switch(Option)
                {
                    case 1:
                        MaxIntger problem = new MaxIntger();
                        //First Test case 
                        problem.FindMax(22, 15, 8);
                        //Second Test case
                        problem.FindMax(4, 28, 9);
                        //Third case
                        problem.FindMax(5, 10, 17);
                        break;
                        
                    case 2:
                        MaxFloat maxFloat = new MaxFloat();
                        //First Test case 
                        maxFloat.MaxInFloat(12.2f, 7.5f, 6.0f);
                        //Second Test case
                        maxFloat.MaxInFloat(7.5f,15.2f,6.0f);
                        //Third case

                        maxFloat.MaxInFloat(8.5f, 1.2f, 19.0f);
                        break;
                    case 3:
                        MaxString maxString = new MaxString();
                        maxString.MaxInString("Banana", "Apple", "Peach");
                        maxString.MaxInString("Apple", "Banana", "Peach");
                        maxString.MaxInString("Apple", "Peach", "Banana");
                        break;
                    case 4:
                        Refactor<int> refactor = new Refactor<int>();
                        refactor.FindMaxAll(8, 12, 16);
                        Refactor<float> refactor2 = new Refactor<float>();
                        refactor2.FindMaxAll(8.5f, 10.2f, 15.04f);
                        Refactor<string> refactor3 = new Refactor<string>();
                        refactor3.FindMaxAll("Apple", "Peach", "Banana");
                        break;
                    case 5:
                        FindMaxGenerics<int> find = new FindMaxGenerics<int>(10, 15, 20,9);
                        find.FindInMax();
                        FindMaxGenerics<float> find2 = new FindMaxGenerics<float>(10.1f, 18.22f, 15.55f,16.9f);
                        find2.FindInMax();
                        FindMaxGenerics<string> find3 = new FindMaxGenerics<string>("banana", "apple", "peach","pinapple");
                        find3.FindInMax();
                        break;
                    case 6:
                        ExtendAllMax extend = new ExtendAllMax();
                        extend.FindMax(15, 9, 27,14);
                        extend.MaxInFloat(15.7f, 6.4f, 28.9f,31.4f);
                        extend.MaxInString("banana", "apple", "peach", "pinapple");
                        break;
                }
            }
           
          
        }
    }
}
