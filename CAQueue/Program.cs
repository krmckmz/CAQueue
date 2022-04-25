using System.Collections;

class Program
{
    private const int Dimension = 10;
    private int front = -1;
    private int rear = -1;
    private int[] QueueArray = new int[Dimension];

    public static void Main(string[] args)
    {
        //eleman ekleme ve çıkarma işlemlerinde boxing-unboxing yaşanır.
        Queue dynamicQueue = new Queue();

        //eleman ekleme ve çıkarma sırasında boxing-unboxing yaşanmaz.
        Queue<string> tickets = new Queue<string>();

        tickets.Enqueue("Kerem Çökmez");
        tickets.Enqueue("Çağdaş Çökmez");

        tickets.Clear();

        string dequeuedTicket = tickets.Dequeue();
        Console.WriteLine($"Dequeued Ticket : {dequeuedTicket}");

        string firstTicket = tickets.Peek();
        bool isTicketExist = tickets.Contains("Çağdaş Çökmez");

        var ticketArray = tickets.ToArray();


        Console.ReadLine();
    }

    void Enqueue(int number)
    {
        if (rear == Dimension - 1)
        {
            Console.WriteLine("Queue is full.");
            return;
        }
        if (front == -1)
            front = 0;

        rear++;
        QueueArray[rear] = number;
    }

    void CircularEnqueue(int number)
    {
        if ((front == 0 && rear == Dimension - 1) || rear + 1 == front)
        {
            Console.WriteLine("Queue is full.");
            return;
        }
        if (front == -1)
            front = 0;

        rear = (rear + 1) % Dimension; 
        QueueArray[rear] = number;
    }

    int Dequeue()
    {
        if (front == -1 || front > rear)
        {
            Console.WriteLine("Queue is empty.");
        }

        int dequeued = QueueArray[front];

        if (front == rear)
        {
            front = -1;
            rear = -1;
            return dequeued;
        }

        front++;
        return dequeued;
    }


    int CircularDequeue()
    {
        if (front == -1)
        {
            Console.WriteLine("Queue is empty.");
            return -1;
        }

        int dequeued = QueueArray[front];

        if (front == rear)
        {
            front = -1;
            rear = -1;
            return dequeued;
        }

        front = (front + 1) % Dimension;
        return dequeued;
    }
}