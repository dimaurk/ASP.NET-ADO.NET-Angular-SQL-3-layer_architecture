using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DataAccessLayer.Models
{
    [DataContract]
    public class QuestionsModel
    {
        [DataMember(Name = "Id")]
        public int Id { get; set; }

        [DataMember(Name = "Question")]
        public string Question { get; set; }

        [DataMember(Name = "TestId")]
        public int TestId { get; set; }
    }
}
