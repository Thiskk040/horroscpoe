using System;

namespace horrorscope
{
    class Program
    {
        
           
        static void Main(string[] args)
        {
            startprogram();
           
        }
        static void startprogram()
        {
            Console.Write("Horror-scope programming");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press 1 = Start the programming ");
            Console.WriteLine("Press 2 = Exit the program");
            Console.Write("Ans : ");
            int programming = int.Parse(Console.ReadLine());

            if (programming == 1)
            {
                startfunction();
            }
           else if(programming == 2)
            {
                for (int a = 5; a >= 0; a--)
                {
                    Console.Write("\r Program will exit in {0:00}", a);
                    System.Threading.Thread.Sleep(1000);   
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Goodbye !!!");
                
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
        static void startfunction()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 5);
            Console.Write("Please input yourname :");
            String username = Console.ReadLine();
            Console.Write("Please input your day bitrh : ");
            String daybirth = Console.ReadLine();


            if (daybirth == "Monday")
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 2:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 3:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 4:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 5:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                }
            }
            else if (daybirth == "Tuesday")
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 2:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 3:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 4:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 5:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                }
            }
            else if (daybirth == "Wednesday")
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 2:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 3:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 4:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 5:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                }
            }
            else if (daybirth == "Thursday")
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 2:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 3:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 4:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 5:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                }
            }
            else if (daybirth == "Friday")
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 2:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 3:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 4:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 5:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                }
            }
            else if(daybirth  == "Satursday")
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 2:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 3:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 4:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 5:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                }
            }
            else if(daybirth == "Sunday")
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 2:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 3:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 4:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                    case 5:
                        Console.WriteLine("******");
                        Console.WriteLine();
                        Console.WriteLine("Name: {0}", username);
                        Console.WriteLine("**Prediction**");
                        Console.WriteLine("He...");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        


    }
}
