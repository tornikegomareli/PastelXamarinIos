using System;
using MPDCPastelXamarinIOS;
using MPDCPastelXamarinIOS.Extensions;
using UIKit;

namespace TestProject
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        // Test Color 1
        public static UIColor FirstGradientColor
        {
            get
            {

                return UIColor.FromRGB(218, 61, 78);
            }
        }

        // Test Color 2
        public static UIColor SecondGradientColor
        {
            get
            {

                return UIColor.FromRGB(152, 48, 135);
            }
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Initializing pastelView object
            var pastelView = new MPDCPastelXamarinIOS.PastelView(View.Bounds);

            pastelView.AnimationDuration = 2.0;

            // init start poind and end point
            pastelView._startPoint = PastelPoint.BottomLeft.Point();
            pastelView._endPoint = PastelPoint.TopRight.Point();


            // seting two colors
            pastelView.SetColors(new UIColor[]{
                FirstGradientColor,SecondGradientColor
            });

            pastelView.StartAnimation();
            View.InsertSubview(pastelView,0);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

        }
    }
}
