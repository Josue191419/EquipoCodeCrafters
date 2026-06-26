using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Entities_DTOs
{
    public class User
    {
        public int Id { get; set; }

        public string Identification { get; set; }

        public string Name { get; set; }

        public string FirstLastName { get; set; }

        public string SecondLastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime BirthDate { get; set; }

        public int Age { get; set; }

        public string Photo { get; set; }

        public string Password { get; set; }

        public bool Status { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }

    }
}
