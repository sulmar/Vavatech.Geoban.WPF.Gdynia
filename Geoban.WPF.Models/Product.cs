using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoban.WPF.Models
{
    public class Product : Base
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }
      

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;

                // OnPropertyChanged();

                OnPropertyChanged(() => Price);
                
                // C# 6.0
                //OnPropertyChanged(nameof(Price));
            }
        }

        public bool IsDeleted { get; set; }


        public override string ToString()
        {
            return this.Name;
        }
    }
}
