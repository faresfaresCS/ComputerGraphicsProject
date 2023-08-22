# VRdrone - ComputerGraphicsProject

Body motion based drone teleoperation using virtual reality is a method of controlling a drone using body movements while wearing a virtual reality headset. This technology allows the user to experience the drone's flight from a first-person perspective and control its movement by physically moving their body.

The basic concept involves mapping the user's body movements to corresponding drone controls. For example, leaning forward might cause the drone to move forward, while tilting to the left or right might cause it to turn in that direction. The user's body movements are captured by sensors, such as cameras or motion sensors, and translated into commands that are sent to the drone.

Virtual reality technology is used to provide the user with a realistic immersive experience. The headset displays a live video feed from the drone's camera, allowing the user to see what the drone sees and feel like they are actually flying the drone. This creates a highly intuitive and immersive interface for controlling the drone.

Body motion based drone teleoperation using virtual reality has numerous applications, including aerial photography, search and rescue, and inspection of hard-to-reach areas. It allows for more precise control of the drone and can be used in situations where traditional remote control methods are not feasible.

Overall, this technology represents a significant advancement in drone control and has the potential to revolutionize the way drones are used in a variety of industries.

## Architecture

The project consists of three main components:

1. Unity
2. Oculus
3. Tello Drone

## How it Works

### Tello Drone

The Tello drone is equipped with a UDP server that allows communication with external devices via WiFi (SSID).

### Unity Drone Client

The Unity Drone Client has two main threads:

- Main Thread: Sends commands to the drone for control.
- Receiving Thread: Receives real-time state and data from the drone.

### Drone Pilot Overlay

A C# script, acting as a singleton, provides a real-world view through the Oculus Quest headset, enhancing the piloting experience.

### Drone State Manager

This component manages state information received from the Tello drone, providing accurate telemetry data to users.

### Drone Controller

Integrates the Tello drone's original SDK with hand tracking or Oculus controller input for intuitive drone control.


code can be found at: 
Scripts/DroneEnums.cs
Scripts/DroneClient.cs
********
The primary goal of the project would be to create a system that allows a user to control a drone using a virtual reality headset. Here are some of the essential steps involved in such a project:

Hardware selection: The first step in any project involving drones is to select the hardware. For this project, you'll need a drone with a camera and a virtual reality headset.

Software development: Next, you'll need to develop software that will allow the VR headset to interface with the drone. This will require programming skills, as well as knowledge of VR and drone control protocols.

User interface design: Once you have the basic software in place, you'll need to design a user interface that will allow the user to control the drone. This will involve creating a set of intuitive controls that the user can manipulate using the VR headset.

Testing: After you have a working prototype, you'll need to test the system to ensure that it works as intended. This will involve a combination of hardware and software testing, as well as user testing to ensure that the interface is easy to use and effective.

Refinement and optimization: Finally, once you have a working prototype, you can refine and optimize the system to make it more efficient, effective, and user-friendly. This may involve tweaking the software, modifying the hardware, or changing the user interface based on feedback from users.

Overall, a VR headset drone interface project could be an exciting and rewarding project for someone interested in drone technology, virtual reality, and software development.

# LOG
16 May: Deploy app on headseat for first time. Had some errors.

Installing different Unity version 2020.3.16

Try running windows 11 on VM 

23 May: SICK + STRIKE

30 May: moving to windows - asking Roi for permissions


