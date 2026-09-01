# Unity Proficiency Test

## Objective

Recreate a simple Space Invaders clone in the Unity Editor to demonstrate Unity workflow knowledge and code quality.

The game may remain simple. A small number of enemies is sufficient, and menus or start and end screens are not required.

## Requirements

- Use 3D assets for game objects such as ships and enemies.
- Use at least one particle system, either legacy particles or VFX Graph.
- Include user interface elements, with the player score shown at minimum using UGUI.
- Include simple music and sound effects.
- Creative transformations of the game presentation are encouraged but optional.
- Write the game code in C#.
- Do not use visual scripting, except for shader code or Shader Graph.
- Use Unity 6.3 LTS with the Universal Render Pipeline.
- Third-party assets for models, graphics, audio, and effects are permitted.
- The core code driving the game must be entirely original.

## Requirements Checklist

- [x] Use 3D assets for game objects such as ships and enemies. Assets are under `Assets/Enemies/` and `Assets/Player/`.
- [x] Use at least one particle system, either legacy particles or VFX Graph. Particle system used for player engine/flame effects.
- [ ] Include user interface elements, with the player score shown at minimum using UGUI.
- [x] Include simple music and sound effects. Audio assets are under `Assets/Audio`.
- [x] Add a creative transformation of the game presentation with skybox system.
- [x] Write the game code in C# under `Assets/Scripts`.
- [x] Verify that no visual scripting is used, except for shader code or Shader Graph. No visual scripting employed.
- [x] Use Unity 6.3 LTS with the Universal Render Pipeline. The project uses Unity `6000.3.22f1` and URP.
- [x] Confirm that third-party assets used are limited to models, graphics, audio, and effects.
- [x] Verify that the core code driving the game is entirely original.

The unchecked items require verification or implementation before submission.

## Recent Changes (v0.2.0)

### Commits (Latest 8)
All changes organized by category with detailed commit messages:

1. **refactor:** Remove legacy player control scripts
2. **chore:** Remove deprecated MilkyWay skybox and old prefab structure
3. **feat(enemy):** Add enemy movement and spawner systems
4. **feat(assets):** Reorganize game assets into modular structure
5. **fix(bullet):** Add default bulletSpeed value
6. **chore:** Update project settings and dependencies
7. **refactor(scene):** Update SampleScene for new game systems
8. **chore:** Add Unity metadata for new asset folders

**Statistics:**
- 78 files changed
- 493 insertions (+)
- 3,823 deletions (-)
- Clean modular architecture established

## Setup Instructions

### Configuring the Enemy Spawner
1. In the Unity Scene, select the Enemy Spawner GameObject
2. In the Inspector, assign an enemy prefab to the `Enemy Prefab` field:
   - Available prefabs: `Assets/Enemies/Prefabs/[Type][Color].prefab`
   - Types: AlienFighter, AlienDestroyer, BioTorpedo
   - Colors: (standard), Green, White
3. Configure spawning parameters:
   - **Spawn Interval:** Time between spawns (default: 2.5s)
   - **Enemy Pool Size:** Number of enemies to pool (default: 10)
   - **Min X / Max X:** Spawn bounds on X-axis (default: -6 to +6)
4. Set the Spawn Point transform for spawn location

### Scene Setup
- Main scene: `Assets/Scenes/SampleScene.unity`
- Includes pre-configured spawner with animation controller
- All new asset references integrated and ready

## Development Notes

- All scripts follow C# coding standards
- Prefab system uses object pooling for performance
- Modular structure allows easy addition of new enemy types
- Animation system integrated with Alien_Ship.controller
- Skybox system provides visual variety


Double-check every requirement before submitting. Failure to follow any requirement may result in immediate disqualification.

Submit the project files using one of these methods:

- A compressed ZIP, RAR, or 7z file sent by email.
- A GitHub repository.

Only include these folders in the submitted project:

- `Assets`
- `Packages`
- `ProjectSettings`

## Contact

For submission and questions:

dylan@octogames.com
