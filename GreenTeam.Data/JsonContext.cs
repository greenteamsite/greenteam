using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Hosting;
using GreenTeam.Data.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GreenTeam.Data
{
    public class JsonContext : IContext
    {
        private static readonly string DbFilePath = HostingEnvironment.MapPath(@"~/App_Data/database.json");

        private static AllData _allData;

        public JsonContext()
        {
            #region Save initial data to file
            //InitializeJsonContext();
            #endregion

            #region Load data from file

            LoadJson();

            #endregion
        }

        private void InitializeJsonContext()
        {
            _allData = new AllData
            {
                Persons =
                    new List<Person>
                    {
                        new Person
                        {
                            UrlName = "alex-green",
                            Name = "Alex Green",
                            Position = ".NET Developer",
                            ShortDescription = "5+ years of experience developing with ASP.NET(C#). Developed 15+ projects with a wide variety of areas including finances, energetics, mass media and e-commerce.",
                            Skills = @"•	C# 5.0, .Net Framework 3.5-4.5, ASP.Net MVC 4/5, WCF, Web API, Unit testing <br />
                                       •	Entity Framework, LINQ, T-SQL, ADO.Net<br />
                                       •	HTML5, CSS3, XML, AJAX, JavaScript<br />
                                       •	Angular, Knockout, JQuery, Bootstrap, Kendo UI<br />
                                       •	GIT, SVN, TFS<br />
                                       •	MS Visual Studio 2013/2012/2010, MS SQL Server 2012/2008<br />
                                       •	Windows Server 2012/2008, IIS 8.0/7.5, Windows Azure.",
                            Mail = "sasha.tkachuk@gmail.com",
                            Phone = "+61 431 233 534",
                            Skype = "mark.from.ua",
                            Linkedin = "https://au.linkedin.com/in/alexander-tkachuk-652b2783/en",
                            UrlPicture = @"/Pictures/Profile/alex.gif"
                        },
                        new Person
                        {
                            UrlName = "tania-green",
                            Name = "Tania Green",
                            Position = ".NET Developer, Web Designer",
                            ShortDescription = "1 year of experience developing with ASP.NET(C#) as part of the team that developed a new version of the entertainment website.",
                            Skills = @"•	C# 5.0, .Net Framework 4.5, ASP.Net MVC5<br />
•	Entity Framework, LINQ<br />
•	HTML5, CSS3, JavaScript<br />
•	JQuery, Bootstrap<br />
•	MS Visual Studio 2013, MS SQL Server 2012<br />
•	Windows Server 2012",
                            Mail = "solarwind@bigmir.net",
                            Phone = "+61 421 501 463",
                            Skype = "solar...wind",
                            Linkedin = "https://au.linkedin.com/in/tetiana-tkachuk-335b2983",
                            UrlPicture = @"/Pictures/Profile/tania.gif"
                        },
                        new Person
                        {
                            UrlName = "serg-green",
                            Name = "Serg Green",
                            Position = ".NET Developer",
                            ShortDescription = "1+ year of experience developing with ASP.NET(C#) as part of the team that developed a new version of the entertainment website.",
                                                        Skills = @"•	C# 5.0, .Net Framework 4.5, ASP.Net MVC5<br />
•	Entity Framework, LINQ<br />
•	HTML5, CSS3, JavaScript<br />
•	JQuery, Bootstrap<br />
•	MS Visual Studio 2013, MS SQL Server 2012<br />
•	Windows Server 2012",
                            Mail = "serheysy@gmail.com",
                            Phone = "+38 0636 561 914",
                            Skype = "serheysy.horbenko",
                            Linkedin = "https://ua.linkedin.com/in/serj-horbenko-ab1b03ab",
                            UrlPicture = @"/Pictures/Profile/serg.gif"
                        },
                    },
                Projects = new List<Project>
                {
                    new Project
                    {
                        Id = 0,
                        Name = "Moe Misto",
                        Url = "http://moemisto.com.ua/",
                        UrlPicture = "Pictures/Projects/mmisto.jpg",
                        ShortInfo = "Informational web-site about political, cultural and entertaing life of Kyiv. Contains news section, base of interesting places and schedule of leisure events.",
                    },

                    new Project
                    {
                        Id = 3,
                        Name = "Soberi Sam",
                        Url = "http://soberisam.com/",
                        UrlPicture = "Pictures/Projects/soberisam.jpg",
                        ShortInfo = "Webshop of computers and computer accessories. Has a unique service of online matching different parts of user's own acceptable computer.",
                    },
                    new Project
                    {
                        Id = 1,
                        Name = "Green Team",
                        Url = "http://greenteam.site/",
                        UrlPicture = "Pictures/Projects/gt.jpg",
                        ShortInfo = "Demo site of the team of software and web debelopers. Contains list of team members, detail information about each of them and list of the finished projects.",
                    },
   
                },
                PersonProjects = new List<PersonProject>
                {
                    new PersonProject {
                           PersonUrlName = "alex-green",
                           ProjectId = 0,
                           PersonRole = "Team Lead"
                    },
                    new PersonProject {
                           PersonUrlName = "alex-green",
                           ProjectId = 1,
                           PersonRole = "Team Lead"
                    },

                    new PersonProject {
                           PersonUrlName = "alex-green",
                           ProjectId = 3,
                           PersonRole = "Team Lead"
                    },

                    new PersonProject {
                           PersonUrlName = "tania-green",
                           ProjectId = 0,
                           PersonRole = ".NET Developer, Web Designer"
                    },
                    new PersonProject {
                           PersonUrlName = "tania-green",
                           ProjectId = 1,
                           PersonRole = ".NET Developer, Web Designer"
                    },

                    new PersonProject {
                           PersonUrlName = "tania-green",
                           ProjectId = 3,
                           PersonRole = "HTML coder"
                    },
                    new PersonProject {
                           PersonUrlName = "serg-green",
                           ProjectId = 0,
                           PersonRole = ".NET Developer"
                    },

                    new PersonProject {
                           PersonUrlName = "serg-green",
                           ProjectId = 1,
                           PersonRole = ".NET Developer"
                    },

                }
            };

            SaveJson();

        }

        public List<Person> Persons
        {
            get { return _allData.Persons; }
        }

        public List<Project> Projects
        {
            get { return _allData.Projects; }
        }

        public List<PersonProject> PersonProjects
        {
            get { return _allData.PersonProjects; }
        }

        private bool LoadJson()
        {
            using (StreamReader file = File.OpenText(DbFilePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                _allData = (AllData)serializer.Deserialize(file, typeof(AllData));
            } 
            return true;
        }

        private bool SaveJson()
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(DbFilePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, _allData);
            }
            return true;
        }

        public bool SaveChanges()
        {
            return SaveJson();
        }

    }
}
