using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Geoban.WPF.Models
{
    public abstract class Base : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // NET 3.5
        protected void OnPropertyChanged<T>(Expression<Func<T>> expression)
        {
            var memberExpression = (MemberExpression) expression.Body;

            var propertyName = memberExpression.Member.Name;

            OnPropertyChanged(propertyName);
        }



        // .NET 4.5
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        // albo Fody Wave
    }
}
