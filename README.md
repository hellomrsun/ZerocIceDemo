# ZerocIceDemo

## Configure Ice & Ice Builder in Visual Studio

#### 1. Install Ice Builder

Install IceBuilder.vsix extension for Visual Studio 2015. 

(PS: IceBuilder is not working in VS2017)

In VS2015, go to "Tools" -> "Extensions and Updates", and make sure Ice builder is enabled.

#### 2. Install zeroc.ice.net and zeroc.icebuilder.msbuild

Right-click your C# project, and click "Manage NuGet packages...", then install "zeroc.ice.net" and "zeroc.icebuilder.msbuild" packages.

Once you have done above things, when you add a ".ice" file, and build your solution, Visual Studio will generate all the necessary C# classes for you to make communication based on Ice.



## Configure Ice & Ice Builder in Java

#### 1. Install Eclipse

#### 2. Install latest version of Ice Windows Installer (3.7.2 for now)

Url: https://zeroc.com/downloads/ice

#### 3. Configure Eclipse with Ice

Open Eclipse, go to "Window" -> "Preferences" -> "Ice Builder".

Then you will see "Ice Home" option, set it to your installed Ice folder path: "C:\Program Files\ZeroC\Ice-3.7.2" (Windows)

#### 4. Install Ice Builder plugin in Eclipse

Go to "Help" -> "Eclipse Marketplace" -> search "Ice Builder"

Then, you will get "Ice Builder for Eclipse 4.1.1"

And then install it.

If you have proxy problem and can't see Eclipse Marketplace,
then, just go to "eclipse.ini". 
And add the following configuration:
```bash
-Djava.net.useSystemProxies=true
-Dhttp.proxyPort={port}
-Dhttp.proxyHost={proxy}
-Dhttp.proxyUser={domain}\{user}
-Dhttp.proxyPassword={password}
-Dhttp.nonProxyHosts=localhost|127.0.0.1|192.168.*|10.*
-Dorg.eclipse.ecf.provider.filetransfer.excludeContributors=org.eclipse.ecf.provider.filetransfer.httpclient4
```

#### 5. Ice Builder displayed 

When you right-click your Java project and check its properties, you'll see "Ice Builder", and it'll have "generated" subfolder for generated java classes by default.

#### 6. Generate Java classes based on .ice file

If you have added a ".ice" file, and want to generate Java classes, you just need to right-click the project and select "Ice Builder", and then click "Compile", then your Java classes will be generated.

Note: When you generate Java classes, you have the choice of Java mapping or Java compact mapping. Java compact mapping will be deprecated soon, so it's better to use Java mapping. Java mapping is also the default option.

