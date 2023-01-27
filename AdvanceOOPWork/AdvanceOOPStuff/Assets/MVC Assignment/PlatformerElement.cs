using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerElement : MonoBehaviour
{
    public PlatformerApplication app { get { return GameObject.FindObjectOfType<PlatformerApplication>(); } }
}
