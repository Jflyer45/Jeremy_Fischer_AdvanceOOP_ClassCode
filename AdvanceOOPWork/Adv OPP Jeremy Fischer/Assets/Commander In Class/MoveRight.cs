using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : Command
{
    private PlayerController controller;

    public MoveRight(PlayerController controller)
    {
        this.controller = controller;
    }

    public override void Execute()
    {
        this.controller.MoveLeft();
    }
}
