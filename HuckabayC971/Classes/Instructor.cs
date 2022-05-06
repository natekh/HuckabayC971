using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace HuckabayC971
{
    public class Instructor
    {
        public Instructor(string name, string phoneNumber, string emailAddress)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
        }
        public string Name { get; set; } 
        public string PhoneNumber { get; set; } 
        public string EmailAddress { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nPhone Number: {PhoneNumber}\nEmail Address: {EmailAddress}";
        }
    }
}
