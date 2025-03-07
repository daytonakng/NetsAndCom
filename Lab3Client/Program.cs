using Lab3Console;

internal class Program
{
    private static void Main(string[] args)
    {
        SimpleClient client = new SimpleClient();
        client.ConnectToServer("127.0.0.1", 5000);

        Console.WriteLine("Введите сообщение для отправки:");
        client.SendMessage(Console.ReadLine());
    }
}