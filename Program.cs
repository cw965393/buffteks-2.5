using System;
using System.Collections.Generic;
using System.Linq;

namespace Buffteks3
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {

                    //no matter what, delete and then create
                    //db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    if(!db.Students.Any())
                    {
                        List<Student> students = new List<Student>()
                        {
                            new Student()
                            {
                                StudentID= 12345,
                                FirstName = "Jake",
                                LastName = "Piper",
                                PhoneNumber = "156-589-8695",
                                Email = "jpiper@email.com",
                                Role = "junior"
                            },
                            new Student()
                            {
                                StudentID = 12367,
                                FirstName = "Melina",
                                LastName = "Sky",
                                PhoneNumber = "659-821-7899",
                                Email = "msky@email.com",
                                Role = "senior"
                            },
                            new Student()
                            {
                                StudentID = 12389,
                                FirstName = "Quincy",
                                LastName = "Ingram",
                                PhoneNumber = "496-759-8311",
                                Email = "qingram@email.com",
                                Role = "sophomore"
                            },                        
                        };

                        db.Students.AddRange(students);  

                        db.SaveChanges();                                              

                    }
                    else
                    {
                        var students = db.Students.ToList();
                        foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }
                    }

                    if(!db.Clients.Any())
                    {
                        List<Client> clients = new List<Client>()
                        {
                            new Client()
                            {
                                FirstName = "Pam",
                                LastName = "Piper",
                                ClientId = "42151",
                                PhoneNumber = "784-254-6985",
                                Email = "ppiper@email.com",
                                
                            },
                            new Client()
                            {
                                FirstName = "Hou",
                                LastName = "Yi",
                                ClientId = "54223",
                                PhoneNumber = "478-653-8452",
                                Email = "hyi@email.com",
                            },
                            new Client()
                            {
                                FirstName = "Steve",
                                LastName = "Wilson",
                                ClientId = "48251",
                                PhoneNumber = "569-842-4253",
                                Email = "swilson@email.com",
                                
                            },                        
                        };

                        db.Clients.AddRange(clients);  
                        db.SaveChanges();                                              

                    }
                    else
                    {
                        var clients = db.Clients.ToList();
                        foreach(Client s in clients)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    if(!db.Teams.Any())
                    {
                        List<Team> Teams = new List<Team>()
                        {
                            new Team()
                            {
                                TeamName = "Team1",
                                TeamId = 12345,
                                StudentList = "List1",
                                ProjectId = "32784"
                                
                            },
                            new Team()
                            {
                                TeamName = "Team2",
                                TeamId = 67890,
                                StudentList = "List2",
                                ProjectId = "84932"
                            },
                            new Team()
                            {
                                TeamName = "Team3",
                                TeamId = 10112,
                                StudentList = "List3",
                                ProjectId = "85932"
                            },                        
                        };

                        db.Teams.AddRange(Teams);  
                        db.SaveChanges();                                              

                    }
                    else
                    {
                        var team = db.Teams.ToList();
                        foreach(Team s in team)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    if(!db.Advisors.Any())
                    {
                        List<Advisor> advisors = new List<Advisor>()
                        {
                            new Advisor()
                            {
                                AdvisorId = "49032",
                                FirstName = "Rick",
                                LastName = "Willow",
                                PhoneNumber = "956-845-3698",
                                AdvisorEmail = "rwillow@email.com",
                                AdvisorGroup = "Team1"
                                
                            },
                            new Advisor()
                            {
                                AdvisorId = "89545",
                                FirstName = "Whitney",
                                LastName = "Scott",
                                PhoneNumber = "806-874-6398",
                                AdvisorEmail = "wscott@email.com",
                                AdvisorGroup = "Team2"
                            },
                            new Advisor()
                            {
                                AdvisorId = "32567",
                                FirstName = "Frank",
                                LastName = "Mendoza",
                                PhoneNumber = "498-703-5624",
                                AdvisorEmail = "Fmendoza@email.com",
                                AdvisorGroup = "Team3"
                            },                        
                        };

                        db.Advisors.AddRange(advisors);  
                        db.SaveChanges();                                              

                    }
                    else
                    {
                        var advisor = db.Advisors.ToList();
                        foreach(Advisor s in advisor)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    if(!db.Organizations.Any())
                    {
                        List<Organization> organizations = new List<Organization>()
                        {
                            new Organization()
                            {
                                OrganizationId = 78541-123,
                                OrgName = "Organization1",
                                OrgPhoneNumber = "806-798-6354",
                                OrgEmail = "org1@email.com",
                                OrgProject = "Project1"
                                
                            },
                            new Organization()
                            {
                                OrganizationId = 49562-368,
                                OrgName = "Organization2",
                                OrgPhoneNumber = "806-489-2541",
                                OrgEmail = "org2@email.com",
                                OrgProject = "Project2"
                            },
                            new Organization()
                            {
                                OrganizationId = 32541-792,
                                OrgName = "Organization3",
                                OrgPhoneNumber = "806-953-2641",
                                OrgEmail = "org3@email.com",
                                OrgProject = "Project3"
                            },                        
                        };

                        db.Organizations.AddRange(organizations);  
                        db.SaveChanges();                                              

                    }
                    else
                    {
                        var organization = db.Organizations.ToList();
                        foreach(Organization s in organization)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    if(!db.Projects.Any())
                    {
                        List<Project> projects = new List<Project>()
                        {
                            new Project()
                            {
                                ProjectId = "49856",
                                ProjectName = "Project1",
                                ProjectTeam = "Team1",
                                ProjectOrganization = "Organization1"
                                    
                            },
                            new Project()
                            {
                                ProjectId = "96231",
                                ProjectName = "Project2",
                                ProjectTeam = "Team2",
                                ProjectOrganization = "Organization2"
                                
                            },
                            new Project()
                            {
                                ProjectId = "15674",
                                ProjectName = "Project3",
                                ProjectTeam = "Team3",
                                ProjectOrganization = "Organization3"
                                
                            },                        
                        };

                        db.Projects.AddRange(projects);  
                        db.SaveChanges();                                              

                    }
                    else
                    {
                        var project = db.Projects.ToList();
                        foreach(Project s in project)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    if(!db.StudentTeams.Any())
                    {
                        List<StudentTeam> Student_Team = new List<StudentTeam>()
                        {
                            new StudentTeam()
                            {
                                StudentTeamId = 1,
                                TeamName = "Team1",
                                TeamId = 12345,
                                StudentID= 12345,
                                FirstName = "Jake",
                                LastName = "Piper",
                                ProjectId = "49856",
                            },
                            new StudentTeam()
                            {
                                StudentTeamId = 2,
                                TeamName = "Team2",
                                TeamId = 67890,
                                StudentID = 12367,
                                FirstName = "Melina",
                                LastName = "Sky",
                                ProjectId = "96231",
                            },
                            new StudentTeam()
                            {
                                StudentTeamId = 3,
                                TeamName = "Team3",
                                TeamId = 10112,
                                StudentID = 12389,
                                FirstName = "Quincy",
                                LastName = "Ingram",
                                ProjectId = "15674",
                            },                        
                        };

                        db.StudentTeams.AddRange(Student_Team);  
                        db.SaveChanges();                                              

                    }
                    else
                    {
                        var StudentTeam = db.StudentTeams.ToList();
                        foreach(StudentTeam s in StudentTeam)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    if(!db.ClientOrganizations.Any())
                    {
                        List<ClientOrganization> clientOrganizations = new List<ClientOrganization>()
                        {
                            new ClientOrganization()
                            {
                                ClientOrganizationId = 123,
                                FirstName = "Pam",
                                LastName = "Piper",
                                ClientId = "42151",
                                OrganizationId = 78541-123,
                                OrgName = "Organization1",
                            },
                            new ClientOrganization()
                            {
                                ClientOrganizationId = 456,
                                FirstName = "Hou",
                                LastName = "Yi",
                                ClientId = "54223",
                                OrganizationId = 49562-368,
                                OrgName = "Organization2",
                            },
                            new ClientOrganization()
                            {
                                ClientOrganizationId = 789,
                                FirstName = "Steve",
                                LastName = "Wilson",
                                ClientId = "48251",
                                OrganizationId = 32541-792,
                                OrgName = "Organization3",
                            },                       
                        };

                        db.ClientOrganizations.AddRange(clientOrganizations);  
                        db.SaveChanges();                                              

                    }
                    else
                    {
                        var ClientOrganization = db.ClientOrganizations.ToList();
                        foreach(ClientOrganization s in ClientOrganization)
                        {
                            Console.WriteLine(s);
                        }
                    }



                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
    }
}