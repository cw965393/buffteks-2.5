using System;

namespace Buffteks3
{
    public class Advisor
    {
        public string AdvisorId {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string PhoneNumber {get; set;}
        public string AdvisorEmail {get; set;}
        public string AdvisorGroup {get; set;}


        public override string ToString()
        {
            string output = $"{this.FirstName} {this.LastName}";
            return output;
        }

    }
}