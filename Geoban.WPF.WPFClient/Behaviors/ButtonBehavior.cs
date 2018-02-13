using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using System.Windows.Media;

namespace Geoban.WPF.WPFClient.Behaviors
{

    // NOTE: Add reference to System.Windows.Interactivity
    class ButtonBehavior : Behavior<Button>
    {
        private Brush brush;

        public Brush SelectedBrush { get; set; }




        public int MyProperty
        {
            get { return (int)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty", typeof(int), typeof(ButtonBehavior), new PropertyMetadata(0));



        protected override void OnAttached()
        {

            this.AssociatedObject.MouseEnter += AssociatedObject_MouseEnter;
            this.AssociatedObject.MouseLeave += AssociatedObject_MouseLeave;

            base.OnAttached();
        }

        private void AssociatedObject_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.AssociatedObject.Foreground = brush;
        }

        private void AssociatedObject_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            brush = this.AssociatedObject.Background;

            this.AssociatedObject.Foreground = SelectedBrush;
        }
    }
}
