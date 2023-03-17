using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public void MoveLeft()
    {
        transform.Translate(Vector3.left);
    }

    public void MoveRight()
    {
        transform.Translate(Vector3.right);
    }

    public void MoveForward()
    {
        transform.Translate(Vector3.forward);
    }

    public void MoveBackwards()
    {
        transform.Translate(Vector3.back);
    }

    public void ResetPosition()
    {
        transform.position = new Vector3(-15, 0, 0);
    }
}
