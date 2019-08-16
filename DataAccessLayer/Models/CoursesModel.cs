using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DataAccessLayer.Models
{
    [DataContract]
    public class CoursesModel
    {
        [DataMember(Name = "Id")]
        public int Id { get; set; }

        [DataMember(Name = "Title")]
        public string Title { get; set; }

        [DataMember(Name = "Discription")]
        public string Discription { get; set; }

        [DataMember(Name = "Section")]
        public string Section { get; set; }
    }
}
