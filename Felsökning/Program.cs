using System.Collections;

namespace Felsökning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Console.WriteLine("Skriv in vilken case du vill se");//easier for me to sort
            Console.WriteLine("Case 1");
            Console.WriteLine("Case 2");
            Console.WriteLine("Case 3");
            Console.WriteLine("Case 4");
            Console.WriteLine("Case 5");
            Console.WriteLine("Case 6");
            int input = int.Parse(Console.ReadLine());
            {

                switch (input)
                {
                     case 1:
                        int number = 2;

                        if (number > 3)
                        {
                            Console.WriteLine("Talet är större än tre"); // ";" at the end
                        }
                        else if (number < 3) // elseif(number) needed spacebar.
                        {
                            Console.WriteLine("Talet är mindre än tre");
                        }
                        break;
                     case 2:
                        for (int m = 1; m <= 100; m++) //added "=" so it's lower and equal to. changed i to m
                        {
                            Console.WriteLine(m);
                        }break;
                     case 3:
                        for (int k = 1; k <= 5; k++)// added ++ 
                        {
                            for (int j = 1; j <= k; j++)// added ++ changed variable i to k
                            {
                                Console.Write(j + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                     case 4:
                        int l = 1; //changed variable i to l
                        while (l <= 5)
                        {
                            for (int j = 1; j <= l; j++)
                            {
                                Console.WriteLine();
                            }

                            Console.WriteLine(l++); //threw l++ into WriteLine
                            
                        }
                        break;
                     case 5:
                        int i = 1;

                        switch (i)
                        {
                            case 1:
                                break; // added break.
                            case 2:
                                Console.WriteLine("Two");
                                break;
                            default:
                                Console.WriteLine("Other");
                                break;
                        }
                        break;
                       case 6:
                        int n = 5; // changed i to n and changed value 10 to 5

                        if (n == 5) // instead of one equalsign = to two == 
                        {
                            Console.WriteLine("n är 5");
                        }
                        break;

                    
                }
            } 
        }
    }
}