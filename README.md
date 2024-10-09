# UnityJump

## Overview
UnityJump is an interactive game prototype created using Unity, where players control a character that jumps over obstacles. This project showcases essential game mechanics, including character control, obstacle spawning, and collision detection. Additionally, it features a mini-game challenge involving a balloon navigating through a town while collecting tokens and avoiding explosives.

## Features
- **Character Control**: The player can make the character jump by pressing the spacebar.
- **Obstacle Generation**: Obstacles spawn at regular intervals and move across the screen, challenging players to jump over them.
- **Game Over Logic**: The game ends when the player collides with an obstacle, providing immediate feedback on performance.
- **Mini-Game Challenge**: Players control a balloon that floats upwards while collecting tokens and avoiding bombs. The challenge incorporates physics, scrolling backgrounds, and special effects.

## Challenge Instructions
In the mini-game challenge, players must:
- Control a balloon that floats upwards as they hold the spacebar.
- Navigate through a seamlessly repeating background while avoiding randomly spawned bombs and collecting money tokens.
- Experience particle effects and sound upon collecting money and an explosion effect when colliding with bombs.

### Key Skills Reinforced
The challenge reinforces several skills and concepts:
- Declaring and initializing variables using the `GetComponent` method.
- Using booleans to manage game states.
- Displaying particle effects relative to game objects.
- Implementing a seamlessly scrolling background.

## Development Process

1. **Background and Character Setup**: A visually appealing background was selected, and a player character was configured with appropriate components like Rigidbody and Box Collider.

2. **Jump Mechanics**: The character was programmed to jump both at the start of the game and when the spacebar is pressed. This involved adjusting jump force and gravity settings to ensure a smooth gameplay experience.

3. **Obstacle Creation**: Obstacles were designed to move leftward across the screen, requiring players to time their jumps accurately.

4. **Spawn Manager Implementation**: A spawn manager was created to generate obstacles at timed intervals, enhancing the game's challenge.

5. **Collision Detection**: Game logic was established to halt gameplay upon collision with obstacles, triggering a game-over state.

6. **Mini-Game Integration**: The balloon mini-game was developed, where players collect tokens while avoiding bombs, incorporating various effects for interactions.

### Installation
1. Clone this repository:
   ```bash
   git clone https://github.com/FarnoodID/UnityJump.git
   ```
2. Open the project in Unity.
3. Ensure all necessary packages are installed.
