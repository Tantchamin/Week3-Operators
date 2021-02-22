using System;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            int pass, digit1, digit2, digit3, digit4, digit5, digit6;
            string org;
            bool tpass;
            Console.Write("Password: ");
            pass = int.Parse(Console.ReadLine());
            Console.Write("Organization: ");
            org = Console.ReadLine();
            digit1 = pass % 10;
            digit2 = (pass % 100)/10;
            digit3 = (pass % 1000) / 100;
            digit4 = (pass % 10000) / 1000;
            digit5 = (pass % 100000) / 10000;
            digit6 = (pass % 1000000) / 100000;

            if (org == "CIA" && pass < 1000000 && pass >= 100000)
            {
                tpass = (digit1 % 3 == 0 && digit2 != (1 & 3 & 5) && digit4 >= 6 && digit4 != 8);
                Console.WriteLine("Password: {0}", tpass);
            }

            else if (org == "FBI" && pass < 1000000 && pass >= 100000)
            {
                tpass = (digit6 >= 4 && digit6 < 8 && digit3 % 2 == 0 && digit3 != 6 && digit5 % 2 != 0);
                Console.WriteLine("Password: {0}", tpass);
            }

            else if (org == "NSA" && pass < 1000000 && pass >= 100000)
            {
                tpass = (30 % digit1 == 0 && digit3 % 3 == 0 && digit3 % 2 != 0 && digit1 == 7 || digit2 == 7 || digit3 == 7 || digit4 == 7 || digit5 == 7 || digit6 == 7);
                Console.WriteLine("Password: {0}", tpass);
            }

            else
            {
                tpass = false;
                Console.WriteLine("Password: {0}", tpass);
            }
        }
    }
}
