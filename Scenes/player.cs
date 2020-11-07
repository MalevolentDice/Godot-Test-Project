using Godot;
using System;

public class player : Sprite
{
  private Vector2 _velocity = new Vector2(0, 0);
  private readonly int _maxVelocity = 10;
  private readonly int _acceleration = 5;
  public override void _Ready()
  {
  }

  public player()
  {
    // this.Position = new Vector2(32,288-32);
  }

  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
    if (Input.IsKeyPressed((int)KeyList.A))
      _velocity += new Vector2(-1, 0);
    if (Input.IsKeyPressed((int)KeyList.D))
      _velocity += new Vector2(1, 0);

    _velocity.x = Math.Min(_velocity.x, _maxVelocity);
    _velocity.x = Math.Max(_velocity.x, -_maxVelocity);
    Position += _velocity * delta * _acceleration;
  }
}
