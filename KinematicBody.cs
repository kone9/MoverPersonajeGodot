using Godot;
using System;

public class KinematicBody : Godot.KinematicBody

{
    Vector3 movimiento = new Vector3();
    float rotacion = 0; 

    public override void _PhysicsProcess(float delta)
    {
        movimiento.y -= 1;
        MoveAndCollide(movimiento);
        
    }

    public override void _UnhandledInput(InputEvent @event)//funcion input event
    {
        
        if(Input.IsActionPressed("w"))
        {
            movimiento = Transform.basis.z.Normalized();
            GD.Print(movimiento);
        }
        if(Input.IsActionPressed("s"))
        {
            movimiento = Transform.basis.z.Normalized() * -1;
            GD.Print(movimiento);
        }
        if(Input.IsActionJustReleased("w") || Input.IsActionJustReleased("s"))//si solte las teclas
        {
            movimiento = new Vector3(0,0,0);
        }
        if(Input.IsActionPressed("d"))
        {
            rotacion =-1;
            RotateY(Mathf.Deg2Rad(rotacion));
        }
        if(Input.IsActionPressed("a"))
        {
             rotacion =1;
             RotateY(Mathf.Deg2Rad(rotacion));
        }
        
    }
    
}
