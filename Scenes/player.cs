using Godot;
using System;

public class player : AnimatedSprite
{
  private Vector2 _direction = new Vector2(0, 0);
  private readonly int _speed = 50;
  public override void _Ready()
  {
    Play();
  }

  public player()
  {
    // Position = new Vector2(32,288-32);
  }

  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
    if (Input.IsKeyPressed((int)KeyList.A))
    {
      _direction = new Vector2(-1, 0);
      FlipH = false;
    }
    else if (Input.IsKeyPressed((int)KeyList.D))
    {
      _direction = new Vector2(1, 0);
      FlipH = true;
    }

    Position += _direction * delta * _speed;
    _direction = new Vector2(0, 0);
  }
}
