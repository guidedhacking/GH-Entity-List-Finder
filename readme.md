# Entity List Finder
Tool that will help you to find the entity list.

## Requirements
[.NET Framework 4.6.1 Runtime](https://dotnet.microsoft.com/download/dotnet-framework/net461) or higher.

## Support
x64 and x86 games.

Tested working on

Assault Cube, Sauerbraten x64, CSGO, Black Mesa, DOOM 2016, Bioshock Infinite

These include Source Engine, IdTech Engine & Unreal Engine

## How to use
**1.** Download the tool from [here](https://guidedhacking.com/).

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