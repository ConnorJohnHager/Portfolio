## State Machine Template

#### Based on the "Programming a BETTER state machine" tutorial by iHeartGameDev | [YouTube](https://www.youtube.com/watch?v=qsIiFsddGV4 "Better State Machines")

#### For an introduction to state machines, check out "State Machines Explained" by iHeartGameDev | [YouTube](https://www.youtube.com/watch?v=Vt8aZDPzRjI "State Machines Explained")
--- 

**State Machine**: The base structure that handles transitions between states. This script should be inherited by the main object. No edits necessary.

**Base State**: The base state structure to process different actions during a given state, to be inherited by each state of the main object. No edits necessary. 

**Main Object**: The object that uses the state machine to determine its behavior during and between states. (Template example: NPC1 script)

**Main Object States**: The indivdual States that define how the main object behaves in different situations with each script inheriting from BaseState (Template examples: NPC1State_First, NPC1State_Second, and NPC1State_Third scripts)

**Example #1**: The Player using a state machine to swap between Idle, Walking, Jumping, and Attacking states.

**Example #2**: An NPC enemy patrolling in one state, chasing the Player in another, and returning to its patrol when the Player is out of range.

#### Notes regarding in-code comments:
* Any comment using "**Add**" refers to code needing to be completed in Visual Studio Code or similar coding software.

#### Other notes:
* In this template, the BaseState and StateMachine classes are written to be used with inheritance. 
* A single project can contain multiple State Machines for different objects (Template examples: NPC1 and NPC2 folders).
* This setup encourages modularity: new states can be added without editing the StateMachine and BaseState scripts.
---
#### Template developed by Connor Hager | Last updated on January 5, 2025