using System;

namespace Buffteks3
{
    public class Project
    {
        public string ProjectId {get; set;}
        public string ProjectName {get; set;}
        public string ProjectTeam {get; set;}
        public string ProjectOrganization{get; set;}
     


        public override string ToString()
        {
            string output = $"{this.ProjectId} {this.ProjectName}";
            return output;
        }

    }
}