using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientObjectPool : MonoBehaviour
{
    private MyCubeObjectPool pool;
    // Start is called before the first frame update
    void Start()
    {
        pool = gameObject.AddComponent<MyCubeObjectPool>();
    }

    // Update is called once per frame
    void OnGUI()
    {
        if (GUILayout.Button("Spawn"))
        {
            pool.Spawn();
        }
    }
}
