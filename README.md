# IMMUNOCALYPSE

IMMUNOCALYPSE is a Unity first-person action project built around combat, enemy encounters, and level-based progression. The codebase contains gameplay systems for player movement, weapons, enemy behaviour, boss encounters, wave logic, and multiplayer sessions using Mirror.

This repository is primarily a collection of the project's Unity scripts and gameplay code.

## What’s in the project

### Player and combat
- First-person movement and player control scripts
- Weapon behaviour for firearms such as assault rifles, pistols, and sniper weapons
- Shooting, ammunition, reloading, and grenade handling
- Weapon recoil, aiming, and scope effects
- Bullet and casing spawning, including object-pool implementations

### Enemies and encounters
- Enemy health and damage handling
- Navigation and player-chasing behaviour using Unity NavMesh
- Patrol and waypoint movement
- Boss-specific behaviour and health handling
- Wave detection, timers, and encounter progression

### Multiplayer
The project includes multiplayer scripts built with [Mirror](https://mirror-networking.com/), including network manager, lobby, room-player, player-controller, and spawn-point logic.

### Supporting systems
- Player health and collision handling
- Environment interactions such as doors and lighting effects
- Audio and gameplay UI controls
- Main-menu and scene-loading scripts

## Built with

- **Unity** — game engine
- **C#** — gameplay and system scripting
- **Mirror** — multiplayer networking
- **Unity AI Navigation / NavMesh** — enemy navigation
