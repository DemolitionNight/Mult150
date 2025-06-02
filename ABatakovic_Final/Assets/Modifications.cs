/*
 1) changed direction of directional light to make time time of day close to sunset but not quite set sunset.
 2) added some light fog with a blueish gray hue.
 3)
 4) Converted chaos ball into prefab and added a particle system component. 
 5) Changed shape to a sphere and used the stretched billboard under renderer to get a simmilar effect to our hazards in our gauntlet runner game. Decresed shape radius and radius thickness
    to .2. Decreased duration, start lifetime, and start size. Turned on size of lifetime module and make the particles go from big to small as they get older. 
 6) Used my red ball to create a colored ball prefab that was used to replaced the colored balls previosuly in the scene. I deleted the old balls and dragged in the prefab and changed the 
    children/instances to be the different colors and made sure to give them the right tags.
 7) I applied a plastic texture to each of the colored ball material.
 8) I modified the light component of each goal post and increased range from 10 to 15 and intensity from 3 to 5. I made the chaos goal light a slightly more light yellow color to help it
    stand out more from the orange light.
 9) I added a top part to my wall to make it look like a pool with the pool edge at the top. I added a ladder to give it a pool feel.
 10) I organize the ladders under the pool top and the pool top under the wall. I added a metal material to the ladder and asphault texture to the pool top.
 
 other: My balls kept getting bunched up in a corner and slowed way down at the start of the game each time I played and I tried changing up the rotations and placements of the balls but it 
        kept happened that they would get caught in one area and slowed down so the game kind of lost it'chaos element. tried getting rid of the rigid body on my obstacles to try and see what
        difference it would make, but same thing kept happpening. I tried getting rid of the obstacles entirely but same thing happened where the balls would just hit a wall in a group and
        get slowed down and lose their chaos (I made sure to turn the obstacle into a prefab so I can put it back in my scene if I want to). Then I added a bouncy physics material with no
        friction to the walls and the balls and it helped bring the chaos back into the game!
 
 
 
 */
