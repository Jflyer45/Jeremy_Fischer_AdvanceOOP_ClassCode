using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeProfile : MonoBehaviour
{
    public string cubeName;
    public int health;
    public Color color;
    public void SetUp(string name, Color color, int health)
    {
        cubeName = name;
        this.color = color;
        this.health = health;
    }

    private void Start()
    {
        GetComponent<Renderer>().material = new Material(Shader.Find("Standard"));
        GetComponent<Renderer>().material.color = color;
    }
}
