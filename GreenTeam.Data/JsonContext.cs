using System.Collections.Generic;
using System.IO;
using System.Web.Hosting;
using GreenTeam.Data.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Configuration;
using Microsoft.Practices.Unity;

namespace GreenTeam.Data
{
    public class JsonContext : IContext
    {
        private readonly string DbFilePath;// = HostingEnvironment.MapPath(@"~/App_Data/database.json");

        private AllData _allData;

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonContext"/> class.
        /// </summary>
        [InjectionConstructor]
        public JsonContext()
        {
            DbFilePath = HostingEnvironment.MapPath(ConfigurationManager.AppSettings["DbFilePath"]);

            #region Load data from file

            LoadJson();

            #endregion
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonContext"/> class.
        /// </summary>
        public JsonContext(string dbFilePath)
        {
            DbFilePath = dbFilePath; //HostingEnvironment.MapPath(ConfigurationManager.AppSettings["DbFilePath"]);

            #region Load data from file

            LoadJson();

            #endregion
        }

        /// <summary>
        /// Loads the json from file.
        /// </summary>
        private void LoadJson()
        {
            using (StreamReader file = File.OpenText(DbFilePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                _allData = (AllData)serializer.Deserialize(file, typeof(AllData));
            } 
        }

        /// <summary>
        /// Saves data to json file.
        /// </summary>
        private void SaveJson()
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(DbFilePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, _allData);
            }
        }

        /// <summary>
        /// Gets the persons.
        /// </summary>
        /// <value>
        /// The persons.
        /// </value>
        public List<Person> Persons
        {
            get { return _allData.Persons; }
        }

        /// <summary>
        /// Gets the projects.
        /// </summary>
        /// <value>
        /// The projects.
        /// </value>
        public List<Project> Projects
        {
            get { return _allData.Projects; }
        }

        /// <summary>
        /// Gets the person projects.
        /// </summary>
        /// <value>
        /// The person projects.
        /// </value>
        public List<PersonProject> PersonProjects
        {
            get { return _allData.PersonProjects; }
        }

        /// <summary>
        /// Saves the changes.
        /// </summary>
        public void SaveChanges()
        {
            SaveJson();
        }
    }
}
