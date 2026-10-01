namespace NotificationApp
{
	public class TimestampDecorator : NotificationDecorator
	{
		public TimestampDecorator(INotificationService notification)
			: base(notification)
		{
		}

		public override void Send(string recipient, string message)
		{
			Console.WriteLine($"Tijd: {DateTime.Now:HH:mm:ss}");

			notification.Send(recipient, message);
		}
	}
}