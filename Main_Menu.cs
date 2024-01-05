using Godot;
using System;

public partial class Main_Menu : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready(){
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta){
	}

	private void _on_Start_pressed(){
		
	}

	private void on_start_mouse_entered(){
		GetNode<VBoxContainer>("VBoxContainer").GetNode<Button>("Start").GrabFocus();
	}
}
