# LittleBit's Battle Simulator
A statistics-based random battle simulator.
[![forthebadge](https://forthebadge.com/images/badges/made-with-c-sharp.svg)](https://forthebadge.com) [![forthebadge](https://forthebadge.com/images/badges/open-source.svg)](https://forthebadge.com) [![forthebadge](https://forthebadge.com/images/badges/license-mit.svg)](https://forthebadge.com) ![Static Badge](https://img.shields.io/badge/USES-YAML-blue?style=flat)


# Definition of Characters
The roster of a battle is defined by a YAML file containing a list of characters.

Here's an example, being my Trailblazer from [Honkai: Star Rail](https://hsr.hoyoverse.com)
```yaml
- name: LittleBit # character's name
  maxHealth: 1254 # maximum allowed health, important for healers
  health: 1254 # current health
  minDamage: 0 # minimum damage output
  maxDamage: 759 # maximum damage output
  healer: false # if true, allow this character to randomly heal themself
  minHealing: 0 # minimum healing ability
  maxHealing: 0 # maximum healing ability
```

The variables allow for much flexibility in character definition, such as giving a character more maximum health than current health, allowing healers to overheal a bit.

# Running the Program

When the program is run, it asks if you have an existing character list YAML file or if it should generate a template for you.
```plaintext
LittleBit's Battle Simulator
Do you have an (e)xisting character list, or do you need a (n)ew one?
```
If you tell it you need a new character list, the program generates an example file at a specified path and instructs you with what to do.
```plaintext
Enter the file path where for the new character list YAML file: /home/jaherron/Documents/examplechars.yaml
Character list YAML file created. The program will exit.
Edit the file, adding and removing characters as desired, with the stats you want.
To start the battle, rerun the program and say you have an existing character list.
```
This is the example file the software generates:
```yaml
- name: Example1
  maxHealth: 0
  health: 0
  minDamage: 0
  maxDamage: 0
  healer: false
  minHealing: 0
  maxHealing: 0
- name: Example2
  maxHealth: 0
  health: 0
  minDamage: 0
  maxDamage: 0
  healer: false
  minHealing: 0
  maxHealing: 0
```
Simply copy the lines starting with "name" and ending with "maxHealing", and edit the names and stats with what you want. You don't have to copy video game characters like what I did.

After forming your roster, run the program again, this time saying you have an existing character list. Enter the path you initially gave the software.
```plaintext
LittleBit's Battle Simulator
Do you have an (e)xisting character list, or do you need a (n)ew one?e 

Enter the path to the character list YAML file: /home/jaherron/Documents/BattleSim/characters.yaml
```
Now, the battle takes place. Here's an example, again using characters from Star Rail.
```plaintext
The fight starts with 8 players!

March 7th damaged LittleBit by 149 HP.
March 7th has 955 HP left. LittleBit has 1105 HP left.

Welt damaged Dan Heng by 115 HP.
Welt has 932 HP left. Dan Heng has 824 HP left.

Natasha damaged Dan Heng by 118 HP.
Natasha has 944 HP left. Dan Heng has 706 HP left.

Qingque damaged Natasha by 407 HP.
Qingque has 939 HP left. Natasha has 537 HP left.

Asta damaged Qingque by 355 HP.
Asta has 939 HP left. Qingque has 584 HP left.

Natasha damaged Serval by 333 HP.
Natasha has 537 HP left. Serval has 595 HP left.

Welt damaged LittleBit by 383 HP.
Welt has 932 HP left. LittleBit has 722 HP left.

Natasha damaged March 7th by 112 HP.
Natasha has 537 HP left. March 7th has 843 HP left.

LittleBit damaged Welt by 238 HP.
LittleBit has 722 HP left. Welt has 694 HP left.

Dan Heng damaged Welt by 60 HP.
Dan Heng has 706 HP left. Welt has 634 HP left.

Serval damaged Welt by 106 HP.
Serval has 595 HP left. Welt has 528 HP left.

Asta damaged Welt by 85 HP.
Asta has 939 HP left. Welt has 443 HP left.

Qingque eliminated Natasha!
Qingque has 584 HP left.
Remaining players: LittleBit, March 7th, Serval, Welt, Dan Heng, Qingque, Asta

Qingque damaged Asta by 232 HP.
Qingque has 584 HP left. Asta has 707 HP left.

Serval damaged March 7th by 121 HP.
Serval has 595 HP left. March 7th has 722 HP left.

March 7th damaged Welt by 43 HP.
March 7th has 722 HP left. Welt has 400 HP left.

March 7th damaged Dan Heng by 181 HP.
March 7th has 722 HP left. Dan Heng has 525 HP left.

Qingque damaged Asta by 325 HP.
Qingque has 584 HP left. Asta has 382 HP left.

LittleBit damaged Asta by 190 HP.
LittleBit has 722 HP left. Asta has 192 HP left.

Asta damaged Qingque by 184 HP.
Asta has 192 HP left. Qingque has 400 HP left.

LittleBit eliminated Welt!
LittleBit has 722 HP left.
Remaining players: LittleBit, March 7th, Serval, Dan Heng, Qingque, Asta

Dan Heng damaged Serval by 243 HP.
Dan Heng has 525 HP left. Serval has 352 HP left.

Asta damaged Qingque by 337 HP.
Asta has 192 HP left. Qingque has 63 HP left.

Asta damaged March 7th by 371 HP.
Asta has 192 HP left. March 7th has 351 HP left.

Dan Heng eliminated Asta!
Dan Heng has 525 HP left.
Remaining players: LittleBit, March 7th, Serval, Dan Heng, Qingque

March 7th damaged Serval by 99 HP.
March 7th has 351 HP left. Serval has 253 HP left.

LittleBit eliminated March 7th!
LittleBit has 722 HP left.
Remaining players: LittleBit, Serval, Dan Heng, Qingque

Qingque eliminated Serval!
Qingque has 63 HP left.
Remaining players: LittleBit, Dan Heng, Qingque

Dan Heng eliminated Qingque!
Dan Heng has 525 HP left.
Remaining players: LittleBit, Dan Heng

Dan Heng damaged LittleBit by 238 HP.
Dan Heng has 525 HP left. LittleBit has 484 HP left.

LittleBit damaged Dan Heng by 405 HP.
LittleBit has 484 HP left. Dan Heng has 120 HP left.

Dan Heng damaged LittleBit by 142 HP.
Dan Heng has 120 HP left. LittleBit has 342 HP left.

LittleBit eliminated Dan Heng!
LittleBit has 342 HP left.
Remaining players: LittleBit
LittleBit won!
```
The battle will play out, with characters being eliminated one by one until only one stands. The last one standing is the winner!

# Looped Version
The `BattleSimulatorLooped` folder contains a version of the software that runs in a continuous loop until you stop it with `Ctrl+C`.

The looped version is designed to reload the character list YAML file you give it every time it loops, meaning that you can edit the file and the new roster takes effect on the next loop. The looped version **does not** have the ability to generate the example characters file, so either use the normal version first or copy the example from the ["Running the Program"](#running-the-program) section of the `README` here.

# GUI Characters Manager
The `BattleSimCharacterManager` folder is a GUI character manager that I have yet to finish.

# Credits
## This README
**Honkai: Star Rail** is a game created by miHoYo/HoYoverse/Cognosphere. That game and all characters from that game mentioned in this README are properties of miHoYo/HoYoverse/Cognosphere.

## Entire Project
This project uses a NuGet library called **YamlDotNet** for reading and writing YAML files, licensed under the **MIT License**. You can find this package on https://nuget.com/packages/YamlDotNet or in the repo [aaubry/YamlDotNet](https://github.com/aaubry/YamlDotNet).
