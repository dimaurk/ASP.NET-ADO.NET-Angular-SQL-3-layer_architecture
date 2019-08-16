using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DataAccessLayer.Models
{
    [DataContract]
    public class LessonsModel
    {
        [DataMember(Name = "Id")]
        public int Id { get; set; }

        [DataMember(Name = "Title")]
        public string Title { get; set; }

        [DataMember(Name = "Discription")]
        public string Discription { get; set; }

        [DataMember(Name = "Chapter")]
        public string Chapter { get; set; }

        [DataMember(Name = "Text")]
        public string Text { get; set; }

        [DataMember(Name = "CurseId")]
        public int CurseId { get; set; }
    }
}
