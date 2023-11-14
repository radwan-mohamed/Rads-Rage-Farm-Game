# Rage-Farm-Game
First step on game development 
# Rage Farm

**Developer:** Radwan Mohamed Amin

## Overview

*Rage Farm* is a 3D game developed as a practical application of C# programming concepts. This project explores topics such as inheritance and script-based data protection. In the game, players face the challenge of protecting their land from oncoming waves of animals. The farmer combats this threat by strategically offering slices of pizza to the animals, which not only prevents them from attacking but also increases their speed with each successive wave. The game consists of multiple waves, each lasting 20 seconds, with the final wave being the fourth.

## Features

- **Player Controller (PlayerController.cs):**
  - Allows player movement within specified borders.
  - Instantiates a prefab (pizza) on each space bar press.
  - Implements constant player speed and health management.
  
- **Health Controller (HealthControll.cs):**
  - Manages player health displayed in a health bar using a slider.
  - Updates health dynamically as the player takes damage (when animals cross the farmer).

- **Timer (Timer.cs):**
  - Implements a timer system to facilitate the wave progression, enhancing gameplay.

- **Spawn Manager (SpawnManager.cs):**
  - Controls the spawning of animal prefabs at random locations every 2 seconds.
  - Manages prefab destruction if they cross a specified range for memory optimization.

- **Wave Manager (WaveManager.cs):**
  - Displays the current wave and adjusts game difficulty by increasing animal speed over time.

- **Wall Collider (WallCollider.cs):**
  - Reduces player health when an animal escapes, providing a background challenge.

- **UI Scripts:**
  - Utilizes various scripts to display score, time, wave information, and player health.

- **Game Over Object:**
  - Triggers a game over canvas with restart functionality when the player's health reaches zero.
  - Displays the points collected during the game.

## Usage

1. **PlayerController:** Handles player movement and actions.
2. **HealthControll:** Manages player health and updates the health bar.
3. **Timer:** Implements the timer for wave progression.
4. **SpawnManager:** Controls the spawning and destruction of animal prefabs.
5. **WaveManager:** Manages wave information and adjusts game difficulty.
6. **WallCollider:** Reduces player health based on animals escaping.
7. **UI Scripts:** Display relevant game information.
8. **Game Over Object:** Handles the game over scenario and displays collected points.

## Scenes

- **First Scene:** Displays the game title and a start button to access the main game scene.

*All scripts mentioned are included in the project file for reference.*
