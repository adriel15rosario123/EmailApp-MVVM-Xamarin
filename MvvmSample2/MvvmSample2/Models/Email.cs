using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmSample2.Models
{
    public class Email
    {
        public string Receiver { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Created { get; set; }
        public string ProfileImage { get; set; }
        public IEnumerable<string> AttachedImages { get; set; }

        public Email(string receiver, string sender, string subject, string description, string created, string profileImage)
        {
            Receiver = receiver;
            Sender = sender;
            Subject = subject;
            Description = description;
            Created = created;
            ProfileImage = profileImage;
        }

        public Email(string receiver,string sender,string subject, string description, string created)
        {
            Receiver = receiver;
            Sender = sender;
            Subject = subject;
            Description = description;
            Created = created;
            
        }

        public Email()
        {

        }
    }
}
