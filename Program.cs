using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue14
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option\n1.Create simple stack\n2.Peek pop stack\n3.Create Queue\n4.Dequeue operation");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (option)
            {
                case 1:
                    CreateStack create = new CreateStack();
                    create.Push(70);
                    create.Push(30);
                    create.Push(56);
                    create.Display();
                    break;
                case 2:
                    PeekAndPop peekpop = new PeekAndPop();
                    peekpop.Push(70);
                    peekpop.Push(30);
                    peekpop.Push(56);
                    peekpop.IsEmpty();
                    peekpop.Display();
                    break;
                case 3:
                    CreateQueue createque = new CreateQueue();
                    createque.Enqueue(56);
                    createque.Enqueue(30);
                    createque.Enqueue(70);
                    createque.Display();
                    break;
                case 4:
                    EnqueueDequeue dequeue = new EnqueueDequeue();
                    dequeue.Enqueue(56);
                    dequeue.Enqueue(30);
                    dequeue.Enqueue(70);
                    dequeue.IsEmpty();
                    dequeue.Display();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
