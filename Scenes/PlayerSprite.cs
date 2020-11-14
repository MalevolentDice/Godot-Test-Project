using Godot;
using System;

public class PlayerSprite : AnimatedSprite
{
  public override void _Ready()
  {
    Play();
  }

  public PlayerSprite()
  {
  }

  public override void _Process(float delta)
  {
  }
}
