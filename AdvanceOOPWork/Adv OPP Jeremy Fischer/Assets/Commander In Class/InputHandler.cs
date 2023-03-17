using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Invoker invoker;
    private bool isReplaying;
    private bool isRecording;
    private PlayerController playerController;
    private Command buttonA, buttonD, buttonW;

    void Start()
    {
        invoker = gameObject.AddComponent<Invoker>();
        playerController = FindObjectOfType<PlayerController>();

        buttonA = new MoveLeft(playerController);
        buttonD = new MoveRight(playerController);
        buttonW = new MoveForward(playerController);
    }

    void Update()
    {
        if (!isReplaying && isRecording)
        {
            if (Input.GetKeyUp(KeyCode.A))
                invoker.ExecuteCommand(buttonA);

            if (Input.GetKeyUp(KeyCode.D))
                invoker.ExecuteCommand(buttonD);

            if (Input.GetKeyUp(KeyCode.W))
                invoker.ExecuteCommand(buttonW);
        }
    }

    void OnGUI()
    {
        if (GUILayout.Button("Start Recording"))
        {
            playerController.ResetPosition();
            isReplaying = false;
            isRecording = true;
            invoker.Record();
        }

        if (GUILayout.Button("Stop Recording"))
        {
            playerController.ResetPosition();
            isRecording = false;
        }

        if (!isRecording)
        {
            if (GUILayout.Button("Start Replay"))
            {
                playerController.ResetPosition();
                isRecording = false;
                isReplaying = true;
                invoker.Replay();
            }
        }

        if (GUILayout.Button("Reverse"))
        {
            invoker.StartCoroutine("Reverse");
        }
    }
}
