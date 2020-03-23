using Android.Content;
using CustomCheckBoxSample.CustomControls;
using CustomCheckBoxSample.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(CustomCheckbox), typeof(CustomCheckBoxRenderer))]
namespace CustomCheckBoxSample.Droid.CustomRenderers
{
    public class CustomCheckBoxRenderer : CheckBoxRenderer
    {
        public CustomCheckBoxRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<CheckBox> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var elm = (CustomCheckbox)Element;
                Control.Text = elm.Text;
                Control.SetTextColor(elm.TextColor.ToAndroid());
            }
        }
    }
}