using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster :  MonsterPlan
{
    private string monsterName;
    private int monsterHealth;
    private Color monsterColor = new Color(1, 1, 1);

    public void setMonsterColor(Color color)
    {
        this.monsterColor = color;
    }

    public void setMonsterHealth(int health)
    {
        this.monsterHealth = health;
    }

    public void setMonsterName(string name)
    {
        this.monsterName = name;
    }

    public Color getMonsterColor()
    {
        return monsterColor;
    }

    public string getMonsterName()
    {
        return monsterName;
    }

    public int getMonsterHealth()
    {
        return monsterHealth;
    }
}
