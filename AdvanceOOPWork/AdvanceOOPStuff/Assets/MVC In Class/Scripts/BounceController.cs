using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceController : BounceElement
{
    public void OnBallGroundHit()
    {
        app.model.bounces++;
        Debug.Log(app.model.bounces);

        if(app.model.winCondition == app.model.bounces)
        {
            app.view.ball.enabled = false;
            app.view.ball.GetComponent<Rigidbody>().isKinematic = true;
            OnGameComplete();
        }
    }

    void OnGameComplete()
    {
        Debug.Log("The game is complete");
    }
}
