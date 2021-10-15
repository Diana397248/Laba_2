using System;

namespace Laba_2
{
    public class Task3
    {
        public static void Run()
        {
            string a;
            string[] list;
            a = "Login1,LOgin2,login3,loGin4";
            a = a.ToLower();
            list = a.Split(",");
            Console.WriteLine(string.Join(" ",list));
            
        }
    }
}