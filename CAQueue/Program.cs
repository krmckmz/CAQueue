using System.Collections;

class Program
{
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
}