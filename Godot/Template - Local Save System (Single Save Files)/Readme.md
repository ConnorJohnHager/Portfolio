## Local Save System Template for Single Save Files
#### Programmed in collaboration with Amith Bhaskara
--- 
**GameManager**: *Optional* - The global autoload script that can help determine when to trigger save, load, and reset operations.

**PlayerData**: The global autoload script that manages all game data structures and handles getting/setting save data.

**SavingManager**: The global autoload script that handles file input/output operations, converting data to/from JSON format.

**ObjectToSave**: A class for storing data about individual game objects that need to persist between sessions.

**GridTileToSave**: A class for storing data about individual grid tiles in grid-based mechanics that need to persist between sessions.

#### Notes regarding in-code comments:
* Any comment using "**CAN CHANGE**" should specify what parts of the code can be adjusted in that line to meet different needs.
* Any comment using "**Make Global**" refers to going to Project Settings and adding the script under the Globals tab.

#### Other notes:
* Save file location is `user://save.json` by default, which maps to a platform-specific user data directory, but feel free to adjust the save location as needed.
* The grid tile system (`GridTileToSave` and related functionality in `PlayerData`) is designed for games with grid-based mechanics that need persistent saving between play sessions, such as farm simulators, tower defense games, or city builders.
* The grid system automatically initializes based on the `gridX` and `gridY` values set in `PlayerData` (default is 10x10).
* **JSON Data Type Limitations**: JSON can only save the following data types:
	* Strings
	* Numbers
	* JSON objects (dictionaries)
	* Arrays
	* Booleans
	* Null values
	
	Complex data types like Vector2i, Vector3, Color, etc. must be broken down into their component values (as demonstrated in `GridTileToSave` where Location is stored as separate LocationX and LocationY values).
---
#### Template developed by Connor Hager | Last updated on October 29, 2025