

# What is an Augmented Reality Business Card ?
At first glance, it’s an ordinary card, but when you open it with an BCard application on smartphone,
it opens up into a 3D product model. 
Wait! There is more. These business cards may include way more information and even product catalogs.

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



## Tools & languages:
- Unity (game engine)
- C# (Script Code)
- Vuforia (AR Platform)
- Visual Studio Code (Text editor)