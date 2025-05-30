/* 
  Questions:

  1) The game is easy in that it's mechanics and gameplay are very simple, but it's hard in the fact that you don't start with a lot of time and it's hard to catch all the powerups 
     given how fast the objects move in comparison to the player, so I personally struggled in getting a time longer than 40 seconds.
  2) You can make the player move a bit faster, that might make the game easier if you have good control and can stop movement at the correct time si=o you don't miss the powerups, but 
     nonetheless faster player movement would make the game more interesting. You can also speed up the movement of the objects to make the game harder/ more challenging. I also think 
     that increasing the amount of time the powerup gives you can help make the game easier.
  3) Changing the way the objects look could give the game a wow factor. I think the powerup looks pretty cool already with it's particle effects but it could look even better if I were
     to replace the sphere with a more interesting looking object. The obstacle looks very plain, given that it's a simple cube, so it would most certainly benefit from being replaced with
     another asset that would make sense with the theme of the game. Another possible wow factor is to have obstacles of different types, some more detrimental than others, as well as having 
     powerups of different kinds. An example for powerups could be there are super fast moving powerups, that are harder to catch than the standard powerup, but they would give you more time
     in comparison to the standard powerup.
  4) The fun part of the game is trying to get the longest time and beat your previous high score. Having to dodge obstacles while trying to get as many powerups as possible is also quite
     fun.
  5) The tedious parts of the game are trying to recover after hitting an obstacle when the game slows down since you know it's going to impact your ability to get the longest time possible.
     Another tedious part of the game is timing the phase out ability, since it might save you from hitting an obstacle but then you lose the ability to get more powerups in that time.
  
  Changes Made:
 
  1) I replaced the cube from the obstacle prefab with a sci fi drone model since I felt as though it fit the asthetic of the game given how the ground and barriers look.
  2) I changed the particle color to be a gradient between yellow and pink/purple. I changed it's size over lifetime using a curve so it can start big and get small over time.
     Under the shape module I changed radius and radius thisckness to .5 so that the particle effects are closer/tighter to the sphere.

 
 */
