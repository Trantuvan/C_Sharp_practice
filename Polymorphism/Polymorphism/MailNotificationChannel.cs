namespace Polymorphism
{
    public class MailNotificationChannel : INotificationCHannel
    {
        public void Send(Message message)
        {
            //throw new System.NotImplementedException();
            System.Console.WriteLine("Sending Mail..");
        }
    }
}
