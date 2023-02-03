using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private DateTime sessionStartTime;
    private DateTime sessionEndTime;

    private void Start()
    {
        sessionStartTime = DateTime.Now;
        Debug.Log(sessionStartTime);
    }

    private void OnApplicationQuit()
    {
        sessionEndTime = DateTime.Now;
        TimeSpan timeDifference = sessionStartTime.Subtract(sessionEndTime);
        Debug.Log(timeDifference);

    }

    private void OnGUI()
    {
        if (GUILayout.Button("Next Scene"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
