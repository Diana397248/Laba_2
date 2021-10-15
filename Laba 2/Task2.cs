using System;
using System.Reflection;

namespace Laba_2
{
    public class Task2
    {
        public static void Run()
        {
            string a;
            a = "Сегодня мы с вами рассмотрели, как работать со строками в Сишарп. Были описаны основные операторы и методы, которые используются для работы со строками";
            Console.WriteLine(a.Substring(65,41));
            
        }
    }
}