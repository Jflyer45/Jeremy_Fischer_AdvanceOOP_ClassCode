// By Jeremy Fischer
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceElement : MonoBehaviour
{
    public BounceApplication app { get { return GameObject.FindObjectOfType<BounceApplication>(); } }
}

public class BounceApplication : MonoBehaviour
{
    public BounceModel model;
    public BounceController controlller;
    public BounceView view;
}
