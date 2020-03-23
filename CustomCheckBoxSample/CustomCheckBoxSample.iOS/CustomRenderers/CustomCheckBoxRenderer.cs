using CustomCheckBoxSample.CustomControls;
using CustomCheckBoxSample.iOS.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(CustomCheckbox), typeof(CustomCheckBoxRenderer))]
namespace CustomCheckBoxSample.iOS.CustomRenderers
{
    class CustomCheckBoxRenderer : CheckBoxRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CheckBox> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var elm = (CustomCheckbox)Element;
                Control.SetTitle(elm.Text, UIKit.UIControlState.Normal);
                Control.SetTitleColor(new UIKit.UIColor(elm.TextColor.ToCGColor()), UIKit.UIControlState.Normal);
            }
        }
    }
}