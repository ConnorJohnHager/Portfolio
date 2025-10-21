extends Node
## Make Global: This template uses GameManager for reference.

func _ready() -> void: ## CAN CHANGE: Load saved data wherever makes sense, example being on load in.
	if !SavingManager.LoadData():
		PlayerData.ResetData()
		SavingManager.SaveData()

func _exit_tree() -> void: ## CAN CHANGE: Save existing data wherever makes sense, example being on closing the game.
	SavingManager.SaveData()