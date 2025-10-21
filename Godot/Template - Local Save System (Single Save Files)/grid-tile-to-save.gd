class_name GridTileToSave extends Node

var info: Dictionary = { ## CAN CHANGE: Add whatever values needed to be saved.
	"Name" : "",
	"Location" : Vector2i(0,0),
	"LocationX" : 0,
	"LocationY" : 0,
}

## Store individual values for reloading vectors and other complex data.