using Godot;
using System;

public class PlayerRoot : KinematicBody2D
{
  private readonly int _speed = 50;
  private PackedScene packedScene;
  private int i = 0;
  AnimatedSprite mySprite;

  public override void _Ready()
  {
    mySprite = GetNode<AnimatedSprite>("PlayerSprite");
    packedScene = GD.Load<PackedScene>("res://Scenes/Skeleton.tscn");
  }
  public PlayerRoot()
  {
  }

  public override void _PhysicsProcess(float delta)
  {
    Node2D sprite = (Node2D) packedScene.Instance();
    GetParent().AddChild(sprite);
    GD.Print(i++);

    if (Input.IsKeyPressed((int)KeyList.A))
      moveLeft(delta);
    else if (Input.IsKeyPressed((int)KeyList.D))
      moveRight(delta);

    // MoveAndSlideWithSnap();
  }

  public void moveLeft(float delta)
  {
    Vector2 direction = Vector2.Zero;
    mySprite.FlipH = false;
    direction.x = -1;
    MoveAndCollide(direction * _speed * delta);
  }

  public void moveRight(float delta)
  {
    Vector2 direction = Vector2.Zero;
    mySprite.FlipH = true;
    direction.x = 1;
    MoveAndCollide(direction * _speed * delta);
  }
}
