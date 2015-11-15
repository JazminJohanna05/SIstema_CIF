using System;
using System.Windows;
using System.Windows.Controls;

namespace Sistema_CIF.ViewModel
{
    class StateManager : DependencyObject
    {
        public static string GetVisualStateProperty(DependencyObject obj)
        {

            return (string)obj.GetValue(VisualStatePropertyProperty);

        }



        public static void SetVisualStateProperty(DependencyObject obj, string value)
        {

            obj.SetValue(VisualStatePropertyProperty, value);

        }



        public static readonly DependencyProperty VisualStatePropertyProperty =

            DependencyProperty.RegisterAttached(

            "VisualStateProperty",

            typeof(string),

            typeof(StateManager),

            new PropertyMetadata((s, e) =>
            {

                var ctrl = s as Control;

                if (ctrl == null)

                    throw new InvalidOperationException("This attached property only supports types derived from Control.");

                VisualStateManager.GoToState(ctrl, (string)e.NewValue, true);





            }));
    }
}
