﻿using System.Collections.Generic;

namespace ORM.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string GithubLink { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<StudentModule> StudentModules { get; set; }
        public virtual Role Role { get; set; }
        public virtual Group Group { get; set; }
    }
}
