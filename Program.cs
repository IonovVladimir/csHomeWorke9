using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        int Input(string text) 
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());
        }
        void Recursion(int counter, int number)
        {
            if (counter > number) return;
            Console.WriteLine(counter);
            counter++;
            Recursion(counter, number);
        }

        //Задача 64: Задайте значения M и N. Напишите рекурсивный метод,
        //который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
        //M = 1; N = 9. -> "3, 6, 9" M = 13; N = 20. -> "15, 18"
        void Recursion64(int start, int stop)
        {
            if (start > stop) return;
            else if(start%3==0) Console.WriteLine(start);
            start++;
            
            Recursion64(start, stop);
        }

        
        void Task64() 
        {         

            int M = Input("Введи M= ");
            int N = Input("Введи N= ");

            Recursion64(M, N);

        }
        //Task64();

        //Задача 66: Задайте значения M и N. Напишите рекурсивный метод,
        //который найдёт сумму натуральных элементов в промежутке от M до N.
        //M = 1; N = 15-> 120
        //M = 4; N = 8. -> 30

        static int Recursion66(int start, int stop) 
        {

            if (start> stop) return 0;
            return start + Recursion66(start + 1, stop);            

        }

        void Task66()
        {

            int M = Input("Введи M= ");
            int N = Input("Введи N= ");
            Console.WriteLine();
            Console.WriteLine($"Сумма всех натуральных чисел от {M} и {N} = {Recursion66(M, N)}");

        }
        //Task66();

        //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
        //Даны два неотрицательных числа m и n.
        //m = 3, n = 2->A(m, n) = 29


        //из habr.com/ru/articles/486548/
        //например

        //def Foo(number, argument):
        //if number == 0:
        //  return argument + 1

        //result = argument
        //for i in range(argument + 2):
        //  result = Foo(number - 1, result)

        //return result

//если функция быстро растёт, int лучше не использовать из-за переполнения?
        static int RecAkk(int m, int n) 
        {
            if (m==0 ) return n+1;
            else if (n==0 && m>0) return RecAkk(m-1,1);
            else return RecAkk(m-1,RecAkk(m,n-1));             
        
        }

        void Task68()
        {

            int M = Input("Введи M= ");
            int N = Input("Введи N= ");
            Console.WriteLine();
            Console.WriteLine($"функция Аккермана с аргументами {M} до {N} = {RecAkk(M,N)}");

        }
        Task68();// как она работает*? магия? непонимаю, случайно вышло...
                 // 


    }
}