using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMaze : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        int[,] myMap = InstantiateMap(50, 50);

        for(int i = 0; i < 3; i++) { myMap = DrunkenWalk(myMap); }

        DrawMap(myMap);
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

    private int[,] DrunkenWalk(int[,] array)
    {
        int entry = Random.Range(0, 49);

        int y = entry;
        int x = 0;
        while(x < 49)
        {
            int choice = Random.Range(0, 3);

            if(choice == 0)
            {
                x++;
            }else if(choice == 1 && y +1 < 49)
            {
                y++;
            }
            else if(y-1 > 0)
            {
                y--;
            }
            Debug.Log("Making zero" + x + " " + y);
            array[x, y] = 0;
        }
        Debug.Log("asd");
        return array;
    }

    private void DrawMap(int[,] inputArray)
    {
        for (int i = 0; i < 49; i++)
        {
            for (int j = 0; j < 49; j++)
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
