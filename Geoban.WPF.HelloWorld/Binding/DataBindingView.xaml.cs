using Geoban.WPF.HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Geoban.WPF.HelloWorld.Binding
{
    /// <summary>
    /// Interaction logic for DataBindingView.xaml
    /// </summary>
    public partial class DataBindingView : Window
    {


        public DataBindingView()
        {

            InitializeComponent();

            var person = new Person
            {
                FirstName = "Marcin",
                LastName = "Sulecki",
                Height = 175,
                Birthday = DateTime.Now,
                IsActive = true,
            };

            // this.DataContext = person;


        }

       
    }
}
