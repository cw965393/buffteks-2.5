using System;

namespace Buffteks3
{
    public class Client
    {
        
        public string FirstName {get; set;}

        public string LastName {get; set;}

        public string ClientId {get; set;}

        public string PhoneNumber {get; set;}

        public string Email {get; set;}

        public override string ToString()
        {
            string output = $"{this.FirstName} {this.LastName}";
            return output;
        }
    }
}