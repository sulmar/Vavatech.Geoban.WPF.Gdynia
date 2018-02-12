using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoban.WPF.HelloWorld.Models
{
    public class Person : Object
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public byte Height { get; set; }

        public DateTime Birthday { get; set; }

        public bool IsActive { get; set; }
    }

}
