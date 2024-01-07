# COMP3016CW2
# Project Name
To see a world in a drop water
# Project Introduction  
C++ program for rendering 3D graphics and handling user input. The software displays two 3D models - water droplets and detailed scenes. It allows the user to navigate within the model using keyboard and mouse controls. The graphical user interface is created using GLFW and OpenGL, while model loading relies on the Assimp library. Key features include lighting, texturing, and skybox rendering. The report will examine the project's user interaction, startup process, code structure, class integration, unique properties, and development insights.
# Project Summary
This project is inspired by the classic Buddhist saying "See a world in a flower,and a bodhi in a leaf". OpenGL and C++ are used to develop a Zen journey project presented from a first-person
perspective to highlight the theme. PCG will be used to interact with users. By clicking on water
droplets, users will enter a virtual Zen-like virtual environment and experience the tranquil beauty of "See a world in a flower,and a bodhi in a leaf"
# Project Aim
Achieve an engaging first-point virtual journey that allows users to interact with Zen
and nature in harmony.
# Main Features
- Immerse users in the virtual environment through the first perspective display
- By clicking on the water drop to achieve interactive triggering, guide users into the Zen scene
- Zen scenes incorporate natural elements, dynamic light and shadow, and ambient sound
- The user controls the viewing Angle through the mouse or keyboard, allowing the user to roam
freely in the scene and interact with the scene
# Technology implementation
## Coding Environment
- Uses Visual Studio 2022 as the primary integrated development environment
- Configure the project to support the OpenGL development environment
-  Develop in c++
## Dynamic scene generation
- Use OpenGL to achieve high-quality graphics rendering such as lighting, etc.
Libraries and frameworks
- Use the OpenGL library to achieve first-person perspective rendering effects
- Integrated GLEW to manage OpenGL extensions
- GLFW creates windows and handles user input
# Instruction manual
The scene can be moved by moving it with the mouse  

|      |        |      |
|:----:|:------:|:----:|
|         | W (↑) |         |  
| A (←) | S (↓) | D (→) |
|         |                |         |
| **Ascend** (Q) | **Ascend** (E) | **Descend** (E)  |  


The W, A, S, and D keys provide forward, left, right, and backward movement respectively. Q and E control vertical movement, while the arrow keys rotate the camera view. Use the mouse to adjust camera pitch and yaw. Scroll controls the zoom level.
While running, the ESC key will close the application window. Spacebar pauses background music playback. Keys 1, 2 and 3 will change the music track. Pressing F will switch to the detailed scene model, while C resets the camera position. Hold down Shift to increase movement speed. Users can use these controls to freely navigate within the model and view the rendering from different angles.
In this document, **space** represents music pause

# Modeling and texturing
- Blender

# Class and function integration
The main.cpp file relies on several key classes for model loading, shader management, and camera control.
The Model class stores mesh data and textures loaded from files using Assimp. The Draw() method configures shader parameters and issues rendering calls. Multiple model instances handle water droplets and complex scene assets individually.
The Shader class compiles vertex and fragment GLSL code into usable GPU programs. Uniforms can be set via external code before rendering. Both scene and skybox shaders are created as Shader objects.
The camera contains position and orientation vectors as well as movement speed and view matrices. The input callback modifies the camera state by calling the Camera method. The calculation formula of the view matrix is
# Software startup and control
The entry point of the program is the main() function. It initializes the GLFW window and OpenGL context for rendering. GLAD is used to load OpenGL function pointers. After initialization, the main rendering loop continues to run until the window is closed.
In main(), the createIrrKlangDevice() function from the irrKlang sound library is used to initialize audio playback. Load models from .obj files using the Model class which depends on Assimp. Texture loading utilizes stb_image. Cubemap texture configured for skybox rendering.
The processInput() function called every frame handles key presses for movement and other controls. Handle mouse movement and scrolling using GLFW registered callbacks. Timer tracks deltaTime between frames.
Rendering occurs by clearing the buffer, setting the viewpoint matrix, binding the texture, and issuing draw calls. The framebuffer resize callback handles window size changes. By encapsulating rendering and input handling, the main loop is kept clean and focused on high-level program flow.  

[YouTube]: https://youtu.be/acNh6Cdq9TU?si=Ar-eKes7n9xwUh0D)https://youtu.be/acNh6Cdq9TU?si=Ar-eKes7n9xwUh0D
