using System;

namespace Buffteks3
{
    public class StudentTeam
    {
        public int StudentTeamId {get; set;}
        public string TeamName {get; set;}
        public int TeamId {get; set;}
        public int StudentID {get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }      
        public string ProjectId {get; set;}

        public override string ToString()
        {
            string output = $"{this.StudentTeamId} {this.TeamName} {this.TeamId} {this.StudentID} {this.FirstName} {this.LastName}";
            return output;
        }

    }
}