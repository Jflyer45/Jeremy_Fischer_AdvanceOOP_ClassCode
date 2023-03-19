using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardGoblinBuilder : MonsterBuilder
{
    private Monster monster;

    public StandardGoblinBuilder()
    {
        this.monster = new Monster();
    }

    public void buildMonsterColor()
    {
        monster.setMonsterColor(new Color(139/255f, 255/255f, 181/255f));
    }

    public void buildMonsterHealth()
    {
        monster.setMonsterHealth(100);
    }

    public void buildMonsterName()
    {
        monster.setMonsterName("Goblin");
    }

    public Monster getMonster()
    {
        return monster;
    }
}
