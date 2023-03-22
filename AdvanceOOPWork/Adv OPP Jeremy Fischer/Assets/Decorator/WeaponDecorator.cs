using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDecorator : IWeapon
{
    private IWeapon decoratedWeapon;
    private WeaponAttachment attachment;

    public WeaponDecorator(IWeapon aWeapon, WeaponAttachment anAttachment)
    {
        this.decoratedWeapon = aWeapon;
        this.attachment = anAttachment;
    }

    public float Range
    {
        get { return decoratedWeapon.Range + attachment.Rate; }
    }

    public float Rate
    {
        get { return decoratedWeapon.Rate + attachment.Range; }
    }

    public float Strength
    {
        get { return decoratedWeapon.Strength + attachment.Strength; }
    }

    public float Cooldown
    {
        get { return decoratedWeapon.Cooldown + attachment.Cooldown; }
    }
}
