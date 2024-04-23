using Android.Content;
using CarNext.CustomControl;
using CarNext.Platforms.Android;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Platform.Android.AppCompat;
using Microsoft.Maui.Controls.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: ExportRenderer(typeof(BorderlessPicker), typeof(BordlessPickerRenderer))]
namespace CarNext.Platforms.Android
{
    public class BordlessPickerRenderer : PickerRenderer
    {
        public BordlessPickerRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                Control.Background = null;
            }
        }

    }
}
