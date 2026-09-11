using System;
using System.Collections.Generic;
using System.Text;

namespace Day003OOP
{
    //Inheritance is achieved using the : operator on the derived classes
    public class EmailNotification:Notification
    {
        public string Subject{ get; private set; }
        void SetSubject(string subject){
            if(!string.IsNullOrWhiteSpace(subject)){
                Subject = subject;
            }
            else{
                throw new ArgumentNullException($"Subject cannot be empty.");
            }
        }
        public EmailNotification(string recipient, string message, string subject):base(recipient,message){
            SetSubject(subject);
        }
        public override void Send()
        {
            Console.WriteLine($"Sending Email");
            Console.WriteLine($"To: {Recipient}");
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Message: {Message}");
        }
    }
}
