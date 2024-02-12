using Generics;
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the queue:");
        int size=Convert.ToInt32 (Console.ReadLine());
        GenericQueue<ChatMessage> queue = new(size);
        char choice;
        do
        {
            DisplayMenu();
            Console.Write("Enter your choice:");
            choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            try
            {
                switch (choice)
                {
                    case '1':
                        Console.WriteLine("Enter the ChatMessage Details");
                        Console.Write("Content: ");
                        string msgcontent =Console.ReadLine();
                        Console.Write("SourceId: ");
                        int srcId = Convert.ToInt32(Console.ReadLine());

                        ChatMessage msg = new(msgcontent, srcId);

                        queue.Enqueue(msg);
                        break;
                    case '2':
                        if (!queue.IsEmpty())
                        {
                            queue.Dequeue();
                            Console.WriteLine("Element deleted");
                        }
                        else
                        {
                            Console.WriteLine("Queue is empty. No element.");
                        }
                        break;
                    case '3':
                        Console.WriteLine($"The queue is empty: {queue.IsEmpty()}");
                        break;
                    case '4':
                        Console.WriteLine($"The queue is full: {queue.IsFull()}");
                        break;
                    case '5':
                        Console.WriteLine("Exited successfully");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"{e.Message}");
            }
            catch(FormatException  e)
            {
                Console.WriteLine("Input type is not correct");
            }

        } while (choice != '5');
    }
    static void DisplayMenu()
    {
        Console.WriteLine("\nChat Message Queue Operations");
        Console.WriteLine("1.Enqueue");
        Console.WriteLine("2.Dequeue");
        Console.WriteLine("3.IsEmpty");
        Console.WriteLine("4.IsFull");
        Console.WriteLine("5.Exit");
    }
}
