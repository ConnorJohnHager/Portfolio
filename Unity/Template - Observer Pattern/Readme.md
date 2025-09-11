## Observer Pattern Template
#### Based on the "Observer Pattern Explained" tutorial by iHeartGameDev | [YouTube](https://www.youtube.com/watch?v=NY_fzd8g5MU "Observer Pattern")
--- 
**Observed**: The object performing actions that may impact other objects or systems.

**Observer**: The object that may need to update or respond after the Observed performs an action. 

**Example #1**: The Health UI (Observer)  must update when the Player (Obnserved) takes damage.

**Example #2**: The Spawn Manager (Observed) keeps track of how many NPCs (Observers) are currently spawned.
* This may seem like the Spawn Manager is the actual observer in the relationship, but the NPC would actually start observing the Spawn Manager in came from and the NPC could be removed as an observer when it is destroyed. The Spawn Manager can then keep track of how many NPCs there are in its area and spawn a new NPC when room is available.

#### Notes regarding in-code comments:
* Any comment using "**Add**" refers to code needing to be completed in Visual Studio Code or similar coding software.
* Any comment using "**Assign**" refers to a task to be completed in the Unity Editor.

#### Other notes:
* Objects do not have to be added as an Observer in Start(). They can be be added and removed whenever it makes the most sense.
* In this template, the Observer class is written to be used with inheritance. This process could also be completed using an interface instead (see tutorial above).
---
#### Template developed by Connor Hager | Last updated on January 5, 2025