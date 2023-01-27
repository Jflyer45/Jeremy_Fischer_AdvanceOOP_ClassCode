using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSModel : MonoBehaviour
{
    [Header("Camera")]
    public Transform cam;
    public bool lockCursor;

    [Range(0.1f, 10)] public float lookSensitivity;

    public float maxUpRotation;
    public float maxDownRotation;

    public float xRotation = 0;

    [Header("Movement")]
    public CharacterController controller;

    // Speed of forwards and backwards movement
    [Range(0.5f, 20)] public float walkSpeed;

    // Speed of sideways (left and right) movement
    [Range(0.5f, 15)] public float strafeSpeed;

    public KeyCode sprintKey;

    // How many times faster movement along the X and Z axes
    // is when sprinting
    [Range(1, 3)] public float sprintFactor;

    [Range(0.5f, 10)] public float jumpHeight;
    public int maxJumps;

    public Vector3 velocity = Vector3.zero;
    public int jumpsSinceLastLand = 0;
}
