using Xamarin.Forms;

namespace CustomCheckBoxSample.CustomControls
{
    public class CustomCheckbox : CheckBox
    {
        public static BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string),
            typeof(CustomCheckbox), string.Empty, BindingMode.TwoWay);
        public static BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Color),
            typeof(CustomCheckbox), Color.Default);
        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }
            set
            {
                SetValue(TextProperty, value);
            }
        }
        public Color TextColor
        {
            get
            {
                return (Color)GetValue(TextColorProperty);
            }
            set
            {
                SetValue(TextColorProperty, value);
            }
        }
    }
}