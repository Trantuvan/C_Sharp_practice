namespace DependencyInversion
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            System.Console.WriteLine($"Simulating sending email to {person.EmailAddress}");
        }
    }
}
