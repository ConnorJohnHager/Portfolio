extends Node
## Make Global: This template uses PlayerData for reference.

var savedObjects = []
var gridTiles = []
var gridX = 10
var gridY = 10

var playerData = {
	"PlayerLevel" : 1,
	"SavedObjects" : {},
	"GridTiles" : {},
}

var resetData = {
	"PlayerLevel" : 1,
	"SavedObjects" : {},
	"GridTiles" : {},
}

func GetSaveData() -> Dictionary:
	playerData["SavedObjects"] = {}
	for each in savedObjects:
		playerData["SavedObjects"][each.info["RefNumber"]] = each.info
	
	playerData["GridTiles"] = {}
	for each in gridTiles:
		playerData["GridTiles"][each.info["Name"]] = each.info
	
	return playerData

func SetData(data: Dictionary):
	SetUpGridTiles()
	
	for key in data.keys():
		if key == "SavedObjects":
			for each in data["SavedObjects"]:
				var object = ObjectToSave.new()
				object.info = data["SavedObjects"][each]
				savedObjects.append(object)
		elif key == "GridTiles":
			for each in data["GridTiles"]:
				var tile = GridTileToSave.new()
				tile.info = data["GridTiles"][each]
				tile.info["Location"] = Vector2i(tile.info["LocationX"], tile.info["LocationY"])
				
				for each1 in gridTiles:
					if each1.info["Name"] == tile.info["Name"]:
						each1.info = tile.info
		else:
			playerData[key] = data[key]

func ResetData():
	savedObjects.clear()
	gridTiles.clear()
	SetData(resetData)

func SetUpGridTiles():
	for x in gridX:
		for y in gridY:
			var tile = GridTileToSave.new()
			tile.info["Name"] = "(" + str(x) + ", " + str(y) + ")"
			tile.info["LocationX"] = x
			tile.info["LocationY"] = y
			tile.info["Location"] = Vector2i(x, y)
			gridTiles.append(tile)