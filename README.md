# visualstudio-icap-mvc-plugin-templates

### _ICAP MVC Plugin project templates for Visual Studio 2017._

## Instructions:

#### Install the templates
1.  Clone or download repo contents to:  
`%HOMEPATH%\Documents\Visual Studio 2017\Templates\ProjectTemplates\Visual C#`.  
_e.g. `C:\Users\<UserName>\Documents\Visual Studio 2017\Templates\ProjectTemplates\Visual C#`_

#### Open the PMobile solution in Visual Studio
1.  Start Visual Studio 2017.
1.  **Load the PMobile for Android solution,** PMobile.sln.

#### - _EITHER_ -

#### Create an Application Plugin
1.  Right-click the `Plugins` folder.
1.  Select `Add`>>`New Project...`.
1.  Select `Installed`>>`Visual C#` from the template categories tree in the left panel.
1.  Select `ICAP MVC Plugin for Xamarin` from the templates list in the right panel.
1.  Enter a unique name for your plugin in the `Name:` field.  
_The name of application plugins should end in "Plugin", e.g. "MyAmazingPlugin"._
1.  **Append** `\Plugins` **to the** `Location:` **field.**
1. Press the `OK` button.
1. **See** `ReadAndDeleteMe.txt` **in the plugin project for further instructions.**

#### - _OR_ -

#### Create a Service Plugin
1.  Right-click the `Services` folder.
1.  Select `Add`>>`New Project...`.
1.  Select `Installed`>>`Visual C#` from the template categories tree in the left panel.
1.  Select `ICAP MVC Service for Xamarin` from the templates list in the right panel.
1.  Enter a unique name for your plugin in the `Name:` field.  
_The name of service plugins should end in "Service", e.g. "MyAmazingService"._
1.  **Append** `\Plugins` **to the** `Location:` **field.**
1. Press the `OK` button.
1. **See** `ReadAndDeleteMe.txt` **in the plugin project for further instructions.**
