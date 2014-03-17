using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppTemplate.Infrastructure
{
    public class VisualStateHelper : DependencyObject
    {
        public static string GetVState(DependencyObject obj)
        {
            return (string)obj.GetValue(VStateProperty);
        }

        public static void SetVState(DependencyObject obj, string value)
        {
            obj.SetValue(VStateProperty, value);
        }

        public static readonly DependencyProperty VStateProperty =
            DependencyProperty.RegisterAttached(
            "VState",
            typeof(string),
            typeof(VisualStateHelper),
            new PropertyMetadata((s, e) =>
            {
                var state = (string)e.NewValue;
                var ctrl = s as Control;
                if (ctrl == null)
                    throw new InvalidOperationException("This attached property only supports types derived from Control.");
                VisualStateManager.GoToState(ctrl, state + "State", true);
            }));
    }
}