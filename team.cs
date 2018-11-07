using System;

namespace Buffteks3
{
    public class Team
    {
        public string TeamName {get; set;}
        public int TeamId {get; set;}
        public string StudentList {get; set;}
        public string ProjectId {get; set;}

        public override string ToString()
        {
            string output = $"{this.TeamName} {this.TeamId}";
            return output;
        }

    }
}