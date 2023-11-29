# LittleBit's Battle Simulator
A statistics-based random battle simulator.

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
**Currently, this program is only verified to run on MacOS and Linux due to how it parses file paths (using forwardslashes instead of backslashes).**

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
Asta damaged Natasha by 375 HP.
Asta has 939 HP left. Natasha has 569 HP left.

LittleBit damaged Welt by 415 HP.
LittleBit has 1254 HP left. Welt has 517 HP left.

Welt damaged Natasha by 259 HP.
Welt has 517 HP left. Natasha has 310 HP left.

Natasha damaged Serval by 262 HP.
Natasha has 310 HP left. Serval has 666 HP left.

Dan Heng damaged March 7th by 171 HP.
Dan Heng has 939 HP left. March 7th has 784 HP left.

Asta damaged March 7th by 354 HP.
Asta has 939 HP left. March 7th has 430 HP left.

Qingque damaged Dan Heng by 327 HP.
Qingque has 939 HP left. Dan Heng has 612 HP left.

March 7th damaged LittleBit by 45 HP.
March 7th has 430 HP left. LittleBit has 1209 HP left.

Dan Heng damaged March 7th by 330 HP.
Dan Heng has 612 HP left. March 7th has 100 HP left.

Asta damaged Welt by 57 HP.
Asta has 939 HP left. Welt has 460 HP left.

March 7th damaged LittleBit by 80 HP.
March 7th has 100 HP left. LittleBit has 1129 HP left.

Qingque damaged Dan Heng by 95 HP.
Qingque has 939 HP left. Dan Heng has 517 HP left.

LittleBit eliminated Dan Heng!
LittleBit has 1129 HP left.

LittleBit damaged Welt by 142 HP.
LittleBit has 1129 HP left. Welt has 318 HP left.

Natasha healed themself by 41 HP. They now have 351 HP.

LittleBit eliminated March 7th!
LittleBit has 1129 HP left.

Welt damaged Natasha by 165 HP.
Welt has 318 HP left. Natasha has 186 HP left.

Asta damaged Natasha by 117 HP.
Asta has 939 HP left. Natasha has 69 HP left.

Natasha damaged Welt by 43 HP.
Natasha has 69 HP left. Welt has 275 HP left.

Welt damaged Qingque by 278 HP.
Welt has 275 HP left. Qingque has 661 HP left.

Natasha damaged Asta by 82 HP.
Natasha has 69 HP left. Asta has 857 HP left.

Natasha eliminated Welt!
Natasha has 69 HP left.

Asta damaged Qingque by 50 HP.
Asta has 857 HP left. Qingque has 611 HP left.

Serval damaged Qingque by 235 HP.
Serval has 666 HP left. Qingque has 376 HP left.  // LittleBit: why is the devil's number here

Serval eliminated Natasha!
Serval has 666 HP left.

LittleBit damaged Asta by 135 HP.
LittleBit has 1129 HP left. Asta has 722 HP left.

LittleBit damaged Serval by 618 HP.
LittleBit has 1129 HP left. Serval has 48 HP left.

Serval damaged LittleBit by 505 HP.
Serval has 48 HP left. LittleBit has 624 HP left.

Asta eliminated Qingque!
Asta has 722 HP left.

Asta eliminated Serval!
Asta has 722 HP left.

LittleBit damaged Asta by 166 HP.
LittleBit has 624 HP left. Asta has 556 HP left.

Asta damaged LittleBit by 218 HP.
Asta has 556 HP left. LittleBit has 406 HP left.

LittleBit damaged Asta by 311 HP.
LittleBit has 406 HP left. Asta has 245 HP left.

Asta damaged LittleBit by 197 HP.
Asta has 245 HP left. LittleBit has 209 HP left.

Asta eliminated LittleBit!
Asta has 245 HP left.
Asta won!
```
The battle will play out, with characters being eliminated one by one until only one stands. The last one standing is the winner!

# Credits
## This README
**Honkai: Star Rail** is a game created by miHoYo/HoYoverse/Cognosphere. All characters from that game mentioned in this README are properties of miHoYo/HoYoverse/Cognosphere.

## Entire Project
This project uses a NuGet library called **YamlDotNet** for reading and writing YAML files, licensed under the **MIT License**. You can find this package on https://nuget.com/packages/YamlDotNet or in the repo [aaubry/YamlDotNet](https://github.com/aaubry/YamlDotNet).
