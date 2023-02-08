using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMaze : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {

        DrawMap(InstantiateMap(50,50));
    }

    private int[,] InstantiateMap(int width, int height)
    {
        int[,] myArray = new int[width, height];

        for(int i = 0; i < width; i++)
        {
            for(int j = 0; j < height; j++)
            {
                Debug.Log(i+" "+j);
                myArray[i, j] = 1;
            }
        }
        return myArray;
    }

    private void DrunkenWalk(int[,] array)
    {
        int entry = Random.Range(0, array.Length);


        int y = 0;
        int x = 0;
        while(x < array.Length)
        {
            int choice = Random.Range(0, 2);

            if(choice == 0)
            {

            }else if(choice == 1)
            {

            }
            else
            {

            }
        }
    }

    private void DrawMap(int[,] inputArray)
    {
        for (int i = 0; i < 50; i++)
        {
            for (int j = 0; j < 50; j++)
            {
                if (inputArray[i, j] == 1)
                {
                    Vector3 pos = new Vector3(i, 0, j);
                    Instantiate(cube, pos, Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
