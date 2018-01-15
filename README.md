🚀🚀


# Pastel Xamarin-iOS version

Pastel is swift library for gradient animation effects, we've inspired from this project.
Xamarin-iOS didn't had anything like gradient animation library, so we rewrited C# version of it for Xamarin.

## Installing / Getting started

A quick introduction of the minimal setup you need to get pastel in your project

From tomorrow you can install library from Nuget packages.

```
  # Install the MPDCPaletXamarinIOS package to the project named MyProject.
    Install-Package MPDCPaletXamarinIOS -ProjectName 
```

Until tomorrow you can just clone it and add as reference in your project.

## Developing

This project is in very begining stage, so if you have some improvements or bug fixes, feel free to send PR


## Example

```C#
public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Initializing pastelView object
            var pastelView = new MPDCPastelXamarinIOS.PastelView(View.Bounds);

            pastelView.AnimationDuration = 2.0;

            // init start point and end point
            pastelView._startPoint = PastelPoint.BottomLeft.Point();
            pastelView._endPoint = PastelPoint.TopRight.Point();


            // seting  colors
            pastelView.SetColors(PastelGradient.WinterNeva.Colors());
            
            // pastelView.AddColor(SecondGradientColor); 

            pastelView.StartAnimation();
            View.InsertSubview(pastelView,0);
        }
}
```
In PastelGradient enum,  we have some custom gradient colors 
 PastelGradient : - Warflame
                  - NightFade
                  - SpringWarmth
                  - JuicyPeach
                  - YoungPassion
                  - LadyLips
                  - SunnyMorning
                  - RainyAshville
                  - FrozenDreams
                  - WinterNeva
                 
You can use this custom colors, or feel free to add some more gradient colors.

In SetColors method you can implement and add your own colors array.
You can also add one UIColor in AddColor method.

You need to include MPDCPaletXamarinIOS.Extensions namespace to use Colors and Point extension methods.

For startpoint and endpoint you have 8 point choice.

PastelPoint : * Left
              * Top
              * Right
              * Bottom
              * TopLeft
              * TopRight
              * BottomLeft
              * BottomRight

## Contributing

"If you'd like to contribute, please fork the repository and use a feature
branch. Pull requests are warmly welcome."


## Licensing

"The code in this project is licensed under MIT license."
