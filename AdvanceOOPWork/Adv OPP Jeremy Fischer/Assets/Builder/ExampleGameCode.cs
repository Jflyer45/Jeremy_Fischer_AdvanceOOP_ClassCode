using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleGameCode : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Generate Standard Goblin")]
    public void GenerateStandardGoblin()
    {
        MonsterBuilder standardGoblinBuilder = new StandardGoblinBuilder();
        GenerateMonster(standardGoblinBuilder);
    }

    [ContextMenu("Generate Standard Goblin No Color")]
    public void GenerateStandardGoblinNoColor()
    {
        MonsterBuilder standardGoblinBuilder = new StandardGoblinBuilder();
        GenerateMonster(standardGoblinBuilder, false);
    }

    [ContextMenu("Generate Random Goblin")]
    public void GenerateRandomGoblin()
    {
        MonsterBuilder standardGoblinBuilder = new RandomGoblinBuilder();
        GenerateMonster(standardGoblinBuilder);
    }
    
    // See how, no matter the monster, we have the ability to construct how we want?
    // You could even have a scriptable object that is used when constructing
    public void GenerateMonster(MonsterBuilder mb, bool hasColor=true)
    {
        MonsterEngineer myEngineer = new MonsterEngineer(mb);
        if (hasColor) { myEngineer.ConstructMonster(); }
        else          { myEngineer.ContructMonsterNoColor(); }
        Monster monster = myEngineer.getMonster();


        GameObject myCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        CubeProfile p = myCube.AddComponent<CubeProfile>();
        p.SetUp(monster.getMonsterName(), monster.getMonsterColor(), monster.getMonsterHealth());
    }

}
