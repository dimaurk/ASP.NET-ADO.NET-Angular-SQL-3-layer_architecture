using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DataAccessLayer.Models
{
    [DataContract]
    public class UsersModel
    {
        [DataMember(Name = "Id")]
        public int Id { get; set; }

        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Surname")]
        public string Surname { get; set; }

        [DataMember(Name = "Patronymic")]
        public string Patronymic { get; set; }

        [DataMember(Name = "Login")]
        public string Login { get; set; }

        [DataMember(Name = "Password")]
        public string Password { get; set; }

        [DataMember(Name = "Email")]
        public string Email { get; set; }

        [DataMember(Name = "Role")]
        public string Role { get; set; }
    }
}
