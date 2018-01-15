using System;
using CoreGraphics;
using Foundation;
using MPDCPastelXamarinIOS.Extensions;
using UIKit;
using CoreAnimation;
using System.Collections.Generic;
using System.Linq;

namespace MPDCPastelXamarinIOS
{
    public class PastelView : UIView
    {

        public PastelView(CGRect frame) : base(frame){}
        public PastelView(NSCoder aDecoder) : base(aDecoder){}

        private const string KeyPath = "colors";
        private const string Key = "ColorChange";
        private List<UIColor> _colors;
        private CAGradientLayer _gradient = new CAGradientLayer();
        private int _currentGradient = 0;

        public CGPoint _startPoint = PastelPoint.TopRight.Point();
        public CGPoint _endPoint = PastelPoint.BottomLeft.Point();


        // Custom duration
        public double AnimationDuration { get; set; }
       
        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            _gradient.Frame = Bounds;
        }

        private void setup()
        {
            _gradient.Frame = Bounds;
            _gradient.Colors = CurrentGradientSet();
            _gradient.StartPoint = _startPoint;
            _gradient.EndPoint = _endPoint;
            _gradient.DrawsAsynchronously = true;

            Layer.InsertSublayer(_gradient, 0);
        }

        public void StartAnimation()
        {
            _gradient.RemoveAllAnimations();
            setup();
            AnimateGradient();
        }

      

        public CGColor[] CurrentGradientSet()
        {
            return new CGColor[]
            {
                _colors[_currentGradient % _colors.Count].CGColor,
                _colors[(_currentGradient + 1) % _colors.Count].CGColor
            };
        }

        public void SetColors(UIColor[] colors)
        {
            this._colors = colors.ToList();
        }

        public void SetPastelGradient(PastelGradient gradient)
        {
            SetColors(gradient.Colors());
        }

        public void AddColor(UIColor color)
        {
            this._colors.Append(color);
        }

        public void AnimateGradient()
        {
            
            _currentGradient += 1;
            var animation = CABasicAnimation.FromKeyPath(KeyPath);
            animation.Duration = AnimationDuration;

            var nsArray = NSArray.FromObjects(CurrentGradientSet());
            animation.To = nsArray;
            animation.RemovedOnCompletion = false;

            animation.AnimationStopped += (sender, e) => {
                _gradient.Colors = CurrentGradientSet();
                AnimateGradient();
            };

            animation.FillMode = CAFillMode.Forwards;

            _gradient.AddAnimation(animation,Key);

        }

        public override void RemoveFromSuperview()
        {
            base.RemoveFromSuperview();

            _gradient.RemoveAllAnimations();
            _gradient.RemoveFromSuperLayer();
        }

    }
}
