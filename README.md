# EasyAR - Xamarin Wrapper

----
## What is it?
[EasyAR](https://www.easyar.com/) provides a C# API for their Augmented Reality framework, however, using this API in a cross platform manner via Xamarin isn't straight forward.  This project wraps the EasyAR provided API to make it easier to use in crross-platform Xamarin Android/iOS projects using the bait-and-switch trick described [here](https://log.paulbetts.org/the-bait-and-switch-pcl-trick/).

----
## Usage
Generate(*nuget pack EasyARX.nuspec -Version 3.0.1.0 -OutputDirectory ~nuget*) or download, and install the nuget package into each project(Shared,iOS,Android).

Initialize EasyAR in the platform specific classes using a key provided by EasyAR as described in the [Getting Started Guide](https://help.easyar.com/EasyAR%20Sense/v3/Getting%20Started/Getting-Started-with-EasyAR.html).

For iOS do the following in you Application Class:
>EasyAR.Engine.initialize(KEY);

For Android do the following in your Activity Class:
>EasyAR.Engine.initialize(this, KEY);

After initialization all code can be written in the shared project using the EasyAR C# API.

## License

While this project is [unlicensed](http://unlicense.org/), it wraps and depends on the SDK distributed by [EasyAR](https://www.easyar.com/) and licensed under [EasyAR's licensing terms](https://easyar.com/view/protocol.html).

This projects goal is solely to make it simpler to use EasyAR in a Xamarin project, not to replace, fix, test, or add any functionality to EasyAR itself.