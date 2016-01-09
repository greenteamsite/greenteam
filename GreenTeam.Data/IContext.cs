using System.Collections.Generic;
using GreenTeam.Data.Entities;

namespace GreenTeam.Data
{
    public interface IContext
    {
        /// <summary>
        /// Saves the changes.
        /// </summary>
        void SaveChanges();

        /// <summary>
        /// Gets the persons.
        /// </summary>
        /// <value>
        /// The persons.
        /// </value>
        List<Person> Persons { get; }

        /// <summary>
        /// Gets the projects.
        /// </summary>
        /// <value>
        /// The projects.
        /// </value>
        List<Project> Projects { get; }

        /// <summary>
        /// Gets the person projects.
        /// </summary>
        /// <value>
        /// The person projects.
        /// </value>
        List<PersonProject> PersonProjects { get; }
    }


}
