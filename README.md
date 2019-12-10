# AR-Fly-And-Search
Android Game made with Google ARCore and Unity C#

<img src="https://lucasgigliozzi.com/wp-content/uploads/2019/11/arflyandsearchpic-145x300.png" width="200" height="350" />

### Description: 
AR Coin Search is a mobile game compatible with Android and iOS (only tested with Android). The user must control their avatar to collect coins as they spawn. 

### Languages/Libraries/Frameworks: 
Unity, C#, Google ARCore

### Explanation: 
The functionality of the game is as follows: the app takes the users camera input and imposes an avatar over it. The user must control their avatar with a joystick for x and y plane movements, and a slider for z plane movements. One coin object will spawn at a time. The user must pan their camera around to find the object. Once you find the coin, navigate your avatar to capture it. But be careful, because you only have a limited amount of time! Capturing a coin will increment your score and increase the time limit by 15 seconds. Capture as many coins as you can before the time runs out!

### How it works:
Unity was used for object and model design as well as the central game engine. Google ARCore and its additional Unity objects were used to enable camera capture to create the game world. In combination, these two platforms were responsible for displaying the game objects and environment via camera capture from the users mobile device. C# scripts were used to enable interactions between game objects, as well as for score and time keeping. 

<img src="https://lucasgigliozzi.com/wp-content/uploads/2019/11/argamedragon.gif" width="200" height="200" />
