# IM2_Project
Frogger Project

4/17/2020 changes from previous offline version:
Use a particle system to create fog at the edges of the scene.
Addition of a halo to boats and lawnmower.
Extend the collision to the fire trail behind the lawnmower.
Get rid of the gap in the second and third roadways.
Have the player move with the moving logs.
Addition of log edge to waterway.
Re-enable the cloudy edges.

Add two directories external to project to store Art and Sound assets.
Update to car game objects with addition of horn sounds when the player gets close to the car. 
Replacement of the car game objects.

4/25/20 
Change spawn area cover:
1) start speed from 2 to 1.
2) number of particles from 1000 to 2000.
3) Double the number of particle objects from 2 on each side to 4.

4/26/20:
1) Add logs to the other side of the waterway.
2) Reduce the width of boats from 6 to 4.5.
3) Reduce the length of the wildfire behind the lawnmower from 'Start Lifetime' from 8:10 to 2:3.
4) Addition of more waterway logs and lilypads.
5) Slow down boat speeds--boatfbx from 3 to 2, boatfbx (1) from 5 to 3, boatfbx (2) from 7 to 5.
6) Add coral and seaweed (used above water on end edge) game objects to the waterway.
7) Addition of bushes to the beginning of level.

4/27/2020:
1) Addition of rubber ducky with sound effects...still need to tweak this.
2) Addressing the lag of the project build experienced in build 8 & 9.

4/28/20:
1) Addressing lag...updating to latest Unity including updating packages. Need to test this.

5/9/20:
Dev update:
Strange behaviors days--windows 10 system update left the main dev machine down for a couple of days. Was able to move the latest changes to and external drive. This was the one night I didn’t push work to the server. Strangest behavior occurred when I simply did a replacement of the files from the server--the project opened with two editor window instances. A change in one window would occur in the other window as well. So the new change was simply changing the assets directory. Better way to fix the problem. Build will be available in the morning.

5/10/20:
Dev update:
Create title scene, level ending. LockMouse script disabled on camera for Main Menu...still can look around the scene but no movement. Another WTF day: MainMenu scene was not saving; despite the file>save. Reimport the assets/packages and seem to work. Cross fingers and hope to kick... working now. 

Adding Occulus Go Build.
