using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfApp1
{
    public static class ChangeBehavior
    {
        public static readonly DependencyProperty IsActivatedProperty;

        static ChangeBehavior()
        {
            IsActivatedProperty = DependencyProperty.RegisterAttached
                (
                    "IsActivated",
                    typeof(bool),
                    typeof(ChangeBehavior),
                    new PropertyMetadata(false, OnIsActivatedPropertyChangedCallback)
                );
        }

        public static bool GetIsActivated(DependencyObject obj)
            => (bool)obj.GetValue(IsActivatedProperty);
        public static void SetIsActivated(DependencyObject obj, bool value)
            => obj.SetValue(IsActivatedProperty, value);

        private static void OnIsActivatedPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is TextBox)) return;

            var binding = BindingOperations.GetBinding(d, TextBox.TextProperty);
            if (binding == null) return;

            if ((bool)e.NewValue)
            {
                var sourceObject = binding.Path.Path;
                //TODO:
            }
            else
            {
                //TODO:
            }
        }
    }
}
