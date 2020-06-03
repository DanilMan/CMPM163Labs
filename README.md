# CMPM163Labs

## Lab 2

https://drive.google.com/file/d/1DHHXDYq4aucAgJnbjUAhaxmkKC8zRO7j/view?usp=sharing

![](lab2/lab2_part2.png)

## Lab 3

https://drive.google.com/file/d/1Q60xYiMiFD4jxCfeGd2AZpRJM240OXfW/view?usp=sharing

## Lab 4

https://drive.google.com/open?id=1lE-ZvlHttUzJwE-_QKegnCJCoAHnNI2J

CUBE 1: I simply used three.js's loadTecture method to load in the jpg and I added it to my material.

CUBE 2: I used the same method that I used for the previous cube, but also added a second texture that I added onto my material as a normal map, that paired with the texture.

CUBE 3: I used the same methods from the previous cube, but for this one I found a colorful texture and matched it with a very bumpy normal map that made it look very interesting.

CUBE 4: I loaded in both the fragment and vertex shader and passed my texture to my shader which I then used to create the material for my object.

CUBE 5: I again used my fragment and vertex shaders to handle my texture sample. I finished the first portion of this part by multiplying the uv by 2.0, when defining my 2D texture in my fragment shader. This doubled the size of my uv map, and moved the texture down the the bottom left corner of the face of the cube. But the texture didn't tile or repeat, instead it had a clamp to edge effect, which was probably the default for the texture. I had to look for a while to figure out how to repeat the texture to create a tiling effect. I knew about GL_REPEAT, and the two lines of code:
glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, GL_REPEAT);
glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_T, GL_REPEAT);
but I couldn't figure out how to incorporate them into my program. Later, I found out that three.js has a wrapS and wrapT property on a texture and I could change it's mapping mode with THREE.RepeatWrapping. I'm sure there's many ways to do this, and I would like to learn more about it.

24)

a) In order to get the pixel of a texture sample from a u value you use u*8, 8 being the x length of the texture sample.

b) In order to get the pixel of a texture sample from a v value you use v*8, 8 being the y length of the texture sample.

c) The uv coordinate (0.375, 0.25) maps to the (3, 2) which is a gray colored pixel.

## Lab 5

#### 1. The link to a video of me moving around the static particles that change colors
https://drive.google.com/open?id=1VFNOXfXAqMg39t560XlvyMIl6LIVKDlK

#### 2. The link to a video of the explosion of particles
https://drive.google.com/file/d/1eqCSIIOheGmgH8alJD2OXDDV2M0YPESw/view?usp=sharing

#### 3. The link to a video of my custom particle animation
https://drive.google.com/open?id=1-QaMj-mK0dXx-cWE5BqGzae2lGpD_bmZ

In order to create this animation, I used the combination of the sine and cosine math functions in javascript with the performance.now function, to give me a continous increase in numbers, to form a rotational pattern along the x, y and z axis of the particle group. I also used the same method to animate the lights around the dog mesh.

## Lab 6

#### i. Screenshot of objects:
![](lab6/unitylab6.jpg)
#### ii. Definitions:
Point light: Sends light out in all directions equally within its radius.

Spotlight: Sends light out in a cone-shaped region from its constrained angle.

Directional light: Simulates sunlight like light, infinitely far away, that light up the scene from a specific angle.

Area light: Defined by a rectangular space, the light is emitted in all directions across its surface, from one side of the rectangle.
#### iii.
Real object:
![](lab6/realcandle.jpg)
Recreation:
![](lab6/unitycandle.jpg)
#### iv. Explanation of object's material:
For the object I started by making a basic mesh of the candle in Maya. Then I imported it into unity and I used the standard shader and used the Fade rendering mode on the glass container. I made it pretty metallic, so it would be very reflective, and I set it to around 80% smoothness and it became shiny like glass. I also added a texture and a normal map of a dimpled material. The wax I used the image of a bumpy wall for the metallic texture and turned the smoothness pretty low. I also added a normal map of the texture. Lastly, the wick I simply shrunk a simple cylinder object in unity and added the wood texture from the ground and used the glass normal map and brought down its metallic and smoothness levels.
#### v. Description of two textured objects:
I used a wood texture and normal map for the plane I used as the ground for my scene. I also used a charred wood texture and normal map for the sphere.
#### vi. Description of skybox:
For the skybox I downloaded the AllSkyFree pack from the unity asset store and used their Deep Dusk skybox.

