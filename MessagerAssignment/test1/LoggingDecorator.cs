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
            Console.WriteLine("LOG: notificatie wordt verstuurd");

            notification.Send(recipient, message);
        }
    }
}