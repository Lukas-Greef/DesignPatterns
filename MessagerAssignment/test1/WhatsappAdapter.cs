using ExternalWhatsAppLibrary;

namespace NotificationApp
{
    public class WhatsappAdapter : INotificationService
    {
        private WhatsAppClient whatsappClient;
        public WhatsappAdapter()
        {
            whatsappClient = new WhatsAppClient(); 
        }
        public void Send(string recipient, string message) 
        {
            whatsappClient.SendWhatsAppMessage(recipient, message, false);
        }
    }
}