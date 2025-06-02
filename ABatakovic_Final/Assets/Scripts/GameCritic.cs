/* 
 Improving the Game:

1) The game is hard in that it is hard to actually purposfully hit a ball since they are moving around really fast, but it's easy in that a lot of the time the balls randomly hit the goals
on their own without you needing to put in any effort.

2) Slowing down the balls and increasing the players walk speed might help make the game a bit easier. Putting more obstacles in the arena could make the game harder but more interesting.
Increasing bumper size and giving it a different shape could help make it easier to actually hit the balls.

3) Adding some sort of theme to the game and/or adding another game mechanic, for instance the chaos balls injure the player, or the player also needs to put the chaos balls into their own
goal would make the game more interesting and give it a wow factor.

4) It's pretty tedious trying to actually hit the ball with the bumper the way it is so the bumper itself could probably use some work, like changing it's size and shape. The fun parts are 
when you can sucessfully redirect the ball into the goal and then youre like yeah, thats right, I did that.

Sugesstions Implemented:

1) I created a goal for the chaos balls so that when all 5 chaos balls have entered the goal the light goes off and it is marked as solved. I included the chaos script in the game manger so 
that when all four colored goals and the chaos goal is solved the game is won.

2) I added some terrain to give the game a beach/island sort of feel. There's sandy hills covered in palm trees and some patchy grass areas. I changed the ground plane color to blue to make it
feel like we are in the ocean or some sort of pool.

3) I increased the player's walking speed and changed out one of the footstep sounds attached to the fps controller and replaced it with an audio of someone walking on water. I can't find a
way to make the clip stop playing after I stop walking since it keeps going, but maybe if I were to come back to this project I would either find a shorter clip or edit the aduit and cut it
short. There is also 2D island music attached to the game manager to provide a more fun and immersive experience.

4) Finally I added some obstacles in the arena to make it harder for the player to move around. I added a rigid body to them and froze their position and disabled gravity and changed them
to continuous dynamic, although the player can still sort of clip through the poles. They occasionally will slow down the ball which gives a bit of variety to the ball's speeds and could 
make it easier (or maybe harder) to get them into the right goal.

*/
