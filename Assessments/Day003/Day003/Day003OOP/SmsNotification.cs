using System;
using System.Collections.Generic;
using System.Text;

namespace Day003OOP
{
    public class SmsNotification:Notification
    {
        public string PhoneNumber{ get; private set; }
        void SetPhoneNumber(string phoneNumber){
            if(!string.IsNullOrWhiteSpace(phoneNumber)){
                PhoneNumber = phoneNumber;
            }
            else{
                throw new ArgumentNullException($"Phone number cannot be empty");
            }
        }
        public SmsNotification(string recipient, string message, string phoneNumber):base(recipient,message){
            SetPhoneNumber(phoneNumber);
        }
        public override void Send()
        {
            Console.WriteLine($"Sending SMS");
            Console.WriteLine($"Phone: {PhoneNumber}");
            Console.WriteLine($"Message: {Message}");
        }
    }
}
