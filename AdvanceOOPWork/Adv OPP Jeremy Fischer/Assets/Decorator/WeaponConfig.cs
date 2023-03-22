using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Different from book as it is a scriptable object

[CreateAssetMenu(fileName = "NewWeaponConfig", menuName = "NewWeaponConfig/Config")]
public class WeaponConfig : ScriptableObject, IWeapon
{
    [Range(0, 100)]
    [SerializeField] private float rate;

    [Range(0, 100)]
    [SerializeField] private float range;

    [Range(0, 100)]
    [SerializeField] private float strength;

    [Range(0, 100)]
    [SerializeField] private float cooldown;

    public float Range
    {
        get { return range; }
    }

    public float Rate
    {
        get { return rate; }
    }

    public float Strength
    {
        get { return strength; }
    }

    public float Cooldown
    {
        get { return cooldown; }
    }
}
