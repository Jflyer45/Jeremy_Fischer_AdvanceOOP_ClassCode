using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PowerUp", menuName = "PowerUp")]
public class PowerUp : ScriptableObject, IVisitor
{
    public string powerUpName;
    public GameObject powerUpPrefab;
    public string powerUpDescription;

    public bool healShield;

    [Range(0.0f, 50f)]
    public float turboBoost;

    [Range(0f, 25)]
    public float weaponRange;

    [Range(0f, 25)]
    public float weaponStrength;


    public void Visit(BikeShield aBikeShield)
    {
        if(healShield == true)
        {
            aBikeShield.health = 100f;
        }
    }

    public void Visit(BikeEngine aBikeEngine)
    {
        
    }

    public void Visit(BikeWeapon aBikeWeapon)
    {
        float range = aBikeWeapon.range += weaponRange;

        if (range >= aBikeWeapon.maxRange)
        {
            aBikeWeapon.range = aBikeWeapon.maxRange;
        }
        else
        {
            aBikeWeapon.range = range;
        }

        float strength = aBikeWeapon.range += weaponRange;

        if (range >= aBikeWeapon.maxRange)
        {
            aBikeWeapon.range = aBikeWeapon.maxRange;
        }
        else
        {
            aBikeWeapon.range = range;
        }
    }
}
