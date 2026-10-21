using System.Collections;

namespace _18_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Stack (Yığın)
             * Queue yapısının tam tersi olarak Last in First out prinsibi ile çalışır.
             */
            Stack yigin = new Stack(); //alt+enter
            yigin.Push(10);
            yigin.Push("Erkan");
            yigin.Push('A');
            yigin.Push(true);
            foreach (var item in yigin)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***********");
            yigin.Pop();//Son elemanı siler
            foreach (var item in yigin)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(yigin.Peek());//son elemanı bize gösterir.
            
        }
    }
}