## Lab 7

#### part 2a texture 1 with height map:
![](lab7/terrain.png)
#### part 2a texture 2 with height map:
![](lab7/BOB.jpg)
video of image:
https://drive.google.com/open?id=1haDZuBR9nxYjdTwkyL-rqULAi4nH7rSx
#### part 2b:
video of waves:
https://drive.google.com/open?id=1G6Pu9upCQVyLVUrkFdk1a6WRw_MLYV5g
#### part 2b:
Inspiration (Bob Ross):
![](lab7/real_bob.png)
Mountain + Water scene:
![](lab7/lab7+2c.jpg)
video of scene:
https://drive.google.com/open?id=1HJY7PDIFFiSav-u2qM9GMqoOlmco2NkC
##### accidental modern art:
![](lab7/water.png)
#### Group Members:
My partner, Matthew, worked on the part 1 portion for this lab and created a scene in Unity with an island, which he used basic shapes with a vertex shader on them to make them look rigid like a stone island. He also added a yellowish light flowing out from the center of the island which imitated the last scene from a favorite film of his, which was pretty amusing. Lastly, for the water's waves, he chose to use a height map on it in order to make it look more realistic instead of just using basic sine wave motion in its vertex shader, and that was pretty impressive.

## Lab 8

#### image of insirational city:
![](lab8/NY_housing.jpg)
#### image of generated city:
![](lab8/Procedural_City.jpg)
#### My Design:
I remembered that city from playing GTA Liberty City and so I wanted to attempt to recreate it with the procedural generation. I found some buildings that looks somewhat similar on the unity asset store. The grassy portions are also perfect since that part of New York has green patches of land in between some of the buildings.
#### My Partner's Design:
1. He chose part 1.

2. He found that making the colors of his buildings feel cohesive and intentional while still random and varied was most challenging.

3. He discovered that changing the scale of the buildings to match the project's gameplay while still adding to the functionality of the core loop, was the most interesting aspect of the project, imaging he was working towards producing a video game map to play on.

## Lab 8

### part 1:
#### image of unity tutorial L-System:
![](lab9/first_tree.png)
#### image of my unity L-System:
![](lab9/tree.png)

Link to video of tree growth:
https://drive.google.com/open?id=1KSwH6gdae-k4wNS78KD6h7VYJ46uOlQV
#### Description:
I changed the original tutorial rules of F -> FF+[+F-F-F]-[-F+F+F] into F -> FF+[+F-F>[<F>F>]-F]-[-F+F<[>F<F<]+F], but I added in a new break with the brackets to add more spliting to my algorithm. The '<' and '>' characters are meant to now change the angle in the perpendicular axes, so that my "tree" could split off into 3D space and look slightly more real. The way I did that was simply adding code for if getting the '<' or '>' characters it then rotated the game object in its X axis instead of its Y like the '+' and '-' characters do. I also added a color randomizer that varried in ranges from a darker brown (in the first generation), to varying greens (in the last generation).
  
### part 2:
#### first image of tutorial tree:
![](lab9/1stclick.png)
#### second image of tutorial tree:
![](lab9/2ndclick.png)
#### third image of tutorial tree:
![](lab9/3rdclick.png)
#### fourth image of tutorial tree:
![](lab9/4thclick.png)

#### first image of my tree:
![](lab9/firstI.png)
#### second image of my tree:
![](lab9/secondI.png)
#### third image of my tree:
![](lab9/thirdI.png)
#### Description:
I played around with the original tutorial formula again, but this time I wanted to make it was more chaotic. So I used the formual F -> FF-[+F-]+[+F-[-F-[+F-F+]-F+]-[-F+[+F-F-F+]+F+F-F] which I tried to make sure that the angle always changes before and after each line is drawn. I also added in many brackets to make it very recursive and wild. I think the final result shows that.
