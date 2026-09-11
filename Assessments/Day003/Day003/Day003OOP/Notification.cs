using System;
using System.Collections.Generic;
using System.Text;

namespace Day003OOP
{
    //Abstraction is achieved making the parent class an abstract class, preventing this class from being instantiated 
    //working as a blueprint for derived classes.
    public abstract class Notification
    {
        //Requirements
        //Recipient cannot be null/empty/whitespace.
        //Message cannot be null/empty/whitespace.
        //Outside code may read them.
        //Outside code may not assign them directly.

        //Encapsulation is achieved using private access modifiers so that this parameters are only editable
        //from within this class
        public string Recipient { get; private set; }
        public string Message { get; private set; }

        void SetRecipient(string recipient){
            if(!string.IsNullOrWhiteSpace(recipient)){
                Recipient = recipient;
            }
            else{
                throw new ArgumentNullException($"Recipient cannot be empty.");
            }

        }
        void SetMessage(string message){
            if(!string.IsNullOrWhiteSpace(message)){
                Message = message;
            }
            else{
                throw new ArgumentNullException($"Message cannot be empty.");
            }
        }
        public Notification(string recipient, string message){
            SetRecipient(recipient);
            SetMessage(message);
        }

        public abstract void Send();
    }
}
