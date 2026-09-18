namespace NotificationApp
{
    public class NotificationManager
    {
        private INotificationService email;
        private INotificationService push;
        private INotificationService sms;
        private INotificationService whatsapp;

        public NotificationManager()
        {
            email = new EmailNotificationService();
            push = new PushNotificationService();
            sms = new SmsNotificationService();
            whatsapp = new WhatsappAdapter();
        }

        public void SendEmail(string recipient, string message)
        {
            email.Send(recipient, message);
        }

        public void SendPush(string recipient, string message)
        {
            push.Send(recipient, message);
        }

        public void SendSms(string recipient, string message)
        {
            sms.Send(recipient, message);
        }
        public void SendWhatsapp(string recipient, string message)
        {
            whatsapp.Send(recipient, message);
        }
    }
}