using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGoblinBuilder : MonsterBuilder
{
    private Monster monster;

    public RandomGoblinBuilder()
    {
        this.monster = new Monster();
    }

    public void buildMonsterColor()
    {
        monster.setMonsterColor(new Color(139/255f, Random.Range(100, 255)/255f, 181/255f));
    }

    public void buildMonsterHealth()
    {
        monster.setMonsterHealth(Random.Range(50, 100));
    }

    public void buildMonsterName()
    {
        monster.setMonsterName("Mc Goblin the " + Random.Range(1, 10) + "th");
    }

    public Monster getMonster()
    {
        return monster;
    }
}
