using System;
using Foundation;
using UIKit;

namespace MPDCPastelXamarinIOS.Interfaces
{
    public interface IPastelLableAble
    {
        string Text { get; set; }
        UIFont Font { get; set; }
        UITextAlignment TextAlignment { get; set; }
        NSAttributedString AttributedText { get; set; }

    }

}
