namespace NotificationApp
{
    public class UrgentDecorator : NotificationDecorator
    {
        public UrgentDecorator(INotificationService notification)
            : base(notification)
        {
        }

        public override void Send(string recipient, string message)
        {
            message = "[URGENT] " + message;

            notification.Send(recipient, message);
        }
    }
}