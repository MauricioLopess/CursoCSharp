using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEnumEConst.ex03.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime dateTime)
        {
            Name = name;
            Email = email;
            BirthDate = dateTime;
        }

        public override string ToString()
        {
            StringBuilder sBuild = new StringBuilder();
            sBuild.Append($"{Name} ({BirthDate.ToString("dd/MM/yyyy")}) - {Email}");
            return sBuild.ToString();
        }
    }
}
