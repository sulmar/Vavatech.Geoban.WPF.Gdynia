using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace Geoban.WPF.WPFClient.Behaviors
{
    class EventToCommandBehavior : Behavior<Control>
    {

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof(ICommand), typeof(EventToCommandBehavior), new PropertyMetadata(null));



        protected override void OnAttached()
        {
            this.AssociatedObject.MouseEnter += AssociatedObject_MouseEnter;

            base.OnAttached();
        }

        private void AssociatedObject_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (Command != null)
            {
                if (Command.CanExecute(null))
                {
                    Command.Execute(null);
                }
            }
        }
    }
}
