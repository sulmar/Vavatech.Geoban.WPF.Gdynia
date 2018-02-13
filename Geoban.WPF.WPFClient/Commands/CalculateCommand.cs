using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Geoban.WPF.WPFClient.Commands
{

    class Product
    {
        public decimal Price { get; set; }

        public decimal Calculate(float power, int weather)
        {
            return (decimal) power * weather;
        }
    }
    

    class CalculateCommand 
    {
        private readonly float power;
        private readonly int weather;
        private readonly Product product;

        public CalculateCommand(Product product, float power, int weather)
        {
            this.power = power;
            this.weather = weather;
            this.product = product;
        }


        public bool CanExecute()
        {
            return power > 100;
        }

        public void Execute()
        {
            product.Price = (decimal)power * weather;
        }
    }
}
