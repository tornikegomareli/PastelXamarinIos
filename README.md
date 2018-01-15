🚀🚀

![](https://user-images.githubusercontent.com/24585160/34963497-4a0818a4-fa62-11e7-9f52-9b02bc97da67.gif | width=100)
![](https://user-images.githubusercontent.com/24585160/34963503-53a832d6-fa62-11e7-8579-c57d1b777726.gif | width=100)
![](https://user-images.githubusercontent.com/24585160/34963504-53c4a542-fa62-11e7-9128-ce18e3eea074.gif | width=100)
![](https://user-images.githubusercontent.com/24585160/34963506-53e1b3f8-fa62-11e7-9a73-fa112dfbca90.gif | width=100)


# Pastel library Xamarin-iOS version

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
- Warflame
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

You need to include MPDCPastelXamarinIOS.Extensions namespace to use Colors and Point extension methods.

For startpoint and endpoint you have 8 point choice.

* Left
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

## Credits

This software uses some code exmaples from open source Swift Pastel project.

- [Swift Pastel](https://github.com/cruisediary/Pastel)


## Authors

* **Tornike Gomareli** - *Initial work* - [Tornike Gomareli](https://github.com/tornikegomareli)
* **Giorgi Lekveishvili** - *Initial work* - [Giorgi Lekveishvili](https://github.com/lekve11)


## Licensing

"The code in this project is licensed under MIT license."
