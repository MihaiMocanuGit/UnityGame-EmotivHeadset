
# **Out of development since 2020**
This project is not maintained

# Summary

This project consists of a ping-pong game which was made to work along-side the Emotiv Epoch headset. The role of this app was to test the hypothesis that games can be used in managing social anxiety

This game won gold medal at ROSEF 2020 and I-FEST^2 2020.

It relies on the Emotiv Epoch Headset to work properly. The reason why it's not just a standalone game is because our team used this headset to monitor the stress, excitement, engagment, focus, interest and relaxion levels of the player. According to these parameters the game changes its dificulty and certain in-game events are triggered. 

# Gameplay (short description)

This game presents you with a specially controled environment:

* Firstly you join what appears to be a multiplayer match of ping-pong with 3 other real players.
* The catch is that you are actually playing a singleplayer game with 3 bots and this ping-pong match is not a fair one. 
* The game analyzes your stress level with the emotiv epoch headset and using this data it changes the behaviour of the enemy team and game logic:
	* The enemy team subtly includes or excludes you from the game -by passing more or less often to your teammate- in such a way that your stress levels are maintained in a predefined range
	* When a score is set, the ball will reset near you more or less frequently.
	* Bonus points might be added to your team or enemy team from time to time.

# How I integrated the base game with the Emotiv Headset

During development of this game, emotiv launched an unity plugin which can be used to connect to the emotiv API, unfortunately at that time there wasn't any documentation made for this plugin.

As such I had 3 choices:
1. Don't change anything and use the old script that had to be launched before starting the game. This script was made to connect to the headset and output it's data.
1. Reverse engineer the unity example so as to understand how the whole plugin works. Unfortunately this way would take too much time and I didn't have enough until the start of the inovation contests.
1. Understand the unity example well enough to be able to obtain the already processed data from it. 

Understandably, I resorted to the 3rd option. As I result, I merged my unity game with the unity example.

# Emotiv Unity Example

This example demonstrates how to work with Emotiv Cortex Service (aka Cortex) in Unity.

## Prerequisites

* Install Unity. You can get it for free at [www.unity3d.com](https://unity3d.com/get-unity/download).
* Get the latest version of [Emotiv Unity Plugin](https://github.com/Emotiv/unity-plugin) as a submodule.
```
       git submodule update --init
```
* Install and run the EMOTIV App with Cortex from (https://www.emotiv.com/developer/).
* Login to the Emotiv website with a valid EmotivID, register an application at https://www.emotiv.com/my-account/cortex-apps/ to a pair of client id and client secret. If you don't have a EmotivID, you can [register here](https://id.emotivcloud.com/eoidc/account/registration/).
* We have updated our Terms of Use, Privacy Policy and EULA to comply with GDPR. Please login via EMOTIV App to read and accept our latest policies in order to proceed with the following examples.

## How to compile
<!-- how to compile  -->
1. Open EmotivUnityPlugin.unity by Unity Editor.
1. Put your client id and client secret to AppConfig.cs.
1. You can run the examples directly from the Unity Editor.


## Code structure

There are some main controller scripts:

**ConnectToCortex.cs**: Initialize connection to Cortex.

**1_Cortex**: Contain commponent scripts to control authorization procedure.

**ConnectHeadset**: Contain commponent scripts to create headset element and list headset information.

**ConnectionIndicator**: Contain commponent scripts to show battery indicator, after headset is connected and device information is subscribed.

**ContactQuality**: Contain commponent scripts to show contact quality of headset sensors.

**DataSubscriber.cs**: The script to show subscribe and unsubscribe data. The header and data of corresponding streams will be displayed and updated. Note that the MARKERS channel of EEG data will not be shown.

**Emotiv-Unity-Plugin**: The plugin that works behind the scene. Please refer to [Emotiv Unity Plugin](https://github.com/Emotiv/unity-plugin).

## How to use
1. Put clientId, clientSecret of your application in AppConfig.cs. You also can configure application name, version and TmpAppDataDir to create log directory.
1. Make sure you have logged in via EMOTIV App, and the headset has been turned on.
1. Run the example from editor. The example will connect to Cortex for authorization. You might need to grant access right for the example via EMOTIV App at the first time. After that, the example will get the token to work with Cortex. The token will be saved for subsequent use.
After authorizing successfully, the example will list available headsets. 
1. Click on a headset button to create a working session with that headset, and subscribe to the device information.
1. Please make sure the headset is at good contact quality and click Done to proceed.
1. Now, you can subscribe or unsubscribe more data such as EEG, Motion and Performance Metrics.
1. When you run the application in standalone mode, the log files will be located at "%LocalAppData%/${TmpAppDataDir}/logs/" on Windows or "~/Library/Application Support/${TmpAppDataDir}/logs" on macOS.

## Change log

[12 May 2020]
- Subscribe data streams: EEG, Motion, Performance Metric, Device information
- Supports EPOC, EPOC+, EPOC X and Insight.

## License

The Emotiv Example is licensed under the MIT License - see the [LICENSE.md](https://github.com/Emotiv/cortex-v2-example/blob/master/LICENSE) file for details
