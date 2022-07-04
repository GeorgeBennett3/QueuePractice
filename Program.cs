namespace QueuePractice
{
    internal class Program
    {
        static void Main()
        {
            Queue<string> myQueue = new Queue<string>(3);
            myQueue.Enqueue("Queues");
            myQueue.Enqueue("Are");
            myQueue.Enqueue("First in First out");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            };
            Console.ReadLine();
        }
    }
}