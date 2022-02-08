# ModularAttack
A modular attack system for the Unity using interfaces. You can make multiple attacks and swap player's current attack with a line of code or a single drag and drop.

This is based on Code Monkey's [Modular Character's System in Unity](https://www.youtube.com/watch?v=mJRc9kLxFSk) and Unity API.

## How to use it?
1. Install New Input System.
2. Create new Input Actions called PlayerInputActions.
3. Create new action map called Gameplay to the Input Actions menu.
4. Create new input called Attack to the Input Actions menu.
5. Generate C# Class from PlayerInputActions. 
6. Add files to the project.
7. Attach Damager.cs to a weapon / a bullet / etc. prefab.
8. Attach PlayerAttackBase.cs and AttackMeleeCommand.cs to the player character.
9. Set Weapon Hand GameObject for the AttackMeleeCommand.cs (location where an attack / a bullet spawns).
10. Set Attack Prefab for the AttackMeleeCommand.cs (the same GameObject where you attached Damager.cs).
