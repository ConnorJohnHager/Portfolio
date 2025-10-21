class_name ObjectToSave extends Node

enum Type { One, Two, Three }

var info: Dictionary = { ## CAN CHANGE: Add whatever values needed to be saved.
	
	"Name" : "", ## String Example
	
	"RefNumber" : 0, ## Number Example
	###  Recommended if needing a guaranteed unique value compared to Name
	
	"Type" : Type.One, ## Enum Example 
	### Enums act as numbers
	
	"IsFavorite" : false, ## Boolean Example
}

## See GridTileToSave class for example on handling more complex data like vectors.