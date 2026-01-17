# Flappy-Bird
A complete Flappy Bird built in Unity.  
This project recreates the core mechanics of Flappy Bird using Unity essentials like physics, input, spawning, collisions, UI, and game state management.

# 🛠 Built With
- Unity 2021.3 LTS
- C#
- Unity 2D Core Template
- JetBrains Rider

# 📂 Project Structure
Assets/
├── Scripts/
│   ├── BirdScript.cs
│   ├── PipeMoveScript.cs
│   ├── PipeSpawnerScript.cs
│   ├── PipeMiddleScript.cs
│   └── LogicScript.cs
├── Prefabs/
│   └── Pipe.prefab
├── Sprites/
│   ├── Bird.png
│   └── Pipe.png
└── Scenes/
    └── MainScene.unity

# 🎮 Gameplay Features
- Flappy Bird–style physics and controls
- Procedurally spawned pipes using prefabs
- Frame-rate–independent movement (Time.deltaTime)
- Score tracking via trigger collisions
- UI-based score display
- Game Over screen with restart button
- Clean object cleanup to prevent memory bloat
