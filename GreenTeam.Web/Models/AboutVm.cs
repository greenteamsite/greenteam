using GreenTeam.Data.Entities;
using System.Collections.Generic;



namespace GreenTeam.Web.Models
{
    public class AboutVm: PageBaseVm
    {
        public List<Person> Persons { get; set; }
    }
}