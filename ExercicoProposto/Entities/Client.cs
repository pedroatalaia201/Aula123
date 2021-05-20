using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicoProposto.Entities {
    class Client {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client() { 
        }

        public Client(string name, string e_mail, DateTime birth) {
            Name = name;
            Email = e_mail;
            BirthDate = birth;
        }
    }
}
