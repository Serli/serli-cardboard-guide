## Prérequis ##

A phone which can run google cardboard applications : 
https://www.original-cardboard.com/telephones-compatibles-cardboard/

Google cardboard V2 : 
https://store.google.com/product/google_cardboard?utm_source=google-cardboard&utm_medium=MS&utm_campaign=Google_Cardboard
This project can't work with google cardboard v1 (with magnet button) 


## How to use ##
% Install Unity % 
To use this application, you may run this project whith Unity. 

% Download Android SDK %
File > Build Settings...
Click on android and download the android SDK. Then switch platform for android.

% Download JDK % 
You have to download JDK and put the link in File > Preferences > External Tools > JDK 

% Plug the phone % 
The phone have to be in developper mode and in USB deboging. 
Then plug a android phone compatible with google cardboard and build&run (File > Build & Run) the application. 

Put the phone in google cardboards and enjoy ! 


## Known bugs ##

VR: OpenVR Error! OpenVR failed initialization with error code VRInitError_Init_PathRegistryNotFound: "Installation path could not be located (110)"!


This is simply means that there is a problem with either your SteamVR installation (of SteamVR itself - not the SteamVR Plugin in Unity) or with Unity's native VR support. 
This is a known error in certain versions of Unity and both Unity and Valve have said they will fix it in one of the 5.4 patch releases. 
However, if you get this error it should not affect your ability to play your scene. 
The VRSimulator will still take command of your camera and adjust for the lack of a connected HMD. You can safely ignore this error.
Link : https://docs.immerseum.io/vr-simulator-beta-0.9/topic6.html


## Project Hierarchy ##
All the scenes are in the folder "Scenes", and the scripts in "Scripts". 



This application is a guide of Serli's place developped by Serli. 