using Godot;
using System;

public class player : Sprite {
	public override void _Ready() {
	  GD.Print("Test");
	}

  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta) {
    if (Input.IsKeyPressed((int) KeyList.W)) {
      this.Position += new Vector2(0, -1);
    }
    if (Input.IsKeyPressed((int) KeyList.S)) {
      this.Position += new Vector2(0, 1);
    }
    if (Input.IsKeyPressed((int) KeyList.A)) {
      this.Position += new Vector2(-1, 0);
    }
    if (Input.IsKeyPressed((int) KeyList.D)) {
      this.Position += new Vector2(1, 0);
    }
  }
}
