using System;

namespace Buffteks3
{
    public class ClientOrganization
    {
        public int ClientOrganizationId {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string ClientId {get; set;}
        public int OrganizationId {get; set;}
        public string OrgName {get; set;}


        public override string ToString()
        {
            string output = $"{this.ClientOrganizationId} {this.FirstName} {this.LastName} {OrganizationId} {OrgName}";
            return output;
        }
    }
}