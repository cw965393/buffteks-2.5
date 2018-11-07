using System;

namespace Buffteks3
{
    public class Organization
    {
        public int OrganizationId {get; set;}
        public string OrgName {get; set;}
        public string OrgPhoneNumber {get; set;}
        public string OrgEmail {get; set;}
        public string OrgProject {get; set;}


        public override string ToString()
        {
            string output = $"{this.OrganizationId} {this.OrgName}";
            return output;
        }

    }
}