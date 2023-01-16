

# What is this Augmented Reality Business Card ?
At first glance, it’s an ordinary card, but when you open it with an BCard application on smartphone,
it opens up into a 3D product model. 
Wait! There is more. These business cards may include way more information and even product catalogs.

# IEEE Research Paper Published :
https://ieeexplore.ieee.org/document/9936445

This 𝐫𝐞𝐬𝐞𝐚𝐫𝐜𝐡 𝐩𝐚𝐩𝐞𝐫 presents an innovative approach to promote the business and bring customer’s attention to its product and portfolio using augmented reality 3D business cards. Since this AR business card could inculcate information about the card owner in the form of audio, video, images, and animated moving objects, which are way beyond than an ordinary printed business card could ever incorporate. It appears as a regular business card at first glimpse, but it opens up into an interactive 3D augmented business card on scanning it through a mobile device. This AR business card comes with the benefit that the card could be customised anytime according to the changing business and market needs.

**Published in: 2022 Second International Conference on Computer Science, Engineering and Applications (ICCSEA).**

# How I built this AR business card ?

Well, this is an interactive business card that consists of AR Virtual buttons
This AR Business Card project uses Unity 3D and Vuforia SDK to display an Augmented Reality card when
the image target( that is our BCard here ) shows up. 

1) I uploaded BCard image on Vuforia Dev Portal and pasted License key under License Key section in Unity.
2) Then, I Downloaded the AR BCard Database and imported in onto my Unity Project.
3) Then added AR Virtual Buttons on specific areas ( like Profile Button and Resume Button).
   { So that whenever user clicks on those Virtual Buttons, tasks added to those Virtual buttons will be instantiated,
     Here, on pressing Resume button (Resume Image shows up)
     and on pressing Profile button (My Profile Video starts playing)
   }
 4) Also added 3 web-links ( GitHub, LinkedIN, Gmail ) so that on clicking those icons, user will be redirected to those webpages.
 5) Added more than hundred 'Sphere' balls prefab with animations of falling and rotation.

## How to use this AR Business Card app ?
  1. Download and print BCard Image Target.  
  2. Install (AR Card v1) apk file on your android mobile.
  3. On starting the application, place the BCard Image Target infront of Camera Screen.
  4. Press Virtual buttons( that are Profile and Resume button) on the card.
     - On Pressing Profile button, my Profile video starts playing above the AR card.
     - On Pressing Resume button, my Resume shows up.
  
## Tools & languages:
- Unity (game engine)
- C# (Script Code)
- Vuforia (AR Platform)
- Visual Studio Code (Text editor)

## Screenshots :-

<img src="https://github.com/utkarsh-yadav1231/Augmented-Reality/blob/master/AR%20Business%20Card/Screenshots/Bcard%20(8).jpg" alt="SS 1"/>

<img src="https://github.com/utkarsh-yadav1231/Augmented-Reality/blob/master/AR%20Business%20Card/Screenshots/BCard%20(Profile).jpg" alt="SS 2"/>
