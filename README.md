[![C#](https://img.shields.io/badge/Language-C%23-red)](https://en.wikipedia.org/wiki/C_Sharp_(programming_language)) 
[![YO?](https://img.shields.io/badge/Keyuath-Loader-yellowgreen)](https://keyauth.com/) [![Windows](https://img.shields.io/badge/Platform-Windows-brightgreen)](https://en.wikipedia.org/wiki/Microsoft_Windows) [![xArch](https://img.shields.io/badge/System%20Arch-Any%20CPU-blue)](https://en.wikipedia.org/wiki/X86-64) [![License](https://img.shields.io/badge/License-MIT-pink)](LICENSE)

# ZEN, A DECENT LOADER EXAMPLE CREATED IN .NET 

A C-Sharp multipurpose loader created using KeyAuths api. This loader can be used to create a cheat loader or spoofer or even a tool / utilty application.

<p align="center">
  <img  src="Preview.gif">
</p>

## Features
Zen provides a rich set of features to help increase user performance, security, gui design and overall feel:

*   **Login UI** - Login with username and password supported as well as registering.
*   **GUI** - Example of theming setup within the loader.
*   **Themes** - Both light and dark have been added.
*   **Splash Screen** - Help prevent lag and other issues using the cool splash.
*   **Random Strings** - Title changing, Exe renaming.
*   **Security** - Win32 InputBlock, Anti Dump and Anti Debug protection.
*   **Inproved Update System** - Structure for auto application updates has been adjusted.

## Keyboard Input Handling
ZEN respects security, using Win32 api you are able to freeze Input devices. For example, while running important code, loading drivers or even freezing due to vulnerability. This can be accessed using the code below, simply add this to your desired class / form.

```java
// With out a timer enable / disable user input block.

public static void BlockInput(bool toggle)
{
    if (toggle)
    {
        ZEN._0x02.mcyAy.BlockInput(true);
    }
    else if (!toggle)
    {
        ZEN._0x02.mcyAy.BlockInput(true);
    }
}

// Blocking user input for a period of time.

public static void BlockInput(int time)
{
    ZEN._0x02.mcyAy.BlockInput(true);
    Thread.Sleep(time);
    ZEN._0x02.mcyAy.BlockInput(false);
}
```
## Optional Code
Auto application updating can be found within the login form. (vYFEC.cs) If you wish to disable auto updates then remove the code below.

```java
if (!whLOn.response.success)
{
    if (whLOn.app_data.version != whLOn.version)
    {
        whLOn.CheckUpdate(); // Auto update application.
    }
    else
    {
        mqFCG msg = new mqFCG("ERROR", whLOn.response.message, 235, 75);
        msg.Show();
        Environment.Exit(0);
    }
}
```

An replace with this code to contiune to check for errors.

```java
if (!whLOn.response.success)
{
    mqFCG msg = new mqFCG("ERROR", whLOn.response.message, 235, 75);
    msg.Show();
    Environment.Exit(0);
}
```

Exe Renaming after exiting main gui. This code can be found in (qHPrx.cs) remove this code below to disable this feautre.

```java
private void qHPrx_FormClosing(object sender, FormClosingEventArgs e)
{
    // Sets new name of exe file every time application is closed -> But only on the main form (This One!).
    
    try { File.Move(_0x02.mcyAy.AppName, _0x02.mcyAy.RandomString(5) + ".exe"); } catch { }
}
```
## Installing
Download this repo and extract to desired location, Make sure you have the latest version of .Net Framework installed as well as Visual Studio 2019 or later. All resources needed can be found below.

# Information
If any errors / issues are found with ZEN resources you can find them below.

*   **DLLS** - https://anonfiles.com/f1l8E6t8yf/Dlls_zip
*   **Light Particles** - https://github.com/alonelydev7932/particles-light.github.io
*   **Dark Particles** - https://github.com/alonelydev7932/particles-dark.github.io

# Using ZEN Resources In Your Own Projects
If you do not need the full loader you can use ZEN resources within your own project view information below on how to do so.

Installing and using EO components

* Download and add the dlls above to your project.
* Add this line of code below to your main class or form.

```java
public Form1()
{
    EO.WebBrowser.Runtime.AddLicense("6A+frfD09uihfsay4Q/lW5f69h3youbyzs2xaqW0s8uud7Pl9Q+frfD09uihfsay6BvlW5f69h3youbyzs2xaaW0s8uud7Pl9Q+frfD09uihfsay6BvlW5f69h3youbyzs2xaqW0s8uud7Oz8hfrqO7CzRrxndz22hnlqJfo8h/kdpm1wNyuaae0ws2frOzm1iPvounpBOzzdpm1wNyucrC9ys2fr9z2BBTup7Smw82faLXABBTmp9j4Bh3kd+T20tbFiajL4fPRoenW2RX4ksbS4hK8drOzBBTmp9j4Bh3kd7Oz/RTinuX39ul14+30EO2s3MLNF+ic3PIEEMidtbXE3rZ1pvD6DuSn6unaD7112PD9GvZ3s+X1D5+t8PT26KF+xrLUE/Go5Omzy/We6ff6Gu12mbbB2a9bl7PP5+Cd26QFJO+etKbW+q183/YAGORbl/r2HfKi5vLOzbFqpbSzy653s+X1D5+t8PT26KF+xrLoEOFbl/r2HfKi5vLOzbFppbSzy653s+X1D5+t8PT26KF+xrLoEOFbl/r2HfKi5vLOzbFqpbSzy653s+X1D5+t8PT26KF+xrLhD+Vbl/r2HfKi5vLOzbFppbSzy653s+X1");
}
```

* Add url to webview for example ZEN particles or download and edit the html web page your self from the above link Light / Dark Particles.

# Outtro
* Created in .Net by alonelydev7932
* Discord: alonelydev#7932
* Only message me if you have a valid issue.
