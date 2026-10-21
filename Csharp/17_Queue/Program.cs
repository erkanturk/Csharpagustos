using System.Collections;

namespace _17_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Queue (Kuyruk yapısı)
             * Fifo First in First out prensibine sahip koleksiyon yapısıdır
             * Dinamik bir yapıya sahiptir içerisinde birden fazla yapıyı tutabilir.
             * Bir uzunlğu yoktur generic yapısı da mevcuttur.
             */

            #region Örnek 1
            //Queue queue = new Queue();
            //queue.Enqueue("Erkan");
            //queue.Enqueue("Türk");
            //queue.Enqueue(true);
            //queue.Enqueue(DateTime.Now);
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //queue.Dequeue();//ilk elemanı siler
            //Console.WriteLine("*****************");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //// queue.Clear();//tüm yapıyı temizler.

            //Console.WriteLine(queue.Peek());//İlk elemanı dönderir


            #endregion

            #region Callcenter
            //Queue kuyruk = new Queue();
            //kuyruk.Enqueue("Batıkan");
            //kuyruk.Enqueue("İdil");
            //kuyruk.Enqueue("Melek");
            //kuyruk.Enqueue("Kübra");
            //kuyruk.Enqueue("Tahsin");
            //kuyruk.Enqueue("Altan");
            //kuyruk.Enqueue("Onur");
            //kuyruk.Enqueue("Erkan");
            //for (int i = kuyruk.Count; i >= kuyruk.Count; i--)
            //{
            //    Thread.Sleep(3000);
            //    Console.WriteLine($"{i}.Sıradasınız");
            //    if (kuyruk.Count == 1)
            //    {
            //        Console.WriteLine($"Sıra Sizde {kuyruk.Peek()}");
            //    }
            //    if (kuyruk.Count == 1)
            //    {
            //        break;
            //    }
            //    kuyruk.Dequeue();
            //}

           
            #endregion
        }
    }
}
