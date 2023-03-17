using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker : MonoBehaviour
{
    private bool isRecording;
    private bool isReplaying;
    public PlayerController pc;

    private List<Command> recordedCommands = new List<Command>();

    public void ExecuteCommand(Command aCommand)
    {
        aCommand.Execute();
        
        if(isRecording == true)
        {
            recordedCommands.Add(aCommand);
        }

        Debug.Log("Recorded Command: " + aCommand);
    }

    public void Record()
    {
        isRecording = true;
    }

    public void Replay()
    {
        isReplaying = true;

        if(recordedCommands.Count <= 0)
        {
            Debug.Log("There is nothing to replay");
        }
        else
        {
            foreach(var c in recordedCommands)
            {
                Debug.Log("Executing Command: " + c);
                c.Execute();

            }

            isReplaying = false;
        }

    }

    IEnumerator Reverse()
    {
        int i = recordedCommands.Count - 1;
        while (i > -1)
        {
            if(recordedCommands[i] is MoveForward)
            {
                new MoveBackwards(pc).Execute();
            } else if(recordedCommands[i] is MoveRight)
            {
                new MoveLeft(pc).Execute();
            }
            else
            {
                new MoveRight(pc).Execute();
            }
            i--;

            //recordedCommands[i].Execute();
            yield return new WaitForSeconds(.5f);
        }
    }

}
