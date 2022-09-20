# CS428-P1-SOYLU

### INTRO

This is my first project for the CS428: Augmented and Virtual Reality course at UIC. I used Unity with Vuforia to create two AR knickknacks, similar to the kinds of trinkets one can buy at gift shops to remind you of the place you visited. The two destinations I chose were Kennedy Space Center in Florida, USA, and the Golden Bridge in Da Nang, Vietnam.

### HOW TO USE

Please make sure to first install Unity Editor version 2021.3.6f1, and build the two papercraft Vuforia cubes.

###### REQUIREMENTS:
- Unity Editor 2021.3.6f1
- Vuforia 10.10 (should come with the source code)
  - Note for Andy: Using Vuforia 10.9 was causing Unity to constantly crash for me, while 10.10 seems to work. I don't know why.
- A working webcam
- Two little Vuforia cubes (https://www.evl.uic.edu/aej/428/CubesForVuforia.zip)

##### Viewing the knickknacks in Unity

**TL;DR: Download source code, open project in Unity, hold up cubes in front of your webcam. **

To view the knickknacks yourself, you can download the projects source code from the github page.

![Downloading .zip of the source code from github](https://imgur.com/KZUyX48.jpg)

Unzip this file into the directory of your choice. 

In the upper right corner of the Projects tab of Unity Hub, click 'Open'.

![Opening a new project in Unity Hub](https://imgur.com/jSgcROR.jpg)

Navigate to the directory you extracted the project into, select the project folder and press 'Open' once again.

![Select the project folder](https://imgur.com/6MymIOZ.jpg)

The project should now be visible in the list. Make sure the correct Editor version is selected.

![Project in Unity Hub](https://imgur.com/4c6TZsy.jpg)

Click on the project to open it in Unity Editor. It may take a while to load, but once it is open, you should see the two cubes in the scene.
To view the cubes in AR mode, press the play button in the upper part of the window.

![Press the play button in Unity Editor](https://imgur.com/jrESw5X.jpg)

This will open your webcam, and you will be able to view the knickknacks by holding up the two Vuforia cubes you painstakingly built earlier.

###### Installing Unity:
Go to https://unity.com/ and download and install Unity Hub. Once you have it ready, open it and click Installs, and then Install Editor to add a new Unity version. For version **2021.3.6f1**, which is the version I used to create this program, we have to click the Archive tab and then the Long-Term Support text to open the online download archive in your browser. Click on LTS Release 2021.3.6f1 and Unity Hub will start installing that version. (Note: other/newer versions of Unity might still work with this project, but this is the version I worked with.)

You should have it install:

- Unity
- Documentation
- Android Build Support (for running on the Oculus Quest, or Android Smartphone)
  - click on the little arrow and make sure Android SDK & NDK Tools and OpenJDK are both selected
- iOS Build Support

**NOTE:** You will need to be admin / root to install Unity in the default location, otherwise Unity Hub will download the files and then fail (mostly silently) on the install. To get around this you can click on the gear on the left pane of Unity Hub, click on Installs, and then change the Installs Location to a place you do have write access to, say somewhere in your home directory.

*Unity installation instructions adapted from Andy Johnson's CS428 website (https://www.evl.uic.edu/aej/428/syllabus.html)*

### ASSETS USED
##### Kennedy Space Center
1. Flag model by me
![](https://imgur.com/lPoeIqV.jpg)

2. Moon ground model by me
![](https://imgur.com/tUvlL6F.jpg)

3. Astronaut by Poly by Google [CC-BY] (https://creativecommons.org/licenses/by/3.0/) via Poly Pizza (https://poly.pizza/m/dLHpzNdygsg)
![](https://imgur.com/ysXR1h2.jpg)
I edited it to be lower poly using Blender (for better performance)

4. Earth by Poly by Google [CC-BY] (https://creativecommons.org/licenses/by/3.0/) via Poly Pizza (https://poly.pizza/m/88CP80Kgb-u)
![](https://imgur.com/9cRkecu.jpg)

5. Rocket ship by Poly by Google [CC-BY] (https://creativecommons.org/licenses/by/3.0/) via Poly Pizza (https://poly.pizza/m/4mPkOKdzAk-)
![](https://imgur.com/2ZqGScn.jpg)

6. US flag from Wikimedia Commons (https://commons.wikimedia.org/wiki/File:Flag_of_the_United_States.svg)
7. Kennedy Space Center logo from Wikipedia (https://en.m.wikipedia.org/wiki/File:Kennedy_Space_Center_Logo.svg)

##### Golden Bridge
1. Bridge model by me
![](https://imgur.com/Cu5DIPk.jpg)

2. Green knickknack base by me
![](https://imgur.com/0bGoUpS.jpg)

3. Low Poly Right Hand by Raziq Brown [CC-BY] (https://creativecommons.org/licenses/by/3.0/) via Poly Pizza (https://poly.pizza/m/cl8ax5B13cp)
![](https://imgur.com/9Og8GYg.jpg)
I just flipped it in Unity to create a left hand to go with it

4. Mountain Scene by Mike Boyer [CC-BY] (https://creativecommons.org/licenses/by/3.0/) via Poly Pizza (https://poly.pizza/m/erukwNZWue-)
![](https://imgur.com/TFRVPRB.jpg)

5. Pine tree by Poly by Google [CC-BY] (https://creativecommons.org/licenses/by/3.0/) via Poly Pizza (https://poly.pizza/m/bpV3f5je3rl)
![](https://imgur.com/VvF2n8O.jpg)

6. Cloud by Poly by Google [CC-BY] (https://creativecommons.org/licenses/by/3.0/) via Poly Pizza (https://poly.pizza/m/44cGXp6_8WD)
![](https://imgur.com/KPEc4UD.jpg)

7. Da Nang logo from Da Nang goverment official website (https://danang.gov.vn/web/en)


