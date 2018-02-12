using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoban.WPF.Models
{
    public class Person : Base
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {

                return String.Format("{0} {1}", FirstName, LastName);

                // C# 6.0
                //return $"{FirstName} {LastName}";

            }
        }
    }
}
