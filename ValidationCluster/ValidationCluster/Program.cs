using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationCluster
{
    class Program
    {
        static int GetUserInt(String Message, bool Positive)
        {
            int userinputint;
            string userinput;
            while (true)
            {
                Console.WriteLine(Message);
                userinput = Console.ReadLine();
                try
                {
                    userinputint = int.Parse(userinput);
                    if (Positive)
                    {
                        if(userinputint >= 0)
                        {
                            return userinputint;
                        }
                        else
                        {
                            Console.WriteLine("invalid input, cannot be negative value");
                        }
                    }
                    else
                    {
                        return userinputint;
                    }
                }
                catch
                {
                    Console.WriteLine("invalid input, must be an integer");
                }
            }
        }
        static int GetUserInt(String Message, int LowerBound, int UpperBound)
        {
            int userinputint;
            string userinput;
            while (true)
            {
                Console.WriteLine(Message);
                userinput = Console.ReadLine();
                try
                {
                    userinputint = int.Parse(userinput);
                    if(userinputint >= LowerBound && userinputint < UpperBound)
                    {
                        return userinputint;
                    }
                    else
                    {
                        Console.WriteLine($"invalid input, must be between {LowerBound} and {UpperBound}");
                    }
                }
                catch
                {
                    Console.WriteLine("invalid input, must be an integer");
                }
            }
        }
        static float GetUserFloat(String Message, bool Positive)
        {
            int userinputfloat;
            string userinput;
            while (true)
            {
                Console.WriteLine(Message);
                userinput = Console.ReadLine();
                try
                {
                    userinputfloat = int.Parse(userinput);
                    if (Positive)
                    {
                        if (userinputfloat >= 0)
                        {
                            return userinputfloat;
                        }
                        else
                        {
                            Console.WriteLine("invalid input, cannot be negative value");
                        }
                    }
                    else
                    {
                        return userinputfloat;
                    }
                }
                catch
                {
                    Console.WriteLine("invalid input, must be an integer");
                }
            }
        }
        static float GetUserFloat(String Message, float LowerBound, float UpperBound)
        {
            float userinputfloat;
            string userinput;
            while (true)
            {
                Console.WriteLine(Message);
                userinput = Console.ReadLine();
                try
                {
                    userinputfloat = float.Parse(userinput);
                    if (userinputfloat >= LowerBound && userinputfloat < UpperBound)
                    {
                        return userinputfloat;
                    }
                    else
                    {
                        Console.WriteLine($"invalid input, must be between {LowerBound} and {UpperBound}");
                    }
                }
                catch
                {
                    Console.WriteLine("invalid input, must be a decimal value");
                }
            }
        }
        static DateTime GetUserDateTime(string Message, bool)
        static void Main()
        {

        }
    }
}
