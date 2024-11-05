using System;
using ConsoleApp.Pratical;


namespace ConsoleApp.Pratical
{
    class Program
    {
        char c1 = 'C';
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World - Aula Prática 1");
            Console.WriteLine("--------------------");

            int int1 = 10;
            Console.Write($"{int1}");

            bool bool1 = true;
            bool bool2 = false;

            long long1 = 561845684845641561;
            decimal decimal1 = 123.123M;
            float f1 = 855489.648f;

            Console.WriteLine("--------------------");
            Console.WriteLine("Tipos reference types");

            object obj1 = new object();
            var obj2 = new object();

            var obj3 = obj2;

            Console.WriteLine("Comparando objs");
            Console.WriteLine($"{obj1.GetType().Name} | {obj2.GetType().Name} | {obj3.GetType().Name}");
            Console.WriteLine($"{obj2 == obj3}");

            Console.WriteLine("--------------------");
            
            var s1 = new string('a', 5);
            string s2 = new string(new char[5] {'a','a','a','a','a'});

            Console.WriteLine($"{s1 == s2}");

            string s3 = string.Concat((new char[5] {'a','a','a','a','a'}).AsEnumerable());

            var s4 = $"{s3} string 3";

            Console.WriteLine($"{s4.ToString()}");

            Console.WriteLine("--------------------");

            ClasseCompareString compare1 = new ClasseCompareString()
            {
                testeComparacao = "123"
            };
            var compare2 = new ClasseCompareString()
            {
                testeComparacao = "123"

            };

            Console.WriteLine($"Comparando com == e com equals");

            Console.WriteLine($"{compare1 == compare2}");

            Console.WriteLine($"{compare1.testeComparacao == compare2.testeComparacao}");
            Console.WriteLine($"{compare1.testeComparacao.Equals(compare2.testeComparacao)}");

            Console.WriteLine("--------------------");

            ClasseComplexa classeComplexa = new ClasseComplexa();
            classeComplexa.PropInterface = "123";

            IImprimirValores interfaceX = classeComplexa;

            Console.WriteLine($"{interfaceX.PropInterface}");

        }
    }
}