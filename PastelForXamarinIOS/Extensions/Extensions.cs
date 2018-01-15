using System;
using System.Collections.Generic;
using CoreGraphics;
using PastelForXamarinIOS.Classes;
using UIKit;
namespace PastelForXamarinIOS.Extensions
{
    public static class Extensions
    {
        public static List<UIColor> Colors(this PastelGradient pastelgradient) 
        {
            switch (pastelgradient)
            {
                case PastelGradient.WarmFlame:
                    {
                        return 
                            new List<UIColor>(){
                                new UIColor(red: 1, green: (System.nfloat)0.6039215686, blue: (System.nfloat)0.6196078431, alpha: 1),
                                new UIColor(red: (System.nfloat)0.9803921569, green: (System.nfloat)0.8156862745, blue: (System.nfloat)0.768627451, alpha: 1)
                             };
                    }

                case PastelGradient.NightFade:
                    {
                        return
                            new List<UIColor>(){
                                new UIColor(red:(System.nfloat)0.631372549, green: (System.nfloat)0.5490196078, blue: (System.nfloat)0.8196078431, alpha: 1),
                                new UIColor(red: (System.nfloat)0.9843137255, green: (System.nfloat)0.7607843137, blue: (System.nfloat)0.9215686275, alpha: 1)
                             };
                    }
                case PastelGradient.SpringWarmth:
                    {
                        return
                            new List<UIColor>(){
                                new UIColor(red:(System.nfloat)0.9803921569, green: (System.nfloat)0.8156862745, blue: (System.nfloat)0.768627451, alpha: 1),
                                new UIColor(red: (System.nfloat)1, green: (System.nfloat) 0.8196078431, blue: (System.nfloat)1, alpha: 1)
                             };
                    }
                case PastelGradient.JuicyPeach:
                    {
                        return
                            new List<UIColor>(){
                                new UIColor(red:(System.nfloat)1, green: (System.nfloat)0.9254901961, blue: (System.nfloat)0.8235294118, alpha: 1),
                                new UIColor(red: (System.nfloat)0.9882352941, green: (System.nfloat) 0.7137254902, blue: (System.nfloat)0.6235294118, alpha: 1)
                             };
                    }
                case PastelGradient.YoungPassion:
                    {
                        return
                            new List<UIColor>(){
                                new UIColor(red:(System.nfloat)1, green: (System.nfloat)0.5058823529, blue: (System.nfloat) 0.4666666667, alpha: 1),
                                new UIColor(red: (System.nfloat)1, green: (System.nfloat)0.5254901961, blue: (System.nfloat)0.4784313725, alpha: 1),
                                new UIColor(red: (System.nfloat)1, green: (System.nfloat)0.5490196078, blue: (System.nfloat)0.4980392157, alpha: 1),
                                new UIColor(red: (System.nfloat)0.9764705882, green: (System.nfloat)0.568627451, blue: (System.nfloat)0.5215686275, alpha: 1),
                                new UIColor(red: (System.nfloat) 0.6941176471, green: (System.nfloat)0.1647058824, blue: (System.nfloat)0.3568627451, alpha: 1)
                             };
                    }
                case PastelGradient.LadyLips:
                    {
                        return
                            new List<UIColor>(){
                                new UIColor(red:(System.nfloat)1, green: (System.nfloat)0.6039215686, blue: (System.nfloat) 0.6196078431, alpha: 1),
                                new UIColor(red: (System.nfloat)0.9960784314, green: (System.nfloat)0.8117647059, blue: (System.nfloat)0.937254902, alpha: 1),
                                new UIColor(red: (System.nfloat)0.9960784314, green: (System.nfloat)0.8117647059, blue: (System.nfloat)0.937254902, alpha: 1)
                             };
                    };
                case PastelGradient.SunnyMorning:
                    {
                        return
                            new List<UIColor>(){
                                new UIColor(red:(System.nfloat)0.9647058824, green: (System.nfloat)0.8274509804, blue: (System.nfloat) 0.3960784314, alpha: 1),
                                new UIColor(red: (System.nfloat)0.9921568627, green: (System.nfloat)0.6274509804, blue: (System.nfloat)0.5215686275, alpha: 1),
                             };
                    }
                case PastelGradient.RainyAshville:
                    {
                        return
                            new List<UIColor>(){
                                new UIColor(red:(System.nfloat)0.9843137255, green: (System.nfloat)0.7607843137, blue: (System.nfloat) 0.9215686275, alpha: 1),
                                new UIColor(red: (System.nfloat)0.6509803922, green: (System.nfloat)0.7568627451, blue: (System.nfloat)0.9333333333, alpha: 1),
                             };
                    }

                case PastelGradient.FrozenDreams:
                    {
                        return
                            new List<UIColor>(){
                                new UIColor(red:(System.nfloat)0.9921568627, green: (System.nfloat)0.7960784314, blue: (System.nfloat) 0.9450980392, alpha: 1),
                                new UIColor(red: (System.nfloat)0.9921568627, green: (System.nfloat)0.7960784314, blue: (System.nfloat)0.9450980392, alpha: 1),
                                new UIColor(red: (System.nfloat)0.9019607843, green: (System.nfloat)0.8705882353, blue: (System.nfloat)0.9137254902, alpha: 1)
                             };
                    }
                case PastelGradient.WinterNeva:
                    {
                        return
                            new List<UIColor>(){
                                new UIColor(red:(System.nfloat)0.631372549, green: (System.nfloat)0.768627451, blue: (System.nfloat) 0.9921568627, alpha: 1),
                                new UIColor(red: (System.nfloat)0.7607843137, green: (System.nfloat)0.9137254902, blue: (System.nfloat)0.9843137255, alpha: 1)
                        };
                    }
                default:
                    return null;
            }
        }

        public static CGPoint Point(this PastelPoint point)
        {
            switch (point)
            {
                case PastelPoint.Left:
                    {
                        return new CGPoint(x: 0.0, y: 0.5);
                    }
                case PastelPoint.Top:
                    {
                        return new CGPoint(x: 0.5, y: 0.0);
                    }
                case PastelPoint.Right:
                    {
                        return new CGPoint(x: 1.0, y: 0.5);
                    }
                case PastelPoint.Bottom:
                    {
                        return new CGPoint(x: 0.5, y: 1.0);
                    }
                case PastelPoint.TopLeft:
                    {
                        return new CGPoint(x: 0.0, y: 0.0);
                    }
                case PastelPoint.TopRight:
                    {
                        return new CGPoint(x: 1.0, y: 0.0);
                    }
                case PastelPoint.BottomLeft:
                    {
                        return new CGPoint(x: 0.0, y: 1.0);
                    }

                case PastelPoint.BottomRight:
                    {
                        return new CGPoint(x: 1.0, y: 1.0);
                    }
                default:
                    return new CGPoint(-1.0, -1.0);
            }
        }
    }
}
