extends Node
## Make Global: This template uses SavingManager for reference.

var savePath = "user://save.json" ## CAN CHANGE: This is the local save location for the json file.

func SaveData():
	var saveData = {
		"player_data" : PlayerData.GetSaveData() 
	}
	
	var saveFile = FileAccess.open(savePath, FileAccess.WRITE)
	if saveFile != null:
		var saveDataString = JSON.stringify(saveData, "\n", false, true)
		saveFile.store_string(saveDataString)
		saveFile.close()
		print("Game Saved")
	else:
		print("Game Save Failed")

func LoadData() -> bool:
	print("Save file path: ", ProjectSettings.globalize_path(savePath))
	var saveFile = FileAccess.open(savePath, FileAccess.READ)
	if saveFile != null:
		var json = JSON.new()
		var result = json.parse(saveFile.get_as_text())
		if result == OK:
			var saveData = json.get_data()
			saveFile.close()
			PlayerData.SetData(saveData["player_data"])
			print("Game Loaded")
			return true
		else:
			print("Game Load Failed")
			return false
	else:
		return false

func DeleteData():
	var dir = DirAccess.open("user://")
	if dir.file_exists(savePath):
		DirAccess.remove_absolute(savePath)
		PlayerData.ResetData()