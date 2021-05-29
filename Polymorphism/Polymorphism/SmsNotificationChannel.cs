namespace Polymorphism
{
    public class SmsNotificationChannel : INotificationCHannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending sms");
        }
    }
}
