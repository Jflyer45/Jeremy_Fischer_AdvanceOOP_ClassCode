using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface MonsterBuilder
{
    public void buildMonsterName();
    public void buildMonsterHealth();
    public void buildMonsterColor();

    public Monster getMonster();
}
