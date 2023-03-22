using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewWeaponConfig", menuName = "NewWeaponConfig/Attachment")]

public class WeaponAttachment : ScriptableObject, IWeapon
{
    public string attachmentName;
    public string attachmentDescription;

    [Range(0, 100)]
    [SerializeField] private float rate;

    [Range(0, 100)]
    [SerializeField] private float range;

    [Range(0, 100)]
    [SerializeField] private float strength;

    [Range(-5, 10)]
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
