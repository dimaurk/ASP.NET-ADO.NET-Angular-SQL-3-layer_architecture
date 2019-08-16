using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DataAccessLayer.Models
{
    [DataContract]
    public class AnswersModel
    {
        [DataMember(Name = "Id")]
        public int Id { get; set; }

        [DataMember(Name = "Answer")]
        public string Answer { get; set; }

        [DataMember(Name = "QuestionId")]
        public int QuestionId { get; set; }
    }
}
