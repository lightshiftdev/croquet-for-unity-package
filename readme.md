# Croquet for Unity Package

This repo contains all Croquet functionality as a unitypackage ready to be dropped into a new project. This is for starting your own project. For usage examples please see our tutorials or other demo repos. 

# Install
Clone the Repo with the following command:
```
git clone https://croquet.github.io/croquet-for-unity-package/croquet-for-unity-package.git
```

# Setup
For a completely setup template (ie, to avoid this manual setup), please check out our template repo.

## Unity Project Setup
Create a new Unity Project via the Unity Hub Application.
Remember to use version `2021.3.19f1`
Select 3D (URP) as the pipeline template.
Select a place on disk for this to live (ideally a git repo).

## Use our suggested gitignore for Unity
TODO: Link Demolition gitignore files (for Unity and Croquet general files)

## Get the Package and Dependencies
In Unity Package Manager add the WebView Package via Github Link:
```
https://github.com/gree/unity-webview.git?path=/dist/package-nofragment
```

Add also our package via this link:
```
https://github.com/croquet/croquet-for-unity-package.git
```

## Get NuGet in order to get the WebSocket
Add this to the package manager:
```
https://github.com/GlitchEnzo/NuGetForUnity
```
Use the NuGet Menu item to search for and install `WebSocketSharp-netstandard`

## Copy the Croquet Source File Stubs
In the Croquet Multiplayer Package (Packages>Croquet Multiplayer) there is a folder called `croquet`.
Copy and paste it outside of the unity project directory, at the root directory of your repo.
This provides you the correct scripts, tools, and file heirarchy for our Croquet menu to continuously build your JS source files.

The overall structure of your repo should look like:
```
- /(git repo root)
    - croquet
        - your_app_code_folder
            - Models.js
            - Views-unity.js
        - your_other_app_code_folder
        - build-tools
    - unity
        - your_unity_project
```

## Author your JS Model / View Files
Place your model code inside of the `/croquet/yourappname/Models.js`
Place your view code inside of the `/croquet/yourappname/Views-unity.js`

## Create a Unity Scene

Create a new scene
Add a CroquetBridge Prefab from the Packages Prefabs to your scene.
add your App's name (corresponds to the /croquet/yourappname/ folder) to the Coruqte Bridge Object.

## Author your C# View





# Usage


# Contribution


# License

