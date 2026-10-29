using System;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level2
{
    public interface INotification { void Send(string message); }
    public class EmailNotification : INotification { public void Send(string message) { Console.WriteLine("Email: " + message); } }
    public class SmsNotification : INotification { public void Send(string message) { Console.WriteLine("SMS: " + message); } }
    public class PushNotification : INotification { public void Send(string message) { Console.WriteLine("Push: " + message); } }
    public enum NotificationType { Email, Sms, Push }
    public static class NotificationFactory
    {
        public static INotification Create(NotificationType type)
        {
            switch (type)
            {
                case NotificationType.Email: return new EmailNotification();
                case NotificationType.Sms: return new SmsNotification();
                case NotificationType.Push: return new PushNotification();
                default: throw new ArgumentOutOfRangeException("type");
            }
        }
    }
    public class Task29_Notifications : TaskBase
    {
        public override string Title { get { return "29. Фабрика уведомлений"; } }
        public override void Run()
        {
            foreach (NotificationType type in Enum.GetValues(typeof(NotificationType)))
                NotificationFactory.Create(type).Send("Тестовое уведомление");
        }
    }
}
