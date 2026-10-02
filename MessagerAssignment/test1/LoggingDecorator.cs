namespace NotificationApp
{
    public class LoggingDecorator : NotificationDecorator
    {
        public LoggingDecorator(INotificationService notification)
            : base(notification)
        {
        }

        public override void Send(string recipient, string message)
        {
            Console.WriteLine("logged notificatie naar " + recipient);

            notification.Send(recipient, message);
        }
    }
}