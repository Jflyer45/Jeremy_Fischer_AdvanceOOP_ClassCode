using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBoxView : PlatformerElement
{
    private void OnCollisionEnter(Collision collision)
    {
        app.platformerController.OnDeathBoxHit();
    }
}
