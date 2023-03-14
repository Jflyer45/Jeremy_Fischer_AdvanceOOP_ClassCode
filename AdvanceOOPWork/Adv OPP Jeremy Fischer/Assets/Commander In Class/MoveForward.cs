using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : Command
{
    private PlayerController controller;

    public MoveForward(PlayerController controller)
    {
        this.controller = controller;
    }

    public override void Execute()
    {
        this.controller.MoveLeft();
    }
}
