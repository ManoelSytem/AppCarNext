using CarNext.CustomControl;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Platform.iOS;
using Microsoft.Maui.Controls.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarNext.Platforms.iOS;
using UIKit;

[assembly: ExportRenderer(typeof(BorderlessPicker), typeof(BordlessPickerRenderer))]
namespace CarNext.Platforms.iOS
{
    public class BordlessPickerRenderer : PickerRenderer
    {
     
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                return;
            }

            Control.Layer.BorderWidth = 0;
            Control.BorderStyle = UITextBorderStyle.None;
        }

    }
}
