# VRdrone - ComputerGraphicsProject

Body motion based drone teleoperation using virtual reality is a method of controlling a drone using body movements while wearing a virtual reality headset. This technology allows the user to experience the drone's flight from a first-person perspective and control its movement by physically moving their body.

The basic concept involves mapping the user's body movements to corresponding drone controls. For example, leaning forward might cause the drone to move forward, while tilting to the left or right might cause it to turn in that direction. The user's body movements are captured by sensors, such as cameras or motion sensors, and translated into commands that are sent to the drone.

Virtual reality technology is used to provide the user with a realistic immersive experience. The headset displays a live video feed from the drone's camera, allowing the user to see what the drone sees and feel like they are actually flying the drone. This creates a highly intuitive and immersive interface for controlling the drone.

Body motion based drone teleoperation using virtual reality has numerous applications, including aerial photography, search and rescue, and inspection of hard-to-reach areas. It allows for more precise control of the drone and can be used in situations where traditional remote control methods are not feasible.

Overall, this technology represents a significant advancement in drone control and has the potential to revolutionize the way drones are used in a variety of industries.

********
Architecture
The project is built upon three main components:

Unity: The Unity game engine serves as the foundation for creating the VR environment and integrating the Tello drone control mechanisms.

Oculus: The Oculus VR headset delivers an immersive experience, allowing users to interact with the drone using their head movements and potentially Oculus controllers.

Tello Drone: The Tello drone is equipped with a UDP server that enables communication between the Unity environment and the drone. The connection is established via WiFi (SSID).

How it Works
Tello Drone
The Tello drone is equipped with a UDP server that allows communication between the drone and external devices. In our project, we establish a connection between the drone and the Oculus headset via WiFi.

Unity Drone Client
The core functionality of controlling the Tello drone lies within the Unity environment. We implement a multi-threaded "Drone Client" responsible for both sending commands to the drone and receiving real-time state and data from the drone. This client consists of the following components:

Main Thread: This thread handles the transmission of commands to the Tello drone. By sending appropriate commands, we can control the drone's flight, direction, and other behaviors.

Receiving Thread: The receiving thread continuously gathers state information and data from the drone. This information could include details about the drone's battery level, altitude, velocity, and more.

Drone Pilot Overlay
To enhance the user experience, we introduce a C# script that acts as a singleton called the "Drone Pilot Overlay." This script leverages the capabilities of the Oculus Quest headset to provide users with a real-world view through the drone's camera. Users can experience the drone's perspective as if they were onboard the drone itself.

Drone State Manager
The Drone State Manager is responsible for collecting and managing the state information received from the Tello drone. This information can include telemetry data, such as GPS coordinates, altitude, battery status, and more. By keeping track of the drone's state, we ensure that users have accurate and up-to-date information during their piloting experience.

Drone Controller
The heart of the project lies in the Drone Controller. This component integrates the Tello drone's original SDK with control mechanisms from either hand tracking or Oculus controllers. This integration enables users to intuitively control the drone's movements using their hands or the Oculus controllers, providing a seamless and immersive piloting experience.

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


