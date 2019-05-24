# ZerocIceDemo

Preparation:
- Install IceBuilder.vsix extension for Visual Studio 2015. (IceBuilder is not working in VS 2017)


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
