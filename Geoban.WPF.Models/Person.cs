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

        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
                OnPropertyChanged();
                OnPropertyChanged(()=>FullName);
            }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged();
                OnPropertyChanged(() => FullName);
            }
        }

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
