# ModularAttack
Modular attack system for Unity using interfaces. You can make multiple attacks and swap player's attack current attack with a line of code or a single click.

This is based on Code Monkey's [Modular Character's System in Unity](https://www.youtube.com/watch?v=mJRc9kLxFSk) and Unity API.

## How to use?
1. Add files to the project.
2. Install New Input System.
3. Create new input called OnAttack to the Input Actions menu. 
4. Attach Damager.cs to a weapon / a bullet / etc.
5. Attach PlayerAttackBase.cs and AttackMeleeCommand.cs to the player character.
6. Set Weapon Hand GameObject for the AttackMeleeCommand.cs (location where attack / bullet spawns).
7. Set Attack Prefab for the AttackMeleeCommand.cs (the same GameObject where you attached Damager.cs).
