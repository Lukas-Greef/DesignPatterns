namespace NotificationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationManager manager = new NotificationManager();


            manager.SendEmail("1@1.nl", "Email");
            manager.SendPush("jfhhec", "Bericht");
            manager.SendSms("12345678", "SMS");
            manager.SendWhatsapp("12345678", "whatsApp");

            Console.ReadLine();
        }
    }
}
//het maken van de WhatsappAdapter werkt de WhatsApp-notificatie samen met de bestaande NotificationManager.
//We kunnen de WhatsAppClient niet aanpassen, omdat dit een externe library is.
//Deze code wordt door een ander bedrijf geleverd en is niet onderdeel van onze eigen applicatie.
//We kunnen INotificationService wel aanpassen, maar dat is niet nodig en ook niet handig.
//De bestaande Email-, SMS- en Push-services maken al gebruik van deze interface.
//Als we de interface zouden veranderen, moeten we mogelijk ook deze bestaande services aanpassen.
//Daarom gebruiken we de WhatsappAdapter.
//De adapter zorgt ervoor dat de externe WhatsAppClient past bij onze bestaande INotificationService,
// zonder de bestaande code of de externe library aan te passen.
//Dit is het Adapter Pattern.