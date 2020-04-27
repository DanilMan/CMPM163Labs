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
CUBE 4: I loaded in the both the fragment and vertex shader and passed my texture to my shader which I then used to create the material for my object.
CUBE 5: I again used my fragment and vertex shaders to handle my texture sample. I had to look for a while to figure out how to repeat the texture to create a tiling effect. I knew about GL_REPEAT, and the two lines of code:
glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, GL_REPEAT);
glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_T, GL_REPEAT);
but I couldn't figure out how to incorporate them into my program. Later, I found out that three.js has a wrapS and wrapT property on a texture and I could change it's mapping mode with THREE.RepeatWrapping. I'm sure there's many ways to do this, and I would like to learn more about it.

24.
a) In order to get the pixel of a texture sample from a u value you use u*8, 8 being the x length of the texture sample.
b) In order to get the pixel of a texture sample from a v value you use v*8, 8 being the y length of the texture sample.
c) The uv cordinate (0.375, 0.25) maps to the (3, 2) which is a gray colored pixel.
