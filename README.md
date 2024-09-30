# John Baran Game Dev HW 4

# Question 5

## World Coordinate System
Used as base reference for orientation in a scene <br>
Origin is fixed at (0,0,0) <br>
Can be used to manage and analyze all GameObjects position or rotation in a scene <br>

## Local Coordinate System
Coordinate system relative to GameObject's own transform <br>
Used to change positions rotation based on their relative current rotation <br>

## Vector3
Used to represent and edit 3D vectors in space <br>
For example, Vector3.forward and Vector3.back are used to edit GameObjects position and rotation in Z axis <br>
For rocket, we use them to enable the steering/ leaning <br>

## RigidBody.AddRelativeForce
Used to add force on an object from a certain direction/ orientation<br>
For rocket we use it to simulate upward thrust <br>
Can be used to simulate wind <br>

## Input.GetKey Function
Used to get user input from keyboard<br>
Could be used for simulating a jump action from the space bar<br>
For rocket we use it to enable keys that can steer the rocket<br>
