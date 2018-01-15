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
        //public NSCoder _keyPath;
        //public NSCoder _key;

        public PastelView(CGRect frame) : base(frame)
        {
            //_keyPath = new NSCoder();
            //_key = new NSCoder();
            //_keyPath.Encode(new NSString("colors"));
            //_key.Encode(new NSString("ColorChange"));


        }

        public PastelView(NSCoder aDecoder) : base(aDecoder)
        {
            
        }

        //static string keyPath = "colors";
        //static string key = "ColorChange";




        public CGPoint _startPoint = PastelPoint.TopRight.Point();
        public CGPoint _endPoint = PastelPoint.BottomLeft.Point();


        //public PastelPoint _startPastelPoint
        //{
        //    set
        //    {
        //        _startPoint = PastelPoint.TopRight.Point();
        //    }
        //}

        //public PastelPoint _endPastelPoint
        //{
            //set
            //{
            //    _endPoint = PastelPoint.BottomLeft.Point();
            //}


        // Custom duration

        public TimeSpan _interval = TimeSpan.FromMilliseconds(5.0);
        private CAGradientLayer _gradient = new CAGradientLayer();
        private int _currentGradient = 0;

        private List<UIColor> Colors;

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
            AnimateGradient();
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
            var animation = CABasicAnimation.FromKeyPath("colors");
            animation.Duration = 2.0;

            var nsArray =NSArray.FromObjects(CurrentGradientSet());
            animation.To = nsArray;
            //animation.From = NSArray.FromObjects(CurrentGradientSet());
            animation.RemovedOnCompletion = false;

            animation.AnimationStopped += (sender, e) => {
                _gradient.Colors = CurrentGradientSet();
                AnimateGradient();
            };

            animation.FillMode = CAFillMode.Forwards;

            _gradient.AddAnimation(animation,"ColorChange");

        }

        public override void RemoveFromSuperview()
        {
            base.RemoveFromSuperview();

            _gradient.RemoveAllAnimations();
            _gradient.RemoveFromSuperLayer();
        }

        //todo

    }

    //extension PastelView: CAAnimationDelegate {
    //public func animationDidStop(_ anim: CAAnimation, finished flag: Bool)
    //{
    //    if flag {
    //        gradient.colors = currentGradientSet()
    //        animateGradient()
    //    }
    //}
}
