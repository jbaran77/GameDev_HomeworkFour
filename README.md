# John Baran Game Dev HW 4

# Question 5

## World Coordinate System
Used as base reference for orientation in a scene
Origin is fixed at (0,0,0)
Can be used to manage and analyze all GameObjects position or rotation in a scene <br>

## Local Coordinate System
Coordinate system relative to GameObject's own transform
Used to change positions rotation based on their relative current rotation

## Vector3
Used to represent and edit 3D vectors in space
For example, Vector3.forward and Vector3.back are used to edit GameObjects position and rotation in Z axis
For rocket, we use them to enable the steering/ leaning

## RigidBody.AddRelativeForce
Used to add force on an object from a certain direction/ orientation
For rocket we use it to simulate upward thrust
Can be used to simulate wind

## Input.GetKey Function
Used to get user input from keyboard
Could be used for simulating a jump action from the space bar
For rocket we use it to enable keys that can steer the rocket
