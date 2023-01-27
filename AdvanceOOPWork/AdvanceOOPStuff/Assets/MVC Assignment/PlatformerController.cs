using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerController : PlatformerElement
{
    public FPSCharacter fPSCharacter;
    public void OnWinBoxHit()
    {
        Debug.Log("You won!");
        Application.Quit();
    }

    public void OnDeathBoxHit()
    {
        Debug.Log("You lose!");
        Application.Quit();
    }
}
