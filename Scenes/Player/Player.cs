using Godot;
using System;

public partial class Player : CharacterBody2D
{
	[Export] private Vector2 _velocity; // vetor de x,y float

    //Esse método é chamado uma vez quando tudo estiver pronto
	public override void _Ready()
    {
        
    }


	//Esse método é chamado em loop após o _Ready()
	//delta é o tempo entre os dois frames anteriores
	public override void _Process(double delta)
	{
		_velocity = Velocity; //atribui o valor da velocidade atual do personagem

		// as regras de movimento devem atualizar _velocity

		Velocity = _velocity ; //atualiza a velocidade do personagem
		MoveAndSlide(); //move o personagem de acordo com a velocidade
	}
}
