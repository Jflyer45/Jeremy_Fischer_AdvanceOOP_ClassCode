using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterEngineer
{
    private MonsterBuilder monsterBuilder;
    
    public MonsterEngineer(MonsterBuilder monsterBuilder)
    {
        this.monsterBuilder = monsterBuilder;
    }

    public Monster getMonster()
    {
        return this.monsterBuilder.getMonster();
    }

    public void ConstructMonster()
    {
        this.monsterBuilder.buildMonsterColor();
        this.monsterBuilder.buildMonsterHealth();
        this.monsterBuilder.buildMonsterName();
    }

    // In reality you could any number of bool parameters to turn options on and off
    // That are set defualt to true so that the defualt method creates all options.
    public void ContructMonsterNoColor()
    {
        this.monsterBuilder.buildMonsterHealth();
        this.monsterBuilder.buildMonsterName();
    }
}
