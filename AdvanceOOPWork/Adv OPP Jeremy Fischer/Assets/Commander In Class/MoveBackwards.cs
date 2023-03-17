using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackwards : Command
{
    private PlayerController controller;

    public MoveBackwards(PlayerController controller)
    {
        this.controller = controller;
    }

    public override void Execute()
    {
        this.controller.MoveBackwards();
    }
}
