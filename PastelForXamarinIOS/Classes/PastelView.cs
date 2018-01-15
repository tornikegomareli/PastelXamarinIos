using System;
using CoreGraphics;
using Foundation;
using PastelForXamarinIOS.Extensions;
using UIKit;
using CoreAnimation;
using System.Collections.Generic;
using System.Linq;

namespace PastelForXamarinIOS.Classes
{
    public class PastelView : UIView
    {
        public NSCoder _keyPath;
        public NSCoder _key;
        public PastelView(CGRect frame) : base(frame)
        {
            _keyPath = new NSCoder();
            _key = new NSCoder();
            _keyPath.SetNilValueForKey(new NSString("colors"));
            _key.SetNilValueForKey(new NSString("ColorChange"));
        }

        //static string keyPath = "colors";
        //static string key = "ColorChange";




        public CGPoint _startPoint = PastelPoint.TopRight.Point();
        public CGPoint _endPoint = PastelPoint.BottomLeft.Point();

        //public void StartPastelPoint(PastelPoint point)
        //{

        //}

        //public PastelPoint _endPastelPoint
        //{
        //    set
        //    {
        //        _endPoint = _endPastelPoint.Point();
        //    }

        //};

        // Custom duration

        public TimeSpan _interval = TimeSpan.FromMilliseconds(5.0);
        private CAGradientLayer _gradient = new CAGradientLayer();
        private int _currentGradient = 0;

        private List<UIColor> Colors = new List<UIColor>()
        {
            new UIColor(red:156/255,green:39/255,blue:176/255,alpha:1),
            new UIColor(red:255/255,green:64/255,blue:129/255,alpha:1),
            new UIColor(red:123/255,green:31/255,blue:162/255,alpha:1),
            new UIColor(red:32/255,green:76/255,blue: 255/255,alpha:1),
            new UIColor(red:32/255,green:158/255,blue: 255/255,alpha:1),
            new UIColor(red:90/255,green: 120/255,blue:127/255,alpha:1),
            new UIColor(red: 58/255,green:  255/255,blue: 217/255,alpha:1)
        };

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            _gradient.Frame = Bounds;
        }

        public void StartAnimation()
        {
            _gradient.RemoveAllAnimations();
            setup();
            //animateGradient();

        }

        private void setup()
        {
            _gradient.Frame = Bounds;
            _gradient.Colors = CurrentGradientSet();
            _gradient.StartPoint = _startPoint;
            _gradient.EndPoint = _endPoint;
            _gradient.DrawsAsynchronously = true;

            Layer.InsertSublayer(_gradient,0);
        }

        public CGColor[] CurrentGradientSet()
        {
            //guard colors.count > 0 else { return [] }
            return new CGColor[]
            {
                Colors[_currentGradient % Colors.Count].CGColor,
                Colors[(_currentGradient + 1) % Colors.Count].CGColor
            };
        }

        public void SetColors(UIColor[] colors)
        {
            this.Colors = colors.ToList();
        }

        public void SetPastelGradient(PastelGradient gradient)
        {
            SetColors(gradient.Colors());
        }

        public void AddColor(UIColor color)
        {
            this.Colors.Append(color);
        }

        public void AnimateGradient()
        {
            _currentGradient += 1;
            var animation = new CABasicAnimation(_keyPath);
            animation.Duration = 5.0;
            // amimation.Tovalue
            animation.FillMode = CAFillMode.Forwards;
            // animation.isRemovedOnCompilation
            //animation.Delegate = this;
            // this properties isnt in C#
            _gradient.AddAnimation(animation,_key.ToString());

        }

        public override void RemoveFromSuperview()
        {
            base.RemoveFromSuperview();

            _gradient.RemoveAllAnimations();
            _gradient.RemoveFromSuperLayer();
        }

        //todo

    }

}