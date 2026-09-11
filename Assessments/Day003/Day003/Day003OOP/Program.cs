namespace Day003OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Polymorphism
            //It is achieved when creating objects of the derived classes, stored in a list that stores objects of Notification
            //type that is the parent class. 
             

            List<Notification> notifications = new List<Notification>();

            Notification email1 = new EmailNotification("Lola", "Hello", "Greetings");
            Notification sms1 = new SmsNotification("Lalo", "Goodbye", "Farewell");

            notifications.Add(email1);
            notifications.Add(sms1);

            //Finally, runtime polymorphism aims to the actual type.
            foreach (var notification in notifications){
                notification.Send();
            }
        }
    }
}
