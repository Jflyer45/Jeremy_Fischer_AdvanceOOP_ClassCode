using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBoxView : PlatformerElement
{
    private void OnCollisionEnter(Collision collision)
    {
        app.platformerController.OnWinBoxHit();
    }
}
