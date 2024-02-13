![Cult of the Lamb banner art](https://cdn2.steamgriddb.com/grid/f3747b8108c7c49cacd81747b7069e7e.png)
## 1. Introduction

This game design document specifies the gameplay and structure of the upcoming indie rogue-lite game “PROJECT R”. Current name is a reference placeholder until an actionable market plan has been achieved. The development and design of the project is done by @Okan Ozbek.

### 1.1 Scope

The document is intended to be read and reviewed by peers such as, programmers, artists, producers involved in the “PROJECT R” development pipeline.

### 1.2 Type conventions

- Confirmed and agreed upon ideas in the document will be written in the current font. These are deemed as in-scope for the project.
- Ideas are highlighted with a yellow colour to signify the difference.
- ~~Deprecated or removed ideas are written with a strikethrough.~~

### 1.3 Context

- A **run** refers to a play-through of the game. Rogue-lites capitalize on the fact that you have to do the same content a few times over before you can beat the game.
- **Upgrading** refers to bettering anything about the player in an impactful way.
- A **rogue-lite** game is a game that takes heavy inspiration from the rogue-like genre without adhering to all the rules of a traditional rogue-like.
- A **rogue-like** game is a turn based RPG dungeon crawler with procedurally generated levels and grid-based movement where player death is permanent.

---

## 5. Specification

### 5.1. Concept

The aim of “PROJECT R” is to produce a fast paced, low-key story driven rogue-lite game. The goal is to defeat the end boss. Due to the nature of rogue-lites replay-ability is a must. Since the main mechanics involve gameplay. 

### 5.2. Story

The player has been stranded in a dystopian futuristic city, where a major civil war has taken over. The military currently has full leadership over the city. Rebellions have been formed to fight back against the oppression. One of the camps takes the player in. Take care of them and mend their wounds.

They do this because they know who the player is. One of the most infamous mercenaries in the Nova region. By doing this they have now indebted them. The player complies and helps them on their mission to break free from the militia’s shackles.

<div align="center">
  <img width="100%" src="https://github.com/okan-ozbek/project-r/assets/127297261/21ac2397-6fd1-4e5a-a3d9-d3367f861451">
</div>

The story questions which side is right and which one is truly evil. By progressing through the game the player finds out whether they were on the right side of the story.

As the story progresses the player will understand that the metaphor for the game is closely tied with how big corporations use micro-transactions to release broken and empty games.

### 5.3 Game structure

There are two stages in the game, each having vastly different objectives that the others.

- **The encampment:** Here the player is able to upgrade their gear and abilities. This could make progression easier and makes the death feel less impactful then a traditional rogue-like.
- **The tower:** This is the main objective of the game. Here the player progresses through the various different skyscrapers in the game to reach to the top. To in the end defeat the military commander.

Due to the nature of rogue-like and rogue-lite games you will die a lot. Making you familiar with the level structure after a few runs. 

The levels are randomly generated with loot boxes spread across the map. Monsters have a chance to drop keys and these are used to unlock said loot boxes.

For the sake of irony the loot boxes will have a similar opening style as in CS:GO, Apex Legends, or Overwatch.

<div align="center">
  <img src="https://github.com/okan-ozbek/project-r/assets/127297261/a3b7b83f-dc32-445f-a2ff-1fea8c75b75a">
</div>

For the sake of irony the loot boxes will have a similar opening style as in CS:GO, Apex Legends, or Overwatch.

Some items have pros and cons, so beware.

### 5.4 Networking

At the prototyping phase there won’t be any co-op/multi-player capabilities, however it is something that definitely will be required before release. This is heavily inspired by Risk of Rain 2.

### 5.5 Gameplay

The player goes through the tower, where he will find loot on each floor. Enemies will be surrounded but can be skipped (they do follow the player). The player can continue to the next level once he defeats the levels boss. These fights increase in difficulty the longer the session is in progress.

The player has two unique character bound abilities that they can use. These are impactful but create a balance due to the character also having a negative effect to balance it out.

The goal is to advance to the last level and defeat the final boss.

### 5.6 Graphics

The game is a 2.5D top down rogue-lite game with RPG elements. The entities in the game will be 2D in a pixel art style. The environment will utilize a mixture of 3D and 2D. The 3D objects will be inspired from the PSX art style. 

Lighting and shaders will be using modern technologies to achieve realistic shaders and shadows. The game needs to feel dystopian and almost dreamy. This is done in the post-processing by altering the camera rendering to add a bit more bloom, and tinkering with the other settings when deemed fit.

![insp1](https://github.com/okan-ozbek/project-r/assets/127297261/b4f01c88-7c67-4062-bb74-087c584fd45f)
![insp2](https://github.com/okan-ozbek/project-r/assets/127297261/d7194fc9-43ac-413b-8174-06bdc837b69f)
![insp3](https://github.com/okan-ozbek/project-r/assets/127297261/151a7be3-239c-4717-85cd-30a8d08d5301)
![insp4](https://github.com/okan-ozbek/project-r/assets/127297261/2e4510f5-915a-4387-bd8a-1158bc0ee622)


2. Gameplay

This section is dedicated to everything the player will come across when playing “PROJECT R” the section will also go further in-depth with game mechanics that might have been previously described.

### 2.1 World and environment

As described in section **5. Specification** the world is set in a dystopian cyberpunk city-scape in the midst of a civil war. There are encampments and rebellious groups everywhere. The military is filling the streets and even have bio-mechanical monsters that fight for them.

The setting has a heavy focus on an oppressive force trying to take control. An overwhelming feeling due to scale should be felt when tackling this entity.

### 2.2 Progression

The goal of the game is to beat the final boss. To get there the player has to find its way through the labyrinth of levels. 

As the run progresses the player will level up by killing monsters, opening chests and defeating bosses. These levels will scale the players’ stats.

The game also has an internal difficulty scaler. This is based on time and continuously scales the monsters so that the player maintains a difficult run to a certain degree. This has a cap that has to be defined with play testing.

During the run the player has a chance to find a special item that persists through death. These can be used to reroll their stats, upgrade abilities or purchase new abilities.

### 2.3 Upgrading

The upgrading system 

### 2.4 Items

The following statistics should be known before discussing potential items for the game. Below you can find a table of all the stats that can be altered by items.

| Health | 100 HP |
| --- | --- |
| Attack speed | (different per character) |
| Attack damage | (different per character) |
| Movement speed | 10 |
| Sprinting speed | 150% of movement speed |
1. **(Common) Sugar**
    
    The main property is that this item boosts your attack speed by 10%, this effect stacks until 200% has been reached
    
    *Mom always told me not to eat to much of it.*
    
2. **(Common) Dopamine**
    
    A close range buff, al enemies in a 10-15 yard radius take 5% increased damage, this effect stacks until 200% has been reached.
    
    *It just feels so good!*
    
3. **(Common) Game console**
    
    A 5% overall attack damage buff and 5% decrease in attack speed. This effect stacks until 200% has been reached. (Other multipliers can overwrite the attack speed debuff).
    
    *Losing pisses me off.*
    
4. **(Common) Beer** 
    
    10% movement speed decrease and 5% attack damage buff. This effect stacks until the player reached a movement speed of 10%.
    
    *Please don’t tell my parents. They’ll kill me.*
    
5. **(Common) Hearty breakfast** 
    
    A hearty meal to restore 20% of your health and permanently gain 10 health. 
    
    *Nothing like a hearty breakfast to start the day! Or evening..*
    
6. (Rare) Magic 8-ball
    
    Chance to instantly kill an enemy below 20% health. This effect does not work on bosses.
    
    *It said: “Try again later”…*
    
7. **(Epic) Mom’s credit card**
    
    5% chance to “buy” an enemy to fight for you. 
    
    *Don’t worry they signed a liability waiver.*
