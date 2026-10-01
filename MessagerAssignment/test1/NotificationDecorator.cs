namespace NotificationApp
{
    public abstract class NotificationDecorator : INotificationService
    {
        protected INotificationService notification;

        public NotificationDecorator(INotificationService notification)
        {
            this.notification = notification;
        }

        public abstract void Send(string recipient, string message);
    }
}