GH Entity List Finder
=====================

Welcome to the GH Entity List Finder repository. This tool is designed to help you find the entity list in various games, making it a valuable asset for game reverse engineers and hackers. It's a powerful tool that can be used to dissect and understand the underlying structure of a game's memory, and it's particularly useful when you're trying to understand how games manage their entities.

![image](https://github.com/guided-hacking/GH-Entity-List-Finder/assets/15186628/5db6ace4-6b03-4a16-9286-7408eebe77ab)

Features
--------

-   Support for Multiple Games and Engines: This tool has been tested and confirmed to work on games like Assault Cube, Sauerbraten x64, CSGO, Black Mesa, DOOM 2016, and Bioshock Infinite. It supports a variety of game engines, including Source Engine, IdTech Engine, and Unreal Engine.

-   Flexible Search Parameters: The tool allows you to adjust the "Max bytes between addresses" option, which lets you control the distance between each entity that you're trying to find. This flexibility allows you to fine-tune your search and get the most accurate results.

-   Validation Feature: After the initial search, you can modify your settings and press the "Validate" button to filter out any bad results. This feature helps you narrow down your search and find the most likely entity list addresses.

-   User-Friendly Interface: The tool comes with a simple and intuitive interface, making it easy for you to input your parameters and view the results.

Requirements
------------

To use this tool, you'll need the [.NET Framework 4.6.1 Runtime](https://dotnet.microsoft.com/download/dotnet-framework/net461) or higher. The tool supports both x64 and x86 games.

Usage
-----

The usage of this tool is straightforward. You start by downloading the tool from the official location [here](https://guidedhacking.com/resources/gh-entity-list-finder.36/). After opening the tool, you select your game process and input your search parameters. The tool then performs a search and displays the possible entity list addresses on the right panel. You can then modify your settings and press the "Validate" button to filter out any bad results.

Code Structure
--------------

The codebase is organized into several key files:

-   `EntityListFinder.cs`: This is the main file where the logic for finding the entity list is implemented.

-   `MainForm.cs`: This file contains the code for the main form of the application, where you input your parameters and view the results.

-   `AboutPopup.cs`: This file contains the code for the About popup window.

-   `ControlState.cs` and `NativeMethods.cs`: These files contain utility methods used by the application.

-   `Squalr` directory: This directory contains DLL files for the Squalr memory editing library, which the tool uses to read and write memory.

These include Source Engine, IdTech Engine & Unreal Engine

## How to use
**1.** Download the tool from the official location [here](https://guidedhacking.com/resources/gh-entity-list-finder.36/).

**2.** Open the tool and select your game process.

  ![Step1](https://i.imgur.com/WyxOq39.png)


**3.** The "**Max bytes between addresses**" option allows you to reduce or increase the distance between every entity that you are trying
to find. **This number is in HEX**.

  **Tip:** Start with a lower number, or start with a bigger one and decrease it later when validating.

  If you are unsure, just leave the default.
  
  A bigger number will give you more results but mostly useless.
  
  A lower number will give you less results but accurate.
  
  ![Step2](https://i.imgur.com/hB8wx6j.png)
  
  
**4.** Put the player/enemy/object base address to find, one per line. **This number is in HEX**.

  **Tip:** Put at least three addresses, but more addresses, better results!

  ![Step3](https://i.imgur.com/UELDFeg.png)
  
  
**5.** Press the magic button and wait.
  
  ![Step4](https://i.imgur.com/VsJ8Qa4.png)
  
  
**6.** After a few seconds you will see the results on the right panel, those addresses are possible entity list addresses or
close enough to one of them, why? Because you don't know if you put on the search box the first object on the entity list,
so maybe the possible entity list is an address close enough to that.
  
  ![Step5](https://i.imgur.com/hp1wNFu.png)
  
  
**7.** Now you can modify your settings on the left panel and press the **Validate** button to search only on the results that
the tool gives you and filter bad results.
  
  ![Step6](https://i.imgur.com/s50Qisi.png)
  
  
**8.**  You can see, in this case, we filtered one result by reducing the "**Max bytes between addresses**" option.
This doesn't always mean that the address was bad, but if still there is results left, usually means that the result removed was bad.
  
  ![Step7](https://i.imgur.com/P6rrsFT.png)
  
  
**9.** As a reference, you can see that the correct entity list was the first one. Take into account that the real entity list starts
4 bytes less before the one we found (in AssaultCube), but that is something that the tool doesn't know, is up to you to work from here.

  ![Step7](https://i.imgur.com/BSmrN9c.png)

  
FAQ
---

Q: What is an entity list?

A: In game development, an entity list is a data structure that holds all the entities in a game. Entities can be anything from players, enemies, items, to interactive objects. By finding the entity list, you can manipulate these entities to change the game's behavior.

Q: What is the "Max bytes between addresses" option?

A: This option allows you to control the distance between each entity that you're trying to find. A bigger number will give you more results but mostly useless, while a lower number will give you less results but more accurate.

Q: What is the "Validate" button for?

A: The "Validate" button allows you to filter out any bad results after the initial search. This helps you narrow down your search and find the most likely entity list addresses.

Q: What is the Squalr library?

A: Squalr is a memory editing library that allows you to read and write memory. This tool uses the Squalr library to perform its memory operations.

## Contributors
95% KISKE, 5% Boboo99 & Rake

EntityList Articles
-------------------

-   [EntityList Address Tutorial](https://guidedhacking.com/threads/how-to-find-the-entitylist-address-tutorial.10235/)
-   [Call of Duty WW2 Entity](https://guidedhacking.com/threads/call-of-duty-ww2-entity-list.20337/)
-   [Wolfenstein Hack Tutorial](https://guidedhacking.com/threads/how-to-find-entity-list-wolfenstein-hack-tutorial.14280/)
-   [CSGO Entity List Finding](https://guidedhacking.com/threads/reverse-engineering-how-to-find-the-csgo-entity-list.13313/)
-   [Loop Through EntityList Example](https://guidedhacking.com/threads/loop-through-entitylist-internally-with-reclass-poc-example.10953/)
-   [Loop Through Entity List Internally](https://guidedhacking.com/threads/how-to-loop-through-entity-list-internally.9892/)
