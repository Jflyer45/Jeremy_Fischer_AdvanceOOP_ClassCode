using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : Command
{
    private PlayerController controller;

    public MoveLeft(PlayerController controller)
    {
        this.controller = controller;
    }

    public override void Execute()
    {
        this.controller.MoveLeft();
    }
}
