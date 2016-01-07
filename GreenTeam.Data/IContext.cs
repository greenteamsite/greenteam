using System.Collections.Generic;
using GreenTeam.Data.Entities;

namespace GreenTeam.Data
{
    public interface IContext
    {
        bool SaveChanges();
        List<Person> Persons { get; }
        List<Project> Projects { get; }
        List<PersonProject> PersonProjects { get; }
    }


}
