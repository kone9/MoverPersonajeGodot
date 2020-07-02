extends KinematicBody


var GRAVEDAD  = 250
var angulo    = 0.0
var velocidad = Vector3()
var velocidad_lat = 50
var MoverPersonaje = Vector3()


func _ready():
	velocidad.y = 0
	angulo = 0.0
	
func _PhysicsProcess(delta):
	MoverPersonaje.y += GRAVEDAD
	move_and_collide(MoverPersonaje)

func _input(event):#funcion inputevnto para procesar entradas de teclado entre otras optimizadas
	#movimiento
	if(Input.is_action_pressed("w")):
		MoverPersonaje += global_transform.basis.z.normalized()
		print(translation) 
		print((MoverPersonaje))
	  
	#rotacion
	if(Input.is_action_pressed("a")):
		angulo = 1
		rotate_y(deg2rad(angulo))
	
	if(Input.is_action_pressed("d")):
		angulo = -1
		rotate_y(deg2rad(angulo))
