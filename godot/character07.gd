extends Spatial


# Declare member variables here. Examples:
# var a = 2
# var b = "text"
var fRot = 0


# Called when the node enters the scene tree for the first time.
func _ready():
#	rotate_object_local((Vector3(0, 1, 0)), PI)

	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
#	fRot += delta * PI
	rotate_object_local((Vector3(0, 1, 0)), delta * PI)

#	pass
