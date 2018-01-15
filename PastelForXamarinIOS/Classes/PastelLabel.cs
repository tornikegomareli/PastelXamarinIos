using System;
using CoreGraphics;
using Foundation;
using MPDCPastelXamarinIOS.Interfaces;
using UIKit;

namespace MPDCPastelXamarinIOS
{
    public class PastelLabel : PastelView,IPastelLableAble
    {
        private UILabel label = new UILabel();

        public PastelLabel(CGRect frame) : base(frame)
        {
            setup();
        }

        public string Text 
        {
            set {
                label.Text = value;
            }
            get{
                return label.Text;  
            }
        }
        public UIFont Font 
        {
            set{
                label.Font = value;
            }
            get{
                return label.Font;
            }
        }
        public UITextAlignment TextAlignment
        { 
            set{
                label.TextAlignment = value;
            }
            get{
                return label.TextAlignment;
            }
        }
        public NSAttributedString AttributedText 
        { 
            set{
                label.AttributedText = value;
            }
            get{
                return label.AttributedText;   
            }
        }

        private void setup()
        {
            TextAlignment = UITextAlignment.Center; 
            this.MaskView = label;
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            setup();
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            label.Frame = Bounds;
        }
    }
}
